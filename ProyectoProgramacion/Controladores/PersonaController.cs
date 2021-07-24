using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProyectoProgramacion.Modelo;


namespace ProyectoProgramacion.Controladores
{
    public class PersonaController
    {
        private static MiDiarioIntimoBDEntities cnx = new MiDiarioIntimoBDEntities();

        // Listar las personas para agregarlas a AUTORES o cargar los datos del ADMIN
        public static List<Persona> GetAllPersona()
        {
            var persona = from a in cnx.Persona
                        select a;
            return persona.ToList();
        }

        // Agregando una persona nueva, por si el administrador desea agregar un Autor
        public static string AddPersona(string nombre, string apellido, string rut)
        {
            Persona persona = new Persona()
            {
                nombre = nombre,
                apellido = apellido,
                rut = rut
            };
            cnx.Persona.Add(persona);
            cnx.SaveChanges();
            return "Persona agregada";
        }

        // Buscar
        public static Persona FindPersona(string id)
        {
            return cnx.Persona.Find(int.Parse(id));
        }

        // Editar
        public static string EditarPersona(string id)
        {
            Persona persona = cnx.Persona.Find(int.Parse(id));
            cnx.SaveChanges();
            return "Persona modificada";
        }

        // Eliminar una Persona
        public static string RemovePersona(string id_persona)
        {
            Persona persona = cnx.Persona.Find(int.Parse(id_persona));
            cnx.Persona.Remove(persona);
            cnx.SaveChanges();
            return "Persona eliminada";
        }


    }
}