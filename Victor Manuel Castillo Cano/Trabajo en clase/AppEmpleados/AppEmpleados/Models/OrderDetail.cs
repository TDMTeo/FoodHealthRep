using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AppEmpleados.Models
{
    public class OrderDetail
    {
        [Key]
        public int OrderDetailID { get; set; }
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public float Quality { get; set; }

        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}