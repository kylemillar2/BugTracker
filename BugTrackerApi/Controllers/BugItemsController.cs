using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BugTrackerApi.Models;

namespace BugTrackerApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BugItemsController : ControllerBase
    {
        private readonly BugItemContext _context;

        public BugItemsController(BugItemContext context)
        {
            _context = context;
        }

        // GET: api/BugItems
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BugItem>>> GetBugItems()
        {
          if (_context.BugItems == null)
          {
              return NotFound();
          }
            return await _context.BugItems.ToListAsync();
        }

        // GET: api/BugItems/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BugItem>> GetBugItem(long id)
        {
          if (_context.BugItems == null)
          {
              return NotFound();
          }
            var bugItem = await _context.BugItems.FindAsync(id);

            if (bugItem == null)
            {
                return NotFound();
            }

            return bugItem;
        }

        // PUT: api/BugItems/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBugItem(long id, BugItem bugItem)
        {
            if (id != bugItem.Id)
            {
                return BadRequest();
            }

            _context.Entry(bugItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BugItemExists(id))
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

        // POST: api/BugItems
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<BugItem>> PostBugItem(BugItem bugItem)
        {
          if (_context.BugItems == null)
          {
              return Problem("Entity set 'BugItemContext.BugItems'  is null.");
          }
            _context.BugItems.Add(bugItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBugItem", new { id = bugItem.Id }, bugItem);
        }

        // DELETE: api/BugItems/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBugItem(long id)
        {
            if (_context.BugItems == null)
            {
                return NotFound();
            }
            var bugItem = await _context.BugItems.FindAsync(id);
            if (bugItem == null)
            {
                return NotFound();
            }

            _context.BugItems.Remove(bugItem);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BugItemExists(long id)
        {
            return (_context.BugItems?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
