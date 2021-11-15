using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FinalDesarrolloWebBM.Models
{
    public class Nota
    {
        public int Id { get; set; }

        [ForeignKey("Alumno")]
        public int Idalumno { get; set; }
        [ForeignKey("Idalumno")]
        public virtual Alumno Alumno { get; set; }

        [Required]
        public int idcurso { get; set; }

        [Required]
        [Range(0, 100, ErrorMessage = "La nota debe estar entre 0 y 100")]
        public int nota { get; set; }

    }
}
