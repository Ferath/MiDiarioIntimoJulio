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
        
        public static administrador login(string rut, string password)
        {

            foreach (administrador administrador1 in UsuarioController.GetAll())
            {
                if (administrador1.rut.Equals(rut))
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