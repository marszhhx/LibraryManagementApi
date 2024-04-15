using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LibraryManagementApi.Models;

namespace LibraryManagementApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibraryBranchesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public LibraryBranchesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/LibraryBranches
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LibraryBranch>>> GetLibraryBranches()
        {
            return await _context.LibraryBranches.ToListAsync();
        }

        // GET: api/LibraryBranches/5
        [HttpGet("{id}")]
        public async Task<ActionResult<LibraryBranch>> GetLibraryBranch(int id)
        {
            var libraryBranch = await _context.LibraryBranches.FindAsync(id);

            if (libraryBranch == null)
            {
                return NotFound();
            }

            return libraryBranch;
        }

        // PUT: api/LibraryBranches/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLibraryBranch(int id, LibraryBranch libraryBranch)
        {
            if (id != libraryBranch.LibraryBranchId)
            {
                return BadRequest();
            }

            _context.Entry(libraryBranch).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LibraryBranchExists(id))
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

        // POST: api/LibraryBranches
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<LibraryBranch>> PostLibraryBranch(LibraryBranch libraryBranch)
        {
            _context.LibraryBranches.Add(libraryBranch);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLibraryBranch", new { id = libraryBranch.LibraryBranchId }, libraryBranch);
        }

        // DELETE: api/LibraryBranches/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLibraryBranch(int id)
        {
            var libraryBranch = await _context.LibraryBranches.FindAsync(id);
            if (libraryBranch == null)
            {
                return NotFound();
            }

            _context.LibraryBranches.Remove(libraryBranch);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool LibraryBranchExists(int id)
        {
            return _context.LibraryBranches.Any(e => e.LibraryBranchId == id);
        }
    }
}
