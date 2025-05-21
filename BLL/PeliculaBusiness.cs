using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PeliculaBusiness
    {
        private PeliculaDao PeliculaDao = new PeliculaDao();
        private CategoriaBusiness CategoriaBusiness = new CategoriaBusiness();

        public void cargarPelicula(Pelicula pelicula)
        {
            try
            {
                if(String.IsNullOrEmpty(pelicula.Titulo) || pelicula.Titulo.Length <= 5)
                {
                    throw new Exception("El titulo de la pelicula debe tener más de cinco caracteres");
                }
                if(String.IsNullOrEmpty(pelicula.Descripcion) || pelicula.Descripcion.Length <= 15)
                {
                    throw new Exception("La descripcion debe tener más de 15 caracteres");
                }
                if(pelicula.IdCategoria <= 0)
                {
                    throw new Exception("La pelicula debe tener una categoría");
                }
                if(CategoriaBusiness.GetCategorias().Where(c => c.IdCategoria == pelicula.IdCategoria).Count() <= 0)
                {
                    throw new Exception("No existe una categoria con el ID indicado");
                }
                if(pelicula.AñoLanzamiento < 1970)
                {
                    throw new Exception("El año de lanzamiento no puede ser menor a 1970");
                }
                if(pelicula.AñoLanzamiento > DateTime.Now.Year)
                {
                    throw new Exception("El año de lanzamiento no puede superar al actual");
                }
                if(pelicula.Duracion < 1 || pelicula.Duracion > 4)
                {
                    throw new Exception("La duración de la pelicula no puede ser menor a 1 hora ni mayor a 4 horas");
                }
                if(pelicula.Calificacion < 1 || pelicula.Calificacion > 5)
                {
                    throw new Exception("La calificación de la pelicula debe estar entre 1 y 5 estrellas");
                }
                pelicula.FechaAlta = DateTime.Today;
                PeliculaDao.cargarPelicula(pelicula);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void eliminarPelicula(int idPelicula)
        {
            try
            {
                //if(this.GetPeliculas().Where(p => p.IdPelicula == idPelicula).Count() <= 0)
                //{
                //    throw new Exception("No se encontró una pelicula con ese ID");
                //}

                PeliculaDao.eliminarPelicula(idPelicula);
            }
            catch(Exception ex)
            {
                throw;
            }
        }

        public void modificarCalificacion(int idPelicula, int nuevaCalificacion)
        {
            try
            {
                if (nuevaCalificacion < 1 || nuevaCalificacion > 5)
                {
                    throw new Exception("La nueva calificación de la pelicula debe estar entre 1 y 5 estrellas");
                }
                if (this.GetPeliculas().Where(p => p.IdPelicula == idPelicula).Count() <= 0)
                {
                    throw new Exception("No se encontró una pelicula con ese ID");
                }
                PeliculaDao.modificarCalificacion(idPelicula, nuevaCalificacion);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public List<Pelicula> GetPeliculas()
        {
            try
            {
                List<Pelicula> listaPeliculas = new List<Pelicula>();
                listaPeliculas = PeliculaDao.GetPeliculas();
                foreach(Pelicula p in listaPeliculas)
                {
                    p.Categoria = CategoriaBusiness.GetCategorias().Where(c => c.IdCategoria == p.IdCategoria).ToList().First().Descripcion;
                }
                return listaPeliculas;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
