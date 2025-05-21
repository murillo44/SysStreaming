using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Pelicula
    {
        private int idPelicula;
        private int idCategoria;
        private string categoria;
        private string titulo;
        private string descripcion;
        private int añoLanzamiento;
        private decimal duracion;
        private int calificacion;
        private DateTime fechaAlta;

        public int IdPelicula { get => idPelicula; set => idPelicula = value; }
        public int IdCategoria { get => idCategoria; set => idCategoria = value; }
        public string Categoria { get => categoria; set => categoria = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int AñoLanzamiento { get => añoLanzamiento; set => añoLanzamiento = value; }
        public decimal Duracion { get => duracion; set => duracion = value; }
        public int Calificacion { get => calificacion; set => calificacion = value; }
        public DateTime FechaAlta { get => fechaAlta; set => fechaAlta = value; }
    }
}
