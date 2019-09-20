using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Food_Health_Modulo_3__B_4._3_.Models
{
    public class Cliente
    {
        [Key]
        public int idCliente { get; set; }
        [Required]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }
        [Required]
        [Display(Name = "Dirección")]
        public string Direccion { get; set; }
        [Required]
        [Display(Name = "Ciudad")]
        public int idCiudad { get; set; }
        public virtual Ciudad Ciudad { get; set; }
        public ICollection<Orden> Ordens { get; set; }
    }
}