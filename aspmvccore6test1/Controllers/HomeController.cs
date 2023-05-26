using aspmvccore6test1.Models;
using Microsoft.AspNetCore.Mvc;

namespace aspmvccore6test1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult declaration()
        {
            return View();
        }

        public IActionResult information()
        {
            return View();
        }


        [HttpGet]
        public IActionResult Details()
        {
            Product? product = ProductDataAccessLayer.GetStudentData();


            return View(product);
        }

    }
}
