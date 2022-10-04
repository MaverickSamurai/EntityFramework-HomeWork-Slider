using EntityFramework_SliderTask.Data;
using EntityFramework_SliderTask.Models;
using EntityFramework_SliderTask.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace EntityFramework_SliderTask.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Slider> sliders = _context.Sliders.ToList();
            SliderDetail sliderDetail = _context.SliderDetails.FirstOrDefault();

            HomeVM model = new HomeVM
            {
                Sliders = sliders,
                SliderDetail = sliderDetail
            };

            return View(model);
        }
    }
}
