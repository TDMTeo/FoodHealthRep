using FW_Food_Health_Modulo2.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FW_Food_Health_Modulo2.Context
{
    public class FH_Modulo3_Context : DbContext
    {
        public DbSet<Domiciliario> ClDomiciliario { get; set; }
    }
}