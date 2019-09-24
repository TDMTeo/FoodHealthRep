using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AppEmpleados.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        [Display(Name = "Tipo Documento")]
        public int DocumentTypeId { get; set; }
        [Display(Name = "Documento")]
        public string Document { get; set; }
        [Display(Name = "Nombres")]
        [Required(ErrorMessage = "Debe ingresar los {0}")]
        [StringLength(30, ErrorMessage = "El campo {0} debe tener entre (2) y (1) caracteres", MinimumLength = 3)]
        public string FirstName { get; set; }

        [Display(Name = "Apellidos")]
        [Required(ErrorMessage = "Debe ingresar los {0}")]
        [StringLength(30, ErrorMessage = "El campo {0} debe tener entre (2) y (1) caracteres", MinimumLength = 3)]
        public string LastName { get; set; }

        [Display(Name = "Telefono")]
        [Required(ErrorMessage = "Debe ingresar el {0}")]
        [StringLength(30, ErrorMessage = "El campo {0} debe tener entre (2) y (1) caracteres", MinimumLength = 3)]
        public string Phone { get; set; }

        [Display(Name = "Direccion")]
        [Required(ErrorMessage = "Debe ingresar la {0}")]
        public string Address { get; set; }


        [Display(Name = "Correo")]
        [Required(ErrorMessage = "Debe ingresar un {0}")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public string FullName { get { return string.Format("{0} {1}", FirstName, LastName); } }

        public virtual DocumentType DocumentType{ get; set; }
    }
}