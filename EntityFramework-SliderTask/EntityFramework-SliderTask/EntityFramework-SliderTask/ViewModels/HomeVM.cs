using EntityFramework_SliderTask.Models;
using System.Collections.Generic;

namespace EntityFramework_SliderTask.ViewModels
{
    public class HomeVM
    {
        public List<Slider> Sliders { get; set; }
        public SliderDetail SliderDetail { get; set; }
    }
}
