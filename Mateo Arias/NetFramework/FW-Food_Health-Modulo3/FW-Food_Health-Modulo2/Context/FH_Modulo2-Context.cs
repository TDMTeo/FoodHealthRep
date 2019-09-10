using FW_Food_Health_Modulo2.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FW_Food_Health_Modulo2.Context
{
    public class FH_Modulo2_Context :  DbContext
    {
        public DbSet<Pedido> ClPedido { get; set; }

        public System.Data.Entity.DbSet<FW_Food_Health_Modulo2.Models.Domiciliario> Domiciliarios { get; set; }
    }
}