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
    public class AlumnoController : ControllerBase
    {
        private readonly ModeloContexto _context;

        public AlumnoController(ModeloContexto contexto)
        {
            _context = contexto;

        }
        //Para consultar un alumno
        [HttpGet("{id}")]
        public async Task<ActionResult<Alumno>> GetAlumnoItem(int id)
        {
            var AlumnoItem = await _context.AlumnoItems.FindAsync(id);

            if (AlumnoItem == null)
            {
                return NotFound();
            }

            return AlumnoItem;
        }

        //Crear alumno
        [HttpPost]
        public async Task<ActionResult<Alumno>> PostAlumnoItem(Alumno item)
        {
            _context.AlumnoItems.Add(item);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetAlumnoItem), new { id = item.Id }, item);
        }

        //Para modificar alumno
        //Para eliminación lógica se usaría este mismo, para poder actualizar el estatus del alumno
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAlumnoItem(int id, Alumno item)
        {
            if (id != item.Id)
            {
                return BadRequest();

            }

            _context.Entry(item).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

    }
}
