using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Exam.Models
{
    public class LibAut
    {
        [Key]

        public int IDAutor { get; set; }
        public int IDLibro { get; set; }

        public ICollection <Libro> Libro { get; set; }

        public ICollection<Autor> Autor { get; set; }

        public virtual LibAut LibAutor{ get; set; }



    }
}