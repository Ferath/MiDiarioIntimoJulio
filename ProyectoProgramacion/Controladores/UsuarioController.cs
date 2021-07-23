using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProyectoProgramacion.Modelo;

namespace ProyectoProgramacion.Controladores
{
    public class UsuarioController
    {
        // Conexion a la BDLocal
        private static MiDiarioIntimoBDEntities cnx = new MiDiarioIntimoBDEntities();


        // Obtener lista de administradores
        public static List<Administradores> GetAll()
        {
            var administradores = from ad in cnx.Administradores
                                 select ad;
            return administradores.ToList();
        }


    }
}