using Core_3._1_Blog.AccesoDatos.Data.Repository;
using Core_3._1_Blog.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core_3._1_Blog.AccesoDatos.Data
{
    public class ArticuloRepository : Repository<Articulo>, IArticuloRepository
    {
        private readonly ApplicationDbContext _db;

        public ArticuloRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        /*
        public IEnumerable<SelectListItem> GetListaCategorias()
        {
            //throw new NotImplementedException();
            return _db.Articulo.Select(i => new SelectListItem()
            {
                Text = i.Nombre,
                Value = i.Id.ToString()
            });
        }
        */
        public void Update(Articulo articulo)
        {
            //throw new NotImplementedException();
            var objDesdeDb = _db.Articulo.FirstOrDefault(s => s.Id == articulo.Id);
            objDesdeDb.Nombre = articulo.Nombre;
            objDesdeDb.Descripcion = articulo.Descripcion;
            objDesdeDb.UrlImage = articulo.UrlImage;
            objDesdeDb.CategoriaId = articulo.CategoriaId;
            //_db.SaveChanges();
        }
    }
}
