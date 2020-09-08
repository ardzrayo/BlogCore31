using Core_3._1_Blog.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core_3._1_Blog.AccesoDatos.Data.Repository
{
    public interface IArticuloRepository : IRepository<Articulo>
    {
        //IEnumerable<SelectListItem> GetListaCategorias();
        void Update(Articulo articulo);
    }
}
