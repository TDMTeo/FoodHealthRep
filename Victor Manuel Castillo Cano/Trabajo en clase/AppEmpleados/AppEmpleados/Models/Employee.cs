using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AppEmpleados.Models
{
    public class Employee
    {
        [Key]
        public int EmployeId { get; set; }

        [Display(Name = "Nombres")]
        [Required(ErrorMessage = "Debe ingresar los {0}")]
        [StringLength(30, ErrorMessage = "El campo {0} debe tener entre (2) y (1) caracteres", MinimumLength = 3)]
        public string FirstName { get; set; }

        [Display(Name = "Apellido")]
        [Required(ErrorMessage = "Debe ingresar los {0}")]
        public string LastName { get; set; }

        [Display(Name = "Salario")]
        [Required(ErrorMessage = "Debe ingresar el {0}")]
        [DisplayFormat(DataFormatString = "{0:C1}", ApplyFormatInEditMode = false)]
        public decimal Salary { get; set; }

        [Display(Name = "Fecha Nacimiento")]
        [Required(ErrorMessage = "Debe ingresar una {0})")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DateOfBirth { get; set; }

        [NotMapped]
        [Display(Name = "Edad")]
        public int age { get { return DateTime.Now.Year - DateOfBirth.Year;} }

        [Display(Name = "Correo")]
        [Required(ErrorMessage = "Debe ingresar un {0}")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "Tipo Documento")]
        public int DocumentTypeId { get; set; }
        public virtual DocumentType DocumentTypes { get; set; }
    }
}