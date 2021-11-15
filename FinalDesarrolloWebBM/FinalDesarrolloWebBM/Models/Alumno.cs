using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalDesarrolloWebBM.Models
{
    public class Alumno
    {
        public int Id { get; set; }

        [Required]
        public string primer_nombre { get; set; }
        [Required]
        public string segundo_nombre { get; set; }
        [Required]
        public string primer_apellido { get; set; }
        [Required]
        public string segundo_apellido { get; set; }
        [Required]
        public bool activo { get; set; }

        public bool aprobadoreprobado { get; set; }
    }
}
