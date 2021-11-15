using FinalDesarrolloWebBM.Context;
using FinalDesarrolloWebBM.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalDesarrolloWebBM.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Reportes2Controller : ControllerBase
    {
        private readonly ModeloContexto _context;

        public Reportes2Controller(ModeloContexto contexto)
        {
            _context = contexto;

        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Alumno>>> GetContactoItems()
        {
            return await _context.AlumnoItems.Include(x => x.aprobadoreprobado).Where(x => x.aprobadoreprobado == true).ToListAsync();
        }
    }
}
