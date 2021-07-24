using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProyectoProgramacion.Modelo;


namespace ProyectoProgramacion.Controladores
{
    public class AutorController
    {
        private static MiDiarioIntimoBDEntities cnx = new MiDiarioIntimoBDEntities();
        // Obtener lista
        public static List<Autor> GetAll()
        {
            var autor = from a in cnx.Autor
                             select a;
            return autor.ToList();
        }

        public static string AddAutor(string id)
        {
            Persona persona = cnx.Persona.Find(int.Parse(id));

            Autor autor = new Autor()
            {
                Fk_Persona = int.Parse(id),
            };

            cnx.Autor.Add(autor);
            cnx.SaveChanges();
            return "Autor creado";
        }
        // Buscar
        public static Autor FindAutor(string id)
        {
            return cnx.Autor.Find(int.Parse(id));
        }
        // Editar
        public static string EditAutor(string id, string nombre, string apellido, string rut)
        {
            Autor autor1 = cnx.Autor.Find(int.Parse(id));
            autor1.Persona.rut = rut;
            autor1.Persona.nombre = nombre;
            autor1.Persona.apellido = apellido;
            cnx.SaveChanges();
            return "Autor modificado";
        }

        // Eliminar Autor
        public static string RemoveAutor(string id)
        {
            Autor autor = cnx.Autor.Find(int.Parse(id));
            cnx.Autor.Remove(autor);
            cnx.SaveChanges();
            return "Autor eliminado";
        }
    }
}