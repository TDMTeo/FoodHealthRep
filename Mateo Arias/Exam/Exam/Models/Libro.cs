using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Exam.Models
{
    public class Libro

    {
        [Key]
        public int IDLibro { get; set; }
        public string Titulo { get; set; }
        public string Editorial { get; set; }

        public string Area { get; set; }

        public ICollection<Prestamo> Prestamo { get; set; }

        public ICollection<LibAut> LibAut { get; set; }

        public virtual Libro Libros { get; set; }


    }
}