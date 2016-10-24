using System;
using System.Collections.Generic;
using photodotnet.Data;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace photodotnet.Models
{
	public class PhotoRepository : IPhotoRepository
	{
		private readonly PhotoContext _context;

		public PhotoRepository(PhotoContext context)
		{
			_context = context;
		}

		public async Task<IEnumerable<Photo>> GetAll()
		{
			return await _context.Photo.ToListAsync();
		}

		public void Add(Photo item)
		{
			_context.Photo.Add(item);
		}

		public async Task<Photo> Find(Guid id)
		{
			var item = await _context.Photo.FirstAsync(c => c.Id == id);
			return item;
		}

		public async Task<Photo> Find(string key)
		{
			var item = await _context.Photo.FirstAsync(c => c.Key == key);
			return item;
		}

		public async Task<Photo> Remove(string key)
		{
			var item = await _context.Photo.FirstAsync(c => c.Key == key);
			 _context.Photo.Remove(item);
			return item;
		}

		public void Update(Photo item)
		{
			//
		}
	}
}
