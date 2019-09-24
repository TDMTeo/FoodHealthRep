using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AppEmpleados.Models
{
    public class Supplier
    {
        [Key]
        public int SupplierId { get; set; }

        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "Debe ingresar el {0}")]
        public string Name { get; set; }

        [Display(Name = "Nombre de Contacto")]
        [Required(ErrorMessage = "Debe ingresar el {0}")]
        public string ContactFirsName { get; set; }

        [Display(Name = "Apellido de Contacto")]
        [Required(ErrorMessage = "Debe ingresar el {0}")]
        public string ContactLastName { get; set; }

        [Display(Name = "Telefono")]
        [Required(ErrorMessage = "Debe ingresar el {0}")]
        public string Phone { get; set; }

        [Display(Name = "Direccion")]
        [Required(ErrorMessage = "Debe ingresar una {0}")]
        public string Address { get; set; }

        [Display(Name = "Correo")]
        [Required(ErrorMessage = "Debe ingresar el {0}")]
        public string Email { get; set; }

        public virtual ICollection<SupplierProduct> SupplierProducts { get; set; }
    }

}