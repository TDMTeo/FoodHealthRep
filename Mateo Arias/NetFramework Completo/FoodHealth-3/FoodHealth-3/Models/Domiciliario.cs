using System;
using System.ComponentModel.DataAnnotations;

namespace FoodHealth_3.Models
{
    public class Domiciliario
    {

        [Key]
        public int IdDomiciliario { get; set; }

        public string Primer_Nombre { get; set; }

        public string Segundo_Nombre { get; set; }

        public decimal Edad { get; set; }

        public DateTime Año_Nacimiento { get; set; }

        public string Correo { get; set; }

        public int EstadosID { get; set; }

        public virtual TiposEstados TiposEstados { get; set; }
    }
}