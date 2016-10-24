using Microsoft.AspNetCore.Mvc;
using photodotnet.Models;

namespace photodotnet.Controllers
{
    public class PhotoController : Controller
    {
		private readonly IPhotoRepository _repository;
		public PhotoController(IPhotoRepository repository)
		{
			_repository = repository;
		}

        public IActionResult Index()
		{
			return View();
		}
    }
}
