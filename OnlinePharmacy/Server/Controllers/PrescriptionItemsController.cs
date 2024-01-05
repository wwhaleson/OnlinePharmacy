using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlinePharmacy.Server.Data;
using OnlinePharmacy.Shared.Domain;

namespace OnlinePharmacy.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrescriptionItemsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public PrescriptionItemsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/PrescriptionItems
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PrescriptionItem>>> GetPrescriptionItem()
        {
          if (_context.PrescriptionItem == null)
          {
              return NotFound();
          }
            return await _context.PrescriptionItem.ToListAsync();
        }

        // GET: api/PrescriptionItems/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PrescriptionItem>> GetPrescriptionItem(int id)
        {
          if (_context.PrescriptionItem == null)
          {
              return NotFound();
          }
            var prescriptionItem = await _context.PrescriptionItem.FindAsync(id);

            if (prescriptionItem == null)
            {
                return NotFound();
            }

            return prescriptionItem;
        }

        // PUT: api/PrescriptionItems/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPrescriptionItem(int id, PrescriptionItem prescriptionItem)
        {
            if (id != prescriptionItem.PrescriptionItemID)
            {
                return BadRequest();
            }

            _context.Entry(prescriptionItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PrescriptionItemExists(id))
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

        // POST: api/PrescriptionItems
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PrescriptionItem>> PostPrescriptionItem(PrescriptionItem prescriptionItem)
        {
          if (_context.PrescriptionItem == null)
          {
              return Problem("Entity set 'ApplicationDbContext.PrescriptionItem'  is null.");
          }
            _context.PrescriptionItem.Add(prescriptionItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPrescriptionItem", new { id = prescriptionItem.PrescriptionItemID }, prescriptionItem);
        }

        // DELETE: api/PrescriptionItems/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePrescriptionItem(int id)
        {
            if (_context.PrescriptionItem == null)
            {
                return NotFound();
            }
            var prescriptionItem = await _context.PrescriptionItem.FindAsync(id);
            if (prescriptionItem == null)
            {
                return NotFound();
            }

            _context.PrescriptionItem.Remove(prescriptionItem);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PrescriptionItemExists(int id)
        {
            return (_context.PrescriptionItem?.Any(e => e.PrescriptionItemID == id)).GetValueOrDefault();
        }
    }
}
