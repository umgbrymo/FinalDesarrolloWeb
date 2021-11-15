using FinalDesarrolloWebBM.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalDesarrolloWebBM.Context
{
    public class ModeloContexto : DbContext
    {
        public ModeloContexto(DbContextOptions<ModeloContexto> options):base(options)
        {

        }

        public DbSet<Alumno> AlumnoItems { get; set; }
        public DbSet<Nota> NotaItems { get; set; }
    }
}
