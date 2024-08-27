using Microsoft.AspNetCore.Mvc;

namespace EcnesLibrary.Controllers
{
    public class LibraryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
