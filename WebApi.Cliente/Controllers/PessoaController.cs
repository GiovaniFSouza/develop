﻿using System;
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

    public class PessoaController : ControllerBase
    {
        private readonly PfjContext _context;

        public PessoaController(PfjContext context)
        {
            _context = context;
        }

        // GET: api/Pessoa
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Pessoa>>> GetPessoa()
        {
            return await _context.Pessoa.ToListAsync();
        }

        // GET: api/Pessoa/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Pessoa>> GetPessoa(int id)
        {
            var pessoa = await _context.Pessoa.FindAsync(id);

            if (pessoa == null)
            {
                return NotFound();
            }

            return pessoa;
        }

        // PUT: api/Pessoa/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPessoa(int id, Pessoa pessoa)
        {
            if (id != pessoa.Id)
            {
                return BadRequest();
            }

            _context.Entry(pessoa).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PessoaExists(id))
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

        // POST: api/Pessoa
        [HttpPost]
        public async Task<ActionResult<Pessoa>> PostPessoa(Pessoa pessoa)
        {
            _context.Pessoa.Add(pessoa);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPessoa", new { id = pessoa.Id }, pessoa);
        }

        // DELETE: api/Pessoa/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Pessoa>> DeletePessoa(int id)
        {
            var pessoa = await _context.Pessoa.FindAsync(id);
            if (pessoa == null)
            {
                return NotFound();
            }

            _context.Pessoa.Remove(pessoa);
            await _context.SaveChangesAsync();

            return pessoa;
        }

        private bool PessoaExists(int id)
        {
            return _context.Pessoa.Any(e => e.Id == id);
        }
    }
}
