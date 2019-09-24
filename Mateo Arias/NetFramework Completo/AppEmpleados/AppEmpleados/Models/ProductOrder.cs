using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppEmpleados.Models
{
    public class ProductOrder: Product
    {
        public float Quality { get; set; }
        public decimal Value { get {  return Price * (decimal)Quality; } }

    }
}