using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Core_3._1_Blog.Models
{
    public class Slider
    {
        [Key]
        public int Id { get; set; }
        
        [Required(ErrorMessage ="Por favor, ingrasa un nombre.")]
        [Display(Name ="Nombre Slider")]
        public string Nombre { get; set; }
        public bool Estado { get; set; }

        [DataType(DataType.ImageUrl)]
        [Display(Name = "Imagen")]
        public string UrlImagen { get; set; }
    }
}
