using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Food_Health_Modulo_3__B_4._3_.Models
{
    public class Orden
    {
        [Key]
        public int idOrden { get; set; }

        public string NombrePedido { get; set; }

        [Display(Name = "Fecha de Pedido")]
        [Required(ErrorMessage = "Ingrese su  {0}")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime FechaOrden { get; set; }


        [Required]
        [Display(Name = "Cliente")]
        public int idCliente { get; set; }
        public virtual Cliente Cliente { get; set; }
        public ICollection<Domiciliario> Domiciliarios { get; set; }
    }
}