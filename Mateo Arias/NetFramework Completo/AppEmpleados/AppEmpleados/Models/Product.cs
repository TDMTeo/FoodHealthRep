using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AppEmpleados.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "Debe ingresar un {0}")]
        public string Name { get; set; }

        [Display(Name = "Descripcion")]
        public string Description { get; set; }

        [Display(Name = "Precio")]
        [Required(ErrorMessage = "Debe ingresar un {0}")]
        public decimal Price { get; set; }

        [Display(Name = "Ultima Compra")]
        [Required(ErrorMessage = "Debe ingresar una {0})")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime LastBuy { get; set; }

        [Display(Name = "Existencia")]
        [Required(ErrorMessage = "Debe ingresar una {0}")]
        public int Stock { get; set; }
        public string Comments { get; set; }

        public virtual ICollection<SupplierProduct> SupplierProducts { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}