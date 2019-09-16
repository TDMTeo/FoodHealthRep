using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Exam.Models
{

    public class Autor
    {
        [Key]

        public int IDAutor { get; set; }
        public string Nombre { get; set; }

        public string Nacionalidad { get; set; }

        public ICollection<LibAut> LibAut { get; set; }

    }
}