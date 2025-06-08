using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ExtremeHelp.Api.Data;
using ExtremeHelp.Api.Models;

namespace ExtremeHelp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DicaPreparacaosController : ControllerBase
    {
        private readonly DatabaseContext _context;

        public DicaPreparacaosController(DatabaseContext context)
        {
            _context = context;
        }

        // GET: api/DicaPreparacaos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DicaPreparacao>>> GetDicaPreparacoes()
        {
            return await _context.DicaPreparacoes.ToListAsync();
        }

        // GET: api/DicaPreparacaos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DicaPreparacao>> GetDicaPreparacao(int id)
        {
            var dicaPreparacao = await _context.DicaPreparacoes.FindAsync(id);

            if (dicaPreparacao == null)
            {
                return NotFound();
            }

            return dicaPreparacao;
        }

        // PUT: api/DicaPreparacaos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDicaPreparacao(int id, DicaPreparacao dicaPreparacao)
        {
            if (id != dicaPreparacao.Id)
            {
                return BadRequest();
            }

            _context.Entry(dicaPreparacao).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DicaPreparacaoExists(id))
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

        // POST: api/DicaPreparacaos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<DicaPreparacao>> PostDicaPreparacao(DicaPreparacao dicaPreparacao)
        {
            _context.DicaPreparacoes.Add(dicaPreparacao);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDicaPreparacao", new { id = dicaPreparacao.Id }, dicaPreparacao);
        }

        // DELETE: api/DicaPreparacaos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDicaPreparacao(int id)
        {
            var dicaPreparacao = await _context.DicaPreparacoes.FindAsync(id);
            if (dicaPreparacao == null)
            {
                return NotFound();
            }

            _context.DicaPreparacoes.Remove(dicaPreparacao);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DicaPreparacaoExists(int id)
        {
            return _context.DicaPreparacoes.Any(e => e.Id == id);
        }
    }
}
