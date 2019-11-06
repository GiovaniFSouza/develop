using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApi.Cliente.Models;

namespace WebApi.Cliente.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstadoCivilController : ControllerBase
    {
        private readonly PfjContext _context;

        public EstadoCivilController(PfjContext context)
        {
            _context = context;
        }

        // GET: api/EstadoCivil
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EstadoCivil>>> GetestadoCivil()
        {
            return await _context.EstadoCivil.ToListAsync();
        }

        // GET: api/estadoCivil/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EstadoCivil>> GetestadoCivil(int id)
        {
            var estadoCivil = await _context.EstadoCivil.FindAsync(id);

            if (estadoCivil == null)
            {
                return NotFound();
            }

            return estadoCivil;
        }

        // PUT: api/estadoCivil/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutestadoCivil(int id, EstadoCivil estadoCivil)
        {
            if (id != estadoCivil.Id)
            {
                return BadRequest();
            }

            _context.Entry(estadoCivil).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EstadoCivilExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/estadoCivil
        [HttpPost]
        public async Task<ActionResult<EstadoCivil>> PostestadoCivil(EstadoCivil estadoCivil)
        {
            _context.EstadoCivil.Add(estadoCivil);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetestadoCivil", new { id = estadoCivil.Id }, estadoCivil);
        }

        // DELETE: api/estadoCivil/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EstadoCivil>> DeleteestadoCivil(int id)
        {
            var estadoCivil = await _context.EstadoCivil.FindAsync(id);
            if (estadoCivil == null)
            {
                return NotFound();
            }

            _context.EstadoCivil.Remove(estadoCivil);
            await _context.SaveChangesAsync();

            return estadoCivil;
        }

        private bool EstadoCivilExists(int id)
        {
            return _context.EstadoCivil.Any(e => e.Id == id);
        }
    }
}
