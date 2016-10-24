using Microsoft.EntityFrameworkCore;
using photodotnet.Models;

namespace photodotnet.Data
{
	public class PhotoContext : DbContext
	{
		public PhotoContext(DbContextOptions<PhotoContext> options) : base(options)
		{
		}

		public DbSet<Photo> Photo { get; set; }
	}
}
