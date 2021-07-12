using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProyectoProgramacion.Modelo;

namespace ProyectoProgramacion.Controladores
{
    public class MetodopagoController
    {
        // Conexion a la BDLocal
        private static MiDiarioIntimoBDEntities cnx = new MiDiarioIntimoBDEntities();
        // Obtener lista
        public static List<Metodopago> GetAll()
        {
            var metodopago = from c in cnx.Metodopago
                           select c;
            return metodopago.ToList();
        }
    }
}