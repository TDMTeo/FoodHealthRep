using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AppEmpleados.Models
{
    public class DocumentType
    {
        [Key]
        
        public int DocumentTypeId { get; set; }
        [Display(Name = "Tipo Documento")]
        public string DocumentName { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<Customer> customers{ get; set; }

    }
}