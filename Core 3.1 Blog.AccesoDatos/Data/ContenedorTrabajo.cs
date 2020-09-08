using Core_3._1_Blog.AccesoDatos.Data.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core_3._1_Blog.AccesoDatos.Data
{
    public class ContenedorTrabajo : IContenedorTrabajo
    {
        private readonly ApplicationDbContext _db;

        public ContenedorTrabajo(ApplicationDbContext db)
        {
            _db = db;
            Categoria = new CategoriaRepository(_db);
            Articulo = new ArticuloRepository(_db);
            Slider = new SliderRepository(_db);
            Usuario = new UsuarioRepository(_db);
        }
        public ICategoriaRepository Categoria { get; private set; }
        public IArticuloRepository Articulo { get; private set; }
        public ISliderRepository Slider { get; private set; }
        public IUsuarioRepository Usuario { get; private set; }

        public void Dispose()
        {
            //throw new NotImplementedException();
            _db.Dispose();
        }

        public void Save()
        {
            //throw new NotImplementedException();
            _db.SaveChanges();
        }
    }
}
