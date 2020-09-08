using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Core_3._1_Blog.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required(ErrorMessage ="Por favor, ingresa un nombre de usuario.")]
        public string Nombre { get; set; }
        public string Direccion { get; set; }

        [Required(ErrorMessage = "Por favor, ingresa la ciudad.")]
        public string Ciudad { get; set; }

        [Required(ErrorMessage = "Por favor, ingresa el país.")]
        public string Pais { get; set; }
    }
}
