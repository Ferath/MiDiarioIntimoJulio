//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoProgramacion.Modelo
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MiDiarioIntimoBDEntities : DbContext
    {
        public MiDiarioIntimoBDEntities()
            : base("name=MiDiarioIntimoBDEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Administradores> Administradores { get; set; }
        public virtual DbSet<Autor> Autor { get; set; }
        public virtual DbSet<Donacion> Donacion { get; set; }
        public virtual DbSet<Metodopago> Metodopago { get; set; }
        public virtual DbSet<Noticia> Noticia { get; set; }
        public virtual DbSet<Persona> Persona { get; set; }
        public virtual DbSet<rol> rol { get; set; }
    }
}
