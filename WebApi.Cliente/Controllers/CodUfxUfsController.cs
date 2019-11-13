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
    public class CodUfxUfsController : ControllerBase
    {
        private readonly PfjContext _context;

        public CodUfxUfsController(PfjContext context)
        {
            _context = context;
        }

        // GET: api/CodUfxUfs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CodUfxUfs>>> GetCodUfxUfs()
        {
            return await _context.CodUfxUfs.FromSql("Select Id, nome, sigla From CodUfxUf").ToListAsync();
        }
    }
}