using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FoodHealth_3.Models
{
    public class TiposEstados
    {

        [Key]
        public int EstadosID { get; set; }

        public string Estado { get; set; }

        public ICollection<Domiciliario> Domiciliarios { get; set; }

    }
}