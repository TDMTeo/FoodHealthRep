using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Food_Health_Modulo_3__B_4._3_.Models
{
    public class Food_Health_Modulo_3__B_4_3_Context : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public Food_Health_Modulo_3__B_4_3_Context() : base("name=Food_Health_Modulo_3__B_4_3_Context")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }
        public System.Data.Entity.DbSet<Food_Health_Modulo_3__B_4._3_.Models.Domiciliario> Domiciliarios { get; set; }

        public System.Data.Entity.DbSet<Food_Health_Modulo_3__B_4._3_.Models.Orden> Ordens { get; set; }

        public System.Data.Entity.DbSet<Food_Health_Modulo_3__B_4._3_.Models.Cliente> Clientes { get; set; }

        public System.Data.Entity.DbSet<Food_Health_Modulo_3__B_4._3_.Models.Ciudad> Ciudads { get; set; }
    }
}
