//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace INCOME.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Egresos
    {
        public int IdEgreso { get; set; }
        public Nullable<int> IdUser { get; set; }
        public Nullable<int> Tipo { get; set; }
        public Nullable<decimal> Monto { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
    
        public virtual CategoriasE CategoriasE { get; set; }
        public virtual Usuarios Usuarios { get; set; }
    }
}
