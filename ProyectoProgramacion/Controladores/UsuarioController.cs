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
        public static List<administrador> GetAll()
        {
            var administrador1 = from m in cnx.administrador
                                select m;
            return administrador1.ToList();
        }


    }
}