using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProyectoProgramacion.Modelo;

namespace ProyectoProgramacion.Controladores
{
    public class DonacionesController
    {
        // Conexion a la BDLocal
        private static MiDiarioIntimoBDEntities cnx = new MiDiarioIntimoBDEntities();

        // Metodos de clase
        //Agregar
        public static string AddDonacion(string monto_donacion, string id)
        {
            Metodopago metodopago = cnx.Metodopago.Find(int.Parse(id));

            Donacion donacion = new Donacion()
            {
                monto_donacion = float.Parse(monto_donacion),
                metodopago = int.Parse(id),
            };

            cnx.Donacion.Add(donacion);
            cnx.SaveChanges();
            return "Donacion realizada";
        }

        // Buscar
        public static Donacion FindDonacion (string id)
        {
            return cnx.Donacion.Find(int.Parse(id));
        }

        // No es legal o etico modificar donaciones, pero queda el codigo
        public static string Editdonacion(string idDonacion, string idMetodoPago)
        {
            Metodopago metodopago = cnx.Metodopago.Find(int.Parse(idMetodoPago));
            Donacion donacion = cnx.Donacion.Find(int.Parse(idDonacion));

            donacion.metodopago = metodopago.id;
            cnx.SaveChanges();

            return "Donacion modificada";
        }

        // No esta bien manipular donaciones de ningun tipo, pero queda el Eliminar Donacion
        public static string RemoveDonacion(string id)
        {
            Donacion donacion = cnx.Donacion.Find(int.Parse(id));
            cnx.Donacion.Remove(donacion);

            return "Donacion eliminada";
        }

        // Obtener lista
        public static List<Donacion> GetAll()
        {
            var donacion = from m in cnx.Donacion
                           select m;
            return donacion.ToList();
        }
        
    }
}