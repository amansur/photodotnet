using Microsoft.EntityFrameworkCore;
using photodotnet.Data;

namespace photodotnet.Models
{
	public static class DbInitializer
	{
		public static void Initialize(PhotoContext context)
		{
			//context.Database.EnsureCreated();
			context.Database.Migrate();
		}
	}
}