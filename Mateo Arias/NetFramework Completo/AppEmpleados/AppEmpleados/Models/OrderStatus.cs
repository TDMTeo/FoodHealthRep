using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppEmpleados.Models
{
    public enum OrderStatus
    {
        created,
        InProgress,
        Shipped,
        Delivered
    }
}