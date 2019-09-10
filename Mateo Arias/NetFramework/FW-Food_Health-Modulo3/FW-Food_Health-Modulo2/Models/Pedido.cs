using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FW_Food_Health_Modulo2.Models
{
    public class Pedido
    {
        [Key]
        public int IdPedido { get; set; }

        public int CodigoQR { get; set; }

        public string Descripcion { get; set; }

        public string Nomb_Cliente { get; set; }

    }
}