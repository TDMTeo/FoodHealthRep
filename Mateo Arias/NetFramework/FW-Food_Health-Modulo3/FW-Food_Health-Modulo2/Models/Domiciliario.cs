using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FW_Food_Health_Modulo2.Models
{
    public class Domiciliario
    {
        [Key]
        public int IdDomiciliario { get; set; }

        public string Nomb_Domiciliario { get; set; }

        public int Telefono { get; set; }

        public int Edad { get; set; }
    }
}