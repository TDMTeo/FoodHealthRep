using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Food_Health_Modulo_3__B_4._3_.Models
{
    public class Ciudad
    {
        [Key]
        public int idCiudad { get; set; }
        [Required]
        [Display(Name = "Nombre Ciudad")]
        public string NombreCiudad { get; set; }
        //public int idBarrio { get; set; }

        public ICollection<Cliente> Clientes { get; set; }
    }
}