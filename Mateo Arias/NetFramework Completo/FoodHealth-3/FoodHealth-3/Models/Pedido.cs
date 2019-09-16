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

        [Display(Name ="Nombre del Pedido")]
        public string Nombre { get; set; }

        [Display(Name = "Direccion del Pedido")]
        public string Direccion { get; set; }

        [Display(Name = "Descripcion del Pedido")]
        public string Descripcion { get; set; }

        [Display(Name = "Caracteristicas del pedido")]
        public string Caracteristicas { get; set; }

        [Display(Name = "Cliente")]
        public string Cliente { get; set; }

        [Display(Name = "Telefono del Cliente")]
        public int Telefono { get; set; }

        public ICollection<Domiciliario> Domiciliarios { get; set; }
    }
}