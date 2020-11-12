using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cine_final_final
{
    class Peliculas
    {
        int genero, clasificacion, Id;
        string titulo, reseña, director, actor;
        DateTime año;

        public int pId { get => Id; set => Id = value; }
        public int pGenero { get => genero; set => genero = value; }       
        public int pClasificacion { get => clasificacion; set => clasificacion = value; }
        public string pTitulo { get => titulo; set => titulo = value; }
        public string pReseña { get => reseña; set => reseña = value; }
        public string pDirector { get => director; set => director = value; }
        public string pActor { get => actor; set => actor = value; }
        public DateTime pAño { get => año; set => año = value; }

        public Peliculas()
        {
            genero = 0;
            Id = 0;
            clasificacion = 0;
            titulo = "";
            reseña = "";
            director = "";
            actor = "";
            año = DateTime.Today;
        }
        public Peliculas(int genero, int clasificacion, int id,
        string titulo, string reseña, string director, string actor,
        DateTime año)
        {
            this.genero = genero;
            this.Id = id;
            this.clasificacion = clasificacion;
            this.titulo = titulo;
            this.reseña = reseña;
            this.director = director;
            this.actor = actor;
            this.año = año;
        }

        public string toStringPelicula()
        {
            return titulo + " " + año.Year;
        }

    }
}
