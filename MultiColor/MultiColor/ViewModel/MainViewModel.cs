using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiColor.ViewModel
{
    public class MainViewModel
    {
        public SliderColorViewModel SliderColor { get; set; }
        public MainViewModel()
        {
            SliderColor = new SliderColorViewModel();
        }
    }
}
