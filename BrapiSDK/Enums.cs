namespace BrapiSDK
{
	public static class Range
	{
		public static string None = "";
		public static string Daily = "1d";
		public static string Weekly = "5d";
		public static string Monthly = "1mo";
		public static string Quarter = "3mo";
		public static string Semester = "6mo";
		public static string Anual = "1y";
		public static string BiAnual = "2y";
		public static string Pentanual = "5y";
		public static string Decanual = "10y";
		public static string YearToDate = "ytd";
		public static string Max = "max";

		public static bool IsValid(string range)
		{
			return range == None || range == Daily || range == Weekly || range == Monthly || range == Quarter || range == Semester || range == Anual || range == BiAnual || range == Pentanual || range == Decanual || range == YearToDate || range == Max;
		}
	}

	public static class SortBy
	{
		public static string None = "";
		public static string Name = "name";
		public static string Close = "close";
		public static string Change = "name";
		public static string ChangeAbs = "name";
		public static string Volume = "name";
		public static string MarketCapBasic = "name";
		public static string Sector = "name";

		public static bool IsValid(string sortBy)
		{
			return sortBy == None || sortBy == Name || sortBy == Close || sortBy == Change || sortBy == ChangeAbs || sortBy == Volume || sortBy == MarketCapBasic || sortBy == Sector;
		}
	}

	public static class SortOrder
	{
		public static string None = "";
		public static string Ascending = "asc";
		public static string Descending = "desc";

		public static bool IsValid(string sortOrder)
		{
			return sortOrder == None || sortOrder == Ascending || sortOrder == Descending;
		}
	}
}
