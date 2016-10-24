using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using photodotnet.Models;

namespace photodotnet.Controllers
{
    [Route("[controller]")]
    public class ApiController : Controller
    {
		private readonly IPhotoRepository _repository;
		public ApiController(IPhotoRepository repository)
		{
			_repository = repository;
		}

        // GET api/values
        [HttpGet]
        public async Task<IEnumerable<Photo>> Get()
        {
			return await _repository.GetAll();
        }

		// GET api/values/5
		[HttpGet("{id}")]
        public Task<Photo> Get(string id)
        {
			//Task<Photo> photo;
			//if (new Guid(id) == new Guid())
			//	photo = _repository.Find(id);
			//else
			//	photo = _repository.Find(new Guid(id));

			//return await photo;

			Task<Photo> photo;
			Guid guid;
			Guid.TryParse(id, out guid);
			if (guid == new Guid())
				photo = _repository.Find(id);
			else
				photo = _repository.Find(new Guid(id));

			return photo;
		}
		

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
