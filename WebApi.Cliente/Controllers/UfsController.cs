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
    public class UfsController : ControllerBase
    {
        private readonly PfjContext _context;

        public UfsController(PfjContext context)
        {
            _context = context;
        }

        // GET: api/Ufs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Ufs>>> GetUfs()
        {
            return await _context.Ufs.ToListAsync();
        }

        // GET: api/Ufs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Ufs>> GetUfs(int id)
        {
            var ufs = await _context.Ufs.FindAsync(id);

            if (ufs == null)
            {
                return NotFound();
            }

            return ufs;
        }

        // PUT: api/Ufs/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUfs(int id, Ufs ufs)
        {
            if (id != ufs.Id)
            {
                return BadRequest();
            }

            _context.Entry(ufs).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UfsExists(id))
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

        // POST: api/Ufs
        [HttpPost]
        public async Task<ActionResult<Ufs>> PostUfs(Ufs ufs)
        {
            _context.Ufs.Add(ufs);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUfs", new { id = ufs.Id }, ufs);
        }

        // DELETE: api/Ufs/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Ufs>> DeleteUfs(int id)
        {
            var ufs = await _context.Ufs.FindAsync(id);
            if (ufs == null)
            {
                return NotFound();
            }

            _context.Ufs.Remove(ufs);
            await _context.SaveChangesAsync();

            return ufs;
        }

        private bool UfsExists(int id)
        {
            return _context.Ufs.Any(e => e.Id == id);
        }
    }
}
