﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Core_3._1_Blog.Models;
using Core_3._1_Blog.AccesoDatos.Data.Repository;
using Core_3._1_Blog.Models.ViewModels;

namespace Core_3._1_Blog.Controllers
{
    [Area("Cliente")]
    public class HomeController : Controller
    {
        private readonly IContenedorTrabajo _contenedorTrabajo;

        public HomeController(IContenedorTrabajo contenedorTrabajo)
        {
            _contenedorTrabajo = contenedorTrabajo;
        }

        public IActionResult Index()
        {
            HomeVM homeVM = new HomeVM()
            {
                Slider = _contenedorTrabajo.Slider.GetAll(),
                ListaArticulos = _contenedorTrabajo.Articulo.GetAll()
            };
            return View(homeVM);
        }

        public IActionResult Details(int id)
        {
            var articuloDesdeDb = _contenedorTrabajo.Articulo.GetFirstOrDefault(a => a.Id == id);
            return View(articuloDesdeDb);
        }
    }
}
