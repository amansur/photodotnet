using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using photodotnet.Models;

namespace photodotnet.Controllers
{
    [Route("api/[controller]")]
    public class PhotoController : Controller
    {
		private readonly IPhotoRepository _repository;
		public PhotoController(IPhotoRepository repository)
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
        public string Get(int id)
        {
            return "value";
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
