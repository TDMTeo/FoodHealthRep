using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace Exam.Models
{
    public class Estudiante
    {
        [Key]

        public int IDlector { get; set; }
        public int CI { get; set; }

        public String Nombre { get; set; }

        public String Direccion{ get; set; }
        public string Carrera { get; set; }

        public int Edad { get; set; }

        // public virtual  { get; set; }

        public ICollection<Prestamo> Prestamo { get; set; }

    }
}