using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
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

        
        // Crear un administrador
        public static string AddAdministrador(string username, string fk_personaid, string password, string Rol_usuario)
        {
            Administradores administradores = new Administradores()
            {
                Username = username,
                Fk_personaid = int.Parse(fk_personaid),
                password = Encrypt.GetMD5(password),
                rol_usuario = int.Parse(Rol_usuario),
            };
            cnx.Administradores.Add(administradores);
            cnx.SaveChanges();
            return "Editor agregado";
        }

        // Buscar
        public static Administradores FindAdmin(string id_admin)
        {
            return cnx.Administradores.Find(int.Parse(id_admin));
        }



    }
}