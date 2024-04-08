using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CarAPI.Data;
using CarAPI.Models;

namespace CarAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StyleController : ControllerBase
    {
        private readonly CarDBContext _context;

        public StyleController(CarDBContext context)
        {
            _context = context;
        }

        // GET: api/Style
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Style>>> GetStyles()
        {
            return await _context.Styles.ToListAsync();
        }

        // GET: api/Style/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Style>> GetStyle(int id)
        {
            var style = await _context.Styles.FindAsync(id);

            if (style == null)
            {
                return NotFound();
            }

            return style;
        }

        // PUT: api/Style/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStyle(int id, Style style)
        {
            if (id != style.StyleId)
            {
                return BadRequest();
            }

            _context.Entry(style).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StyleExists(id))
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

        // POST: api/Style
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Style>> PostStyle(Style style)
        {
            _context.Styles.Add(style);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetStyle", new { id = style.StyleId }, style);
        }

        // DELETE: api/Style/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStyle(int id)
        {
            var style = await _context.Styles.FindAsync(id);
            if (style == null)
            {
                return NotFound();
            }

            _context.Styles.Remove(style);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool StyleExists(int id)
        {
            return _context.Styles.Any(e => e.StyleId == id);
        }
    }
}
