using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Exam.Models
{
    public class Prestamo
    {
        [Key]

        public int IDLector { get; set; }
        public int IDLibro { get; set; }


        public DateTime FechaPrestamo { get; set; }

        public DateTime FechaDevolucion { get; set; }
        public string Devuelto { get; set; }

        public ICollection<Estudiante> Estudiante { get; set; }

        public ICollection<Libro> Libro { get; set; }

        public virtual Prestamo Prestamos { get; set; }

        //public virtual DocumentoType DocumentoTypes { get; set; }
    }
}