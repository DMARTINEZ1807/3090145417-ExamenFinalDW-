//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ejercicio1.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class db_a7bcf6_hotelumgEntities : DbContext
    {
        public db_a7bcf6_hotelumgEntities()
            : base("name=db_a7bcf6_hotelumgEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Ejercicio1> Ejercicio1 { get; set; }
    
        public virtual ObjectResult<EP_buscar_loginejercicio_Result> EP_buscar_loginejercicio(string usuario, string pass)
        {
            var usuarioParameter = usuario != null ?
                new ObjectParameter("usuario", usuario) :
                new ObjectParameter("usuario", typeof(string));
    
            var passParameter = pass != null ?
                new ObjectParameter("pass", pass) :
                new ObjectParameter("pass", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<EP_buscar_loginejercicio_Result>("EP_buscar_loginejercicio", usuarioParameter, passParameter);
        }
    }
}
