﻿using Core_3._1_Blog.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core_3._1_Blog.AccesoDatos.Data.Repository
{
    public interface ISliderRepository : IRepository<Slider>
    {
        //IEnumerable<SelectListItem> GetListaCategorias();
        void Update(Slider slider);
    }
}
