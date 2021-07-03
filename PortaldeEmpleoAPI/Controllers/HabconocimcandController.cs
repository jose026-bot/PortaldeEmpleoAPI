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
    public class HabconocimcandController : ControllerBase
    {
        private readonly DBPortaldeEmpleoContext _context;

        public HabconocimcandController(DBPortaldeEmpleoContext context)
        {
            _context = context;
        }

        // GET: api/Habconocimcand
        [HttpGet]
        [Route("GetHabconocimcand")]
        public async Task<ActionResult<IEnumerable<Habconocimcand>>> GetHabconocimcand()
        {
            return await _context.Habconocimcand.ToListAsync();
        }

        // GET: api/Habconocimcand/5
        [HttpGet]
        [Route("GetHabconocimcandById/{id}")]
        public async Task<ActionResult<Habconocimcand>> GetHabconocimcandById(int id)
        {
            var habconocimcand = await _context.Habconocimcand.FindAsync(id);

            if (habconocimcand == null)
            {
                return NotFound();
            }

            return habconocimcand;
        }

        // PUT: api/Habconocimcand/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut]
        [Route("PutHabconocimcand/{id}")]
        public async Task<IActionResult> PutHabconocimcand(int id, Habconocimcand habconocimcand)
        {
            if (id != habconocimcand.Id)
            {
                return BadRequest();
            }

            _context.Entry(habconocimcand).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HabconocimcandExists(id))
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

        // POST: api/Habconocimcand
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        [Route("PostHabconocimcand")]
        public async Task<ActionResult<Habconocimcand>> PostHabconocimcand(Habconocimcand habconocimcand)
        {
            _context.Habconocimcand.Add(habconocimcand);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetHabconocimcand", new { id = habconocimcand.Id }, habconocimcand);
        }

        // DELETE: api/Habconocimcand/5
        [HttpDelete]
        [Route("DeleteHabconocimcand/{id}")]
        public async Task<IActionResult> DeleteHabconocimcand(int id)
        {
            var habconocimcand = await _context.Habconocimcand.FindAsync(id);
            if (habconocimcand == null)
            {
                return NotFound();
            }

            _context.Habconocimcand.Remove(habconocimcand);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HabconocimcandExists(int id)
        {
            return _context.Habconocimcand.Any(e => e.Id == id);
        }
    }
}
