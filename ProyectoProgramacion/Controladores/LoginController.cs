using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProyectoProgramacion.Modelo;


namespace ProyectoProgramacion.Controladores
{
    public class LoginController
    {
        // Conexion a la BDLocal
        private static MiDiarioIntimoBDEntities cnx = new MiDiarioIntimoBDEntities();

        public static administrador login(string nombre, string password)
        {

            foreach (administrador administrador1 in UsuarioController.GetAll())
            {
                if (administrador1.nombre.Equals(nombre))
                {
                    if (administrador1.password.Equals(password))
                    {
                        return administrador1;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            return null;

        }
    }
}