using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProyectoProgramacion.Modelo;

namespace ProyectoProgramacion.Controladores
{
    public class NoticiaController
    {
        // Conexion a la BDLocal
        private static MiDiarioIntimoBDEntities cnx = new MiDiarioIntimoBDEntities();

        // Metodos de clase
        //Agregar
        public static string AddNoticia(string titulo_noticia, string fecha_noticia, string FK_autor, string descripcion_noticia)
        {

            Noticia noticia = new Noticia()
            {
                titulo_noticia = titulo_noticia,
                fecha_noticia = DateTime.Parse(fecha_noticia),
                autor = int.Parse(FK_autor),
                descripcion_noticia = descripcion_noticia,

            };

            cnx.Noticia.Add(noticia);
            cnx.SaveChanges();
            return "Noticia realizada realizada";
        }

        // Buscar
        public static Noticia FindNoticia(string id)
        {
            return cnx.Noticia.Find(int.Parse(id));
        }

        // Modificar
        public static string Editdonacion(string idNoticia, string idAutor)
        {
            Autor autor = cnx.Autor.Find(int.Parse(idAutor));
            Noticia noticia = cnx.Noticia.Find(int.Parse(idNoticia));

            autor.id = noticia.id;
            cnx.SaveChanges();

            return "Noticia modificada";
        }

        // Eliminar Donacion
        public static string RemoveNoticia(string id)
        {
            Noticia noticia = cnx.Noticia.Find(int.Parse(id));
            cnx.Noticia.Remove(noticia);
            cnx.SaveChanges();

            return "Noticia eliminada";
        }

        // Obtener lista
        public static List<Noticia> GetAll()
        {
            var noticia = from n in cnx.Noticia
                           select n;
            return noticia.ToList();
        }

    }
}