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
    public class NotasController : ControllerBase
    {
        private readonly ModeloContexto _context;

        public NotasController(ModeloContexto contexto)
        {
            _context = contexto;

        }

        //Para consultar una nota en especifico 
        [HttpGet("{id}")]
        public async Task<ActionResult<Nota>> GetNotaItem(int id)
        {
            var NotaItem = await _context.NotaItems.FindAsync(id);

            if (NotaItem == null)
            {
                return NotFound();
            }

            return NotaItem;
        }

        //Para crear un registro de notas
        [HttpPost]
        public async Task<ActionResult<Alumno>> PostNotasItem(Nota item)
        {
            _context.NotaItems.Add(item);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetNotaItem), new { id = item.Id }, item);
        }

        //Para modificar un registo de notas
        [HttpPut("{id}")]
        public async Task<IActionResult> PutNotasItem(int id, Nota item)
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
