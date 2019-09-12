using System;
using System.ComponentModel.DataAnnotations;

namespace FoodHealth_3.Models
{
    public class Domiciliario
    {

        [Key]
        public int IdDomiciliario { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public decimal Edad { get; set; }

        public DateTime Fecha_Nacimiento { get; set; }

        public string Correo { get; set; }

        public int IdPedido { get; set; }

        public virtual Pedido Pedido { get; set; }
        
        public int EstadosID { get; set; }

        public virtual TiposEstados TiposEstados { get; set; }
    }
}