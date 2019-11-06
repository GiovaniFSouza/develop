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
    public class CodUfController : ControllerBase
    {
        private readonly PfjContext _context;

        public CodUfController(PfjContext context)
        {
            _context = context;
        }

        // GET: api/CodUf
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CodUf>>> GetCodUf()
        {
            return await _context.CodUf.ToListAsync();
        }

        // GET: api/CodUf/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CodUf>> GetCodUf(int id)
        {
            var codUf = await _context.CodUf.FindAsync(id);

            if (codUf == null)
            {
                return NotFound();
            }

            return codUf;
        }

        // PUT: api/CodUf/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCodUf(int id, CodUf codUf)
        {
            if (id != codUf.Id)
            {
                return BadRequest();
            }

            _context.Entry(codUf).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CodUfExists(id))
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

        // POST: api/CodUf
        [HttpPost]
        public async Task<ActionResult<CodUf>> PostCodUf(CodUf codUf)
        {
            _context.CodUf.Add(codUf);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCodUf", new { id = codUf.Id }, codUf);
        }

        // DELETE: api/CodUf/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<CodUf>> DeleteCodUf(int id)
        {
            var codUf = await _context.CodUf.FindAsync(id);
            if (codUf == null)
            {
                return NotFound();
            }

            _context.CodUf.Remove(codUf);
            await _context.SaveChangesAsync();

            return codUf;
        }

        private bool CodUfExists(int id)
        {
            return _context.CodUf.Any(e => e.Id == id);
        }
    }
}
