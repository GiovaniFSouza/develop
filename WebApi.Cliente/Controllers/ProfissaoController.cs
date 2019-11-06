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
    public class ProfissaoController : ControllerBase
    {
        private readonly PfjContext _context;

        public ProfissaoController(PfjContext context)
        {
            _context = context;
        }

        // GET: api/Profissao
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Profissao>>> Getprofissao()
        {
                       
            return await _context.Profissao.OrderBy(n => n.nome).ToListAsync();
        }

        // GET: api/profissao/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Profissao>> Getprofissao(int id)
        {
            var profissao = await _context.Profissao.FindAsync(id);

            if (profissao == null)
            {
                return NotFound();
            }

            return profissao;
        }

        // PUT: api/profissao/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProfissao(int id, Profissao profissao)
        {
            if (id != profissao.Id)
            {
                return BadRequest();
            }

            _context.Entry(profissao).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProfissaoExists(id))
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

        // POST: api/profissao
        [HttpPost]
        public async Task<ActionResult<Profissao>> PostProfissao(Profissao profissao)
        {
            _context.Profissao.Add(profissao);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Getprofissao", new { id = profissao.Id }, profissao);
        }

        // DELETE: api/profissao/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Profissao>> Deleteprofissao(int id)
        {
            var profissao = await _context.Profissao.FindAsync(id);
            if (profissao == null)
            {
                return NotFound();
            }

            _context.Profissao.Remove(profissao);
            await _context.SaveChangesAsync();

            return profissao;
        }

        private bool ProfissaoExists(int id)
        {
            return _context.Profissao.Any(e => e.Id == id);
        }
    }
}
