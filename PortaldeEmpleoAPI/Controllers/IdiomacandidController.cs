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
    public class IdiomacandidController : ControllerBase
    {
        private readonly DBPortaldeEmpleoContext _context;

        public IdiomacandidController(DBPortaldeEmpleoContext context)
        {
            _context = context;
        }

        // GET: api/Idiomacandid
        [HttpGet]
        [Route("GetIdiomacandid")]
        public async Task<ActionResult<IEnumerable<Idiomacandid>>> GetIdiomacandid()
        {
            return await _context.Idiomacandid.ToListAsync();
        }

        // GET: api/Idiomacandid/5
        [HttpGet]
        [Route("GetIdiomacandid/{id}")]
        public async Task<ActionResult<Idiomacandid>> GetIdiomacandid(int id)
        {
            var idiomacandid = await _context.Idiomacandid.FindAsync(id);

            if (idiomacandid == null)
            {
                return NotFound();
            }

            return idiomacandid;
        }

        // PUT: api/Idiomacandid/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut]
        [Route("PutIdiomacandid/{id}")]
        public async Task<IActionResult> PutIdiomacandid(int id, Idiomacandid idiomacandid)
        {
            if (id != idiomacandid.Ididioma)
            {
                return BadRequest();
            }

            _context.Entry(idiomacandid).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!IdiomacandidExists(id))
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

        // POST: api/Idiomacandid
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        [Route("PostIdiomacandid")]
        public async Task<ActionResult<Idiomacandid>> PostIdiomacandid(Idiomacandid idiomacandid)
        {
            _context.Idiomacandid.Add(idiomacandid);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetIdiomacandid", new { id = idiomacandid.Ididioma }, idiomacandid);
        }

        // DELETE: api/Idiomacandid/5
        [HttpDelete]
        [Route("DeleteIdiomacandid/{id}")]
        public async Task<IActionResult> DeleteIdiomacandid(int id)
        {
            var idiomacandid = await _context.Idiomacandid.FindAsync(id);
            if (idiomacandid == null)
            {
                return NotFound();
            }

            _context.Idiomacandid.Remove(idiomacandid);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool IdiomacandidExists(int id)
        {
            return _context.Idiomacandid.Any(e => e.Ididioma == id);
        }
    }
}
