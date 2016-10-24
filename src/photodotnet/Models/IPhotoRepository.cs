using System.Collections.Generic;
using System.Threading.Tasks;

namespace photodotnet.Models
{
    public interface IPhotoRepository
    {
		void Add(Photo item);
		Task<IEnumerable<Photo>> GetAll();
		Task<Photo> Find(string key);
		Task<Photo> Remove(string key);
		void Update(Photo item);
	}
}
