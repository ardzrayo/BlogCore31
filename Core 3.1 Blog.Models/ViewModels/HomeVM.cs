using System;
using System.Collections.Generic;
using System.Text;

namespace Core_3._1_Blog.Models.ViewModels
{
    public class HomeVM
    {
        public IEnumerable<Slider> Slider { get; set; }
        public IEnumerable<Articulo> ListaArticulos { get; set; }
    }
}
