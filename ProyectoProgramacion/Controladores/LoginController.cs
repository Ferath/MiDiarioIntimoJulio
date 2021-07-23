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
        
        public static Administradores login(string rut, string password)
        {

            foreach (Administradores administradores in UsuarioController.GetAll())
            {
                if (administradores.Persona.rut.Equals(rut))
                {
                    if (administradores.password.Equals(password))
                    {
                        return administradores;
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