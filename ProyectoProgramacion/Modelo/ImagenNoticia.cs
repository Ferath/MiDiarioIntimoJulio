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
    using System.Collections.Generic;
    
    public partial class ImagenNoticia
    {
        public int id { get; set; }
        public Nullable<int> noticiaRel { get; set; }
        public byte[] imagen { get; set; }
    
        public virtual Noticia Noticia { get; set; }
    }
}
