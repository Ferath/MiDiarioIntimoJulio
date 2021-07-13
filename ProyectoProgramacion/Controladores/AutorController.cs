﻿using System;
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

        public static string AddAutor(string nombre, string apellido, string rut)
        {
            Autor autor1 = new Autor()
            {
                nombre = nombre,
                apellido = apellido,
                rut = rut
            };

            cnx.Autor.Add(autor1);
            cnx.SaveChanges();
            return "Autor agregado";
        }
        public static Autor FindAutor(string id)
        {
            return cnx.Autor.Find(int.Parse(id));
        }
        public static string EditAutor(string idAutor )
        {
            Autor autor = cnx.Autor.Find(int.Parse(idAutor));

            cnx.SaveChanges();

            return "Donacion modificada";
        }

        // Eliminar Autor
        public static string RemoveAutor(string id)
        {
            Autor autor = cnx.Autor.Find(int.Parse(id));
            cnx.Autor.Remove(autor);

            return "Donacion eliminada";
        }
    }
}