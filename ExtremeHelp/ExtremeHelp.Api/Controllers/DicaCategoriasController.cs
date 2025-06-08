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
    public class DicaCategoriasController : ControllerBase
    {
        private readonly DatabaseContext _context;

        public DicaCategoriasController(DatabaseContext context)
        {
            _context = context;
        }

        // GET: api/DicaCategorias
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DicaCategoria>>> GetDicaCategorias()
        {
            return await _context.DicaCategorias.ToListAsync();
        }

        // GET: api/DicaCategorias/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DicaCategoria>> GetDicaCategoria(int id)
        {
            var dicaCategoria = await _context.DicaCategorias.FindAsync(id);

            if (dicaCategoria == null)
            {
                return NotFound();
            }

            return dicaCategoria;
        }

        // PUT: api/DicaCategorias/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDicaCategoria(int id, DicaCategoria dicaCategoria)
        {
            if (id != dicaCategoria.Id)
            {
                return BadRequest();
            }

            _context.Entry(dicaCategoria).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DicaCategoriaExists(id))
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

        // POST: api/DicaCategorias
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<DicaCategoria>> PostDicaCategoria(DicaCategoria dicaCategoria)
        {
            _context.DicaCategorias.Add(dicaCategoria);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDicaCategoria", new { id = dicaCategoria.Id }, dicaCategoria);
        }

        // DELETE: api/DicaCategorias/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDicaCategoria(int id)
        {
            var dicaCategoria = await _context.DicaCategorias.FindAsync(id);
            if (dicaCategoria == null)
            {
                return NotFound();
            }

            _context.DicaCategorias.Remove(dicaCategoria);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DicaCategoriaExists(int id)
        {
            return _context.DicaCategorias.Any(e => e.Id == id);
        }
    }
}
