using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PortaldeEmpleoAPI.Models;

namespace PortaldeEmpleoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FormaccandController : ControllerBase
    {
        private readonly DBPortaldeEmpleoContext _context;

        public FormaccandController(DBPortaldeEmpleoContext context)
        {
            _context = context;
        }

        // GET: api/Formaccand
        [HttpGet]
        [Route("GetFormaccand")]
        public async Task<ActionResult<IEnumerable<Formaccand>>> GetFormaccand()
        {
            return await _context.Formaccand.ToListAsync();
        }

        // GET: api/Formaccand/5
        [HttpGet]
        [Route("GetFormaccandById/{id}")]
        public async Task<ActionResult<Formaccand>> GetFormaccandById(int id)
        {
            var formaccand = await _context.Formaccand.FindAsync(id);

            if (formaccand == null)
            {
                return NotFound();
            }

            return formaccand;
        }

        // PUT: api/Formaccand/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut]
        [Route("PutFormaccand/{id}")]
        public async Task<IActionResult> PutFormaccand(int id, Formaccand formaccand)
        {
            if (id != formaccand.Idformacadem)
            {
                return BadRequest();
            }

            _context.Entry(formaccand).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FormaccandExists(id))
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

        // POST: api/Formaccand
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        [Route("PostFormaccand")]
        public async Task<ActionResult<Formaccand>> PostFormaccand(Formaccand formaccand)
        {
            _context.Formaccand.Add(formaccand);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFormaccand", new { id = formaccand.Idformacadem }, formaccand);
        }

        // DELETE: api/Formaccand/5
        [HttpDelete]
        [Route("DeleteFormaccand/{id}")]
        public async Task<IActionResult> DeleteFormaccand(int id)
        {
            var formaccand = await _context.Formaccand.FindAsync(id);
            if (formaccand == null)
            {
                return NotFound();
            }

            _context.Formaccand.Remove(formaccand);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool FormaccandExists(int id)
        {
            return _context.Formaccand.Any(e => e.Idformacadem == id);
        }
    }
}
