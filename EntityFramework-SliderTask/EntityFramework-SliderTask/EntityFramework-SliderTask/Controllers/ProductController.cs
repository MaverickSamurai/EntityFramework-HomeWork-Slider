using Microsoft.AspNetCore.Mvc;

namespace EntityFramework_SliderTask.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
