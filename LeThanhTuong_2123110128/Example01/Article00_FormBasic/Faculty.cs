namespace LeThanhTuong_2123110128
{
	public class Faculty
	{
		public string Id { get; set; } = "";
		public string Name { get; set; } = "";
		public int Quantity { get; set; }

		public override string ToString() => Name;
	}
}
