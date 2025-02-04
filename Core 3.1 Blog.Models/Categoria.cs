﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Core_3._1_Blog.Models
{
    public class Categoria
    {
        [Key]
        public int Id { get; set; }
        
        [Required(ErrorMessage ="Ingresa un nombre para la categoria")]
        [Display(Name ="Nombre Categoría")]
        public string Nombre { get; set; }
        
        [Required]
        [Display(Name = "Orden de visualización")]
        public int Orden { get; set; }
    }
}
