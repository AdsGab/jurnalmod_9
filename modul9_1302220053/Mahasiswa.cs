using System;

namespace modul9_1302220053
{
	public class Mahasiswa
	{
		public string Name { get; set; }
		public string Nim { get; set; }
		public List<string> Course { get; set; }
		public int Year { get; set; }
		public Mahasiswa(string Name, string Nim, List<string> course, int Year)
		{
			this.Name = Name;
			this.Nim = Nim;
			this.Course = course;
			this.Year = Year;
		}



	}
}