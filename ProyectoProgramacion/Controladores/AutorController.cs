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
    }
}