using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FoodHealth_3.Models
{
    public class FoodHealth_3Context : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public FoodHealth_3Context() : base("name=FoodHealth_3Context")
        {
        }

        public System.Data.Entity.DbSet<FoodHealth_3.Models.Domiciliario> Domiciliarios { get; set; }

        public System.Data.Entity.DbSet<FoodHealth_3.Models.TiposEstados> TiposEstados { get; set; }
    }
}
