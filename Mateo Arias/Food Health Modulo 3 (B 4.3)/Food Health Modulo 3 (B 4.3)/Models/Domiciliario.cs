using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Food_Health_Modulo_3__B_4._3_.Models
{
    public class Domiciliario
    {
        [Key]
        public int idDomiciliario { get; set; }

        [Required]
        [Display(Name ="Nombres")]
        [DataType(DataType.Text)]
        public string Nombres { get; set; }

        [Required]
        [Display(Name = "No. Identificación")]
        public string Identificacion { get; set; }

        [Required]
        [Display(Name = "Correo electrónico")]
        [DataType(DataType.EmailAddress)]
        public string Correo { get; set; }

        [Required]
        [Display(Name = "Fecha de nacimiento")]
        [DisplayFormat(DataFormatString ="{dd/MM/yyyy}")]
        [DataType(DataType.Date)]
        public DateTime FechaNacimiento { get; set; }

        [Required]
        [Display(Name = "Teléfono")]
        [DataType(DataType.PhoneNumber)]
        public string Telefono { get; set; }

        [Required]
        [Display(Name = "Estado")]
        public EstadoOrden EstadoOrden { get; set; }

        [Required]
        [Display(Name = "Pedido")]
        public int idOrden { get; set; }
        public virtual Orden Orden { get; set; }
    }
}