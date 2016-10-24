using System;

namespace photodotnet.Models
{
    public class Photo
	{
		public Guid Id { get; set; }
		public string Key { get; set; }
		public string Name { get; set; }
		public bool Visible { get; set; }
		public string Url { get; set; }
	}
}
