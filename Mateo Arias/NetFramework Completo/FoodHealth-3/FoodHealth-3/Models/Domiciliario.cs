using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodHealth_3.Models
{
    public class Domiciliario
    {

        [Key]
        public int IdDomiciliario { get; set; }

        [Display(Name = "Nombre del Domiciliario")]
        [Required(ErrorMessage = "Ingrese un {0}")]
        [StringLength(30, ErrorMessage = "El {0} debe tener entre {2} y {1} caracteres", MinimumLength =3)]
        public string Nombre { get; set; }

        [Display(Name = "Apellido del Domiciliario")]
        [Required(ErrorMessage = "Ingrese un {0}")]
        [StringLength(30, ErrorMessage = "El {0} debe tener entre {2} y {1} caracteres", MinimumLength = 3)]
        public string Apellido { get; set; }

        [Display(Name = "Fecha de Nacimiento")]
        [Required(ErrorMessage = "Ingrese su  {0}")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Fecha_Nacimiento { get; set; }

        [NotMapped]
        [Display(Name = "Edad Domiciliario")]
        public int Edad { get { return DateTime.Now.Year - Fecha_Nacimiento.Year; } }

        [Display(Name = "Correo")]
        [Required(ErrorMessage = "Ingrese un {0}")]
        [StringLength(30, ErrorMessage = "El {0} debe tener entre {2} y {1} caracteres", MinimumLength = 3)]
        public string Correo { get; set; }

        public int IdPedido { get; set; }

        public virtual Pedido Pedido { get; set; }
        
        public int EstadosID { get; set; }

        public virtual TiposEstados TiposEstados { get; set; }
    }
}