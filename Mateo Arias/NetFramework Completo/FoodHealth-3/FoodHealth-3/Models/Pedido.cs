using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FoodHealth_3.Models
{
    public class Pedido
    {
        [Key]
        public int IdPedido { get; set; }

        public string Nombre { get; set; }

        public string Direccion { get; set; }

        public string Descripcion { get; set; }

        public string Caracteristicas { get; set; }

        public string Cliente { get; set; }

        public int Telefono { get; set; }

        public ICollection<Domiciliario> Domiciliarios { get; set; }
    }
}