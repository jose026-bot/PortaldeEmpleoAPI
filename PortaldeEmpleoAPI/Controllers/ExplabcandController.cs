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
    public class ExplabcandController : ControllerBase
    {
        private readonly DBPortaldeEmpleoContext _context;

        public ExplabcandController(DBPortaldeEmpleoContext context)
        {
            _context = context;
        }

        // GET: api/Explabcand
        [HttpGet]
        [Route("GetExplabcand")]
        public async Task<ActionResult<IEnumerable<Explabcand>>> GetExplabcand()
        {
            return await _context.Explabcand.ToListAsync();
        }

        // GET: api/Explabcand/5
        [HttpGet]
        [Route("GetExplabcandById/{id}")]
        public async Task<ActionResult<Explabcand>> GetExplabcandById(int id)
        {
            var explabcand = await _context.Explabcand.FindAsync(id);

            if (explabcand == null)
            {
                return NotFound();
            }

            return explabcand;
        }

        // PUT: api/Explabcand/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut]
        [Route("PutExplabcand/{id}")]
        public async Task<IActionResult> PutExplabcand(int id, Explabcand explabcand)
        {
            if (id != explabcand.Idexplabcand)
            {
                return BadRequest();
            }

            _context.Entry(explabcand).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ExplabcandExists(id))
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

        // POST: api/Explabcand
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        [Route("PostExplabcand")]
        public async Task<ActionResult<Explabcand>> PostExplabcand(Explabcand explabcand)
        {
            _context.Explabcand.Add(explabcand);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetExplabcand", new { id = explabcand.Idexplabcand }, explabcand);
        }

        // DELETE: api/Explabcand/5
        [HttpDelete]
        [Route("DeleteExplabcand/{id}")]
        public async Task<IActionResult> DeleteExplabcand(int id)
        {
            var explabcand = await _context.Explabcand.FindAsync(id);
            if (explabcand == null)
            {
                return NotFound();
            }

            _context.Explabcand.Remove(explabcand);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ExplabcandExists(int id)
        {
            return _context.Explabcand.Any(e => e.Idexplabcand == id);
        }
    }
}
