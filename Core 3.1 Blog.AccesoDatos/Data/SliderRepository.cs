using Core_3._1_Blog.AccesoDatos.Data.Repository;
using Core_3._1_Blog.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core_3._1_Blog.AccesoDatos.Data
{
    public class SliderRepository : Repository<Slider>, ISliderRepository
    {
        private readonly ApplicationDbContext _db;

        public SliderRepository(ApplicationDbContext db) : base(db)
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
        public void Update(Slider slider)
        {
            //throw new NotImplementedException();
            var objDesdeDb = _db.Slider.FirstOrDefault(s => s.Id == slider.Id);
            objDesdeDb.Nombre = slider.Nombre;
            objDesdeDb.Estado = slider.Estado;
            objDesdeDb.UrlImagen = slider.UrlImagen;
            _db.SaveChanges();
        }
    }
}
