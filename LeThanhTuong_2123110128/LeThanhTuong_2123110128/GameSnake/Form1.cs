using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace GameSnake
{
	// ===== HƯỚNG DI CHUYỂN =====
	enum Direction { Up, Down, Left, Right }

	// ===== BOT RẮN (MÁY) =====
	class BotSnake
	{
		public List<Point> Body = new();   // thân bot
		public Direction Dir;              // hướng di chuyển
	}

	public partial class Form1 : Form
	{
		// ===== ẢNH RẮN =====
		Bitmap snakeHeadImg;
		Bitmap snakeBodyImg;

		// ===== ÂM THANH =====
		SoundPlayer bgm, eatSound, dieSound;

		// ===== DỮ LIỆU GAME =====
		List<Point> snake = new();          // rắn người chơi
		List<Point> obstacles = new();      // chướng ngại vật
		List<BotSnake> bots = new();        // bot máy
		Point food;                         // thức ăn

		Direction direction = Direction.Right; // hướng hiện tại
		Random rnd = new Random();

		int cellSize = 25;   // KÍCH THƯỚC Ô (thầy hỏi chỉnh map ở đâu?)
		int cols, rows;      // số cột / hàng
		int score, level;
		bool running, paused;

		// ===== FONT (KHÔNG TẠO TRONG OnPaint) =====
		readonly Font hudFont = new Font("Segoe UI", 12, FontStyle.Bold);
		readonly Font centerFont = new Font("Segoe UI", 32, FontStyle.Bold);

		// ===== HIGH SCORE =====
		string highScoreFile = "highscore.txt";
		int highScore;

		public Form1()
		{
			InitializeComponent();
			DoubleBuffered = true; // tránh giật hình
			KeyPreview = true;     // bắt phím toàn form

			LoadImages();          // load ảnh rắn
			LoadSounds();          // load âm thanh
			LoadHighScore();       // load điểm cao
		}

		// ===== LOAD FORM =====
		private void Form1_Load(object sender, EventArgs e)
		{
			// Sfullscreen
			FormBorderStyle = FormBorderStyle.None;
			WindowState = FormWindowState.Maximized;
		}

		// ===== LOAD ẢNH AN TOÀN =====
		void LoadImages()
		{
			using (var tmp = new Bitmap("Images/snake_head.png"))
				snakeHeadImg = new Bitmap(tmp);

			using (var tmp = new Bitmap("Images/snake_body.png"))
				snakeBodyImg = new Bitmap(tmp);
		}

		// ===== LOAD ÂM THANH =====
		void LoadSounds()
		{
			bgm = new SoundPlayer("Sounds/bgm.wav");
			eatSound = new SoundPlayer("Sounds/eat.wav");
			dieSound = new SoundPlayer("Sounds/die.wav");
		}

		// ===== HIGH SCORE =====
		void LoadHighScore()
		{
			if (File.Exists(highScoreFile))
				int.TryParse(File.ReadAllText(highScoreFile), out highScore);
		}

		void SaveHighScore()
		{
			if (score > highScore)
				File.WriteAllText(highScoreFile, score.ToString());
		}

		// ===== BẮT ĐẦU GAME =====
		void StartGame()
		{
			//Map tính sao
			cols = ClientSize.Width / cellSize;
			rows = ClientSize.Height / cellSize;

			snake.Clear();
			snake.Add(new Point(cols / 2, rows / 2));
			snake.Add(new Point(cols / 2 - 1, rows / 2));
			snake.Add(new Point(cols / 2 - 2, rows / 2));

			obstacles.Clear();
			bots.Clear();

			score = 0;
			level = 1;
			running = true;
			paused = false;
			direction = Direction.Right;

			SpawnFood();
			SpawnObstacles();
			CreateBots();

			// TỐC ĐỘ GAME 
			gameTimer.Interval = 100;
			gameTimer.Start();

			bgm.PlayLooping();
		}

		// ===== TẠO FOOD =====
		void SpawnFood()
		{
			do
				food = new Point(rnd.Next(1, cols - 1), rnd.Next(1, rows - 1));
			while (snake.Contains(food) || obstacles.Contains(food));
		}

		// ===== CHƯỚNG NGẠI THEO LEVEL =====
		void SpawnObstacles()
		{
			obstacles.Clear();
			for (int i = 0; i < level * 4; i++)
			{
				Point p;
				do
					p = new Point(rnd.Next(1, cols - 1), rnd.Next(1, rows - 1));
				while (snake.Contains(p) || obstacles.Contains(p));

				obstacles.Add(p);
			}
		}

		// ===== TẠO BOT =====
		void CreateBots()
		{
			for (int i = 0; i < 2; i++)
			{
				BotSnake bot = new();
				bot.Body.Add(new Point(rnd.Next(5, cols - 5), rnd.Next(5, rows - 5)));
				bot.Dir = (Direction)rnd.Next(4);
				bots.Add(bot);
			}
		}

		// ===== GAME LOOP =====
		private void gameTimer_Tick(object sender, EventArgs e)
		{
			if (!running || paused) return;

			MoveSnake();
			MoveBots();
			CheckCollision();
			Invalidate(); // vẽ lại màn hình
		}

		// ===== DI CHUYỂN RẮN =====
		void MoveSnake()
		{
			Point head = snake[0];
			Point newHead = head;

			if (direction == Direction.Up) newHead.Y--;
			if (direction == Direction.Down) newHead.Y++;
			if (direction == Direction.Left) newHead.X--;
			if (direction == Direction.Right) newHead.X++;

			snake.Insert(0, newHead);

			// ===== KIỂM TRA ĂN FOOD =====
			if (newHead == food)
			{
				eatSound.Play();
				score += 10;

				// ===== TĂNG LEVEL =====
				if (score % 50 == 0)
				{
					level++;
					if (gameTimer.Interval > 60)
						gameTimer.Interval -= 10;
					SpawnObstacles();
				}
				SpawnFood();
			}
			else
			{
				snake.RemoveAt(snake.Count - 1);
			}
		}

		// ===== DI CHUYỂN BOT =====
		void MoveBots()
		{
			foreach (var bot in bots)
			{
				if (rnd.Next(10) == 0)
					bot.Dir = (Direction)rnd.Next(4);

				Point h = bot.Body[0];
				Point nh = h;

				if (bot.Dir == Direction.Up) nh.Y--;
				if (bot.Dir == Direction.Down) nh.Y++;
				if (bot.Dir == Direction.Left) nh.X--;
				if (bot.Dir == Direction.Right) nh.X++;

				if (nh.X < 1 || nh.Y < 1 || nh.X >= cols - 1 || nh.Y >= rows - 1)
					continue;

				bot.Body.Insert(0, nh);
				if (bot.Body.Count > 6)
					bot.Body.RemoveAt(bot.Body.Count - 1);
			}
		}

		// ===== VA CHẠM (GAME OVER) =====
		void CheckCollision()
		{
			Point h = snake[0];

			if (h.X < 0 || h.Y < 0 || h.X >= cols || h.Y >= rows || obstacles.Contains(h))
				GameOver();

			for (int i = 1; i < snake.Count; i++)
				if (snake[i] == h) GameOver();

			foreach (var bot in bots)
				if (bot.Body.Contains(h)) GameOver();
		}

		void GameOver()
		{
			running = false;
			gameTimer.Stop();
			bgm.Stop();
			dieSound.Play();
			SaveHighScore();
		}

		// ===== VẼ GAME =====
		protected override void OnPaint(PaintEventArgs e)
		{
			Graphics g = e.Graphics;
			DrawGrid(g);

			if (!running)
			{
				DrawCenterText(g,
					"SNAKE GAME\n\nENTER: START\nESC: EXIT\n\nHIGH SCORE: " + highScore);
				return;
			}

			foreach (var o in obstacles)
				g.FillRectangle(Brushes.DimGray, o.X * cellSize, o.Y * cellSize, cellSize, cellSize);

			foreach (var bot in bots)
				foreach (var p in bot.Body)
					g.FillRectangle(Brushes.CornflowerBlue, p.X * cellSize, p.Y * cellSize, cellSize, cellSize);

			// VẼ ĐẦU RẮN
			g.DrawImage(snakeHeadImg, snake[0].X * cellSize, snake[0].Y * cellSize, cellSize, cellSize);

			// VẼ THÂN RẮN
			for (int i = 1; i < snake.Count; i++)
				g.DrawImage(snakeBodyImg, snake[i].X * cellSize, snake[i].Y * cellSize, cellSize, cellSize);

			g.FillEllipse(Brushes.Red, food.X * cellSize, food.Y * cellSize, cellSize, cellSize);

			g.DrawString($"Score: {score}  Level: {level}  High: {highScore}",
				hudFont, Brushes.White, 10, 10);
		}

		// ===== VẼ NỀN GRID =====
		void DrawGrid(Graphics g)
		{
			g.Clear(Color.Black);
			for (int x = 0; x < Width; x += cellSize)
				g.DrawLine(Pens.DarkGreen, x, 0, x, Height);
			for (int y = 0; y < Height; y += cellSize)
				g.DrawLine(Pens.DarkGreen, 0, y, Width, y);
		}

		void DrawCenterText(Graphics g, string text)
		{
			SizeF s = g.MeasureString(text, centerFont);
			g.DrawString(text, centerFont, Brushes.Yellow,
				(Width - s.Width) / 2,
				(Height - s.Height) / 2);
		}

		// ===== INPUT =====
		private void Form1_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape) Close();
			if (!running && e.KeyCode == Keys.Enter) StartGame();

			if (e.KeyCode == Keys.Up && direction != Direction.Down) direction = Direction.Up;
			if (e.KeyCode == Keys.Down && direction != Direction.Up) direction = Direction.Down;
			if (e.KeyCode == Keys.Left && direction != Direction.Right) direction = Direction.Left;
			if (e.KeyCode == Keys.Right && direction != Direction.Left) direction = Direction.Right;

			// PAUSE GAME
			if (e.KeyCode == Keys.Space) paused = !paused;
		}
	}
}
