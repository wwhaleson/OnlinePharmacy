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
    public class OnlineConsultationsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public OnlineConsultationsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/OnlineConsultations
        [HttpGet]
        public async Task<ActionResult<IEnumerable<OnlineConsultation>>> GetOnlineConsultation()
        {
          if (_context.OnlineConsultation == null)
          {
              return NotFound();
          }
            return await _context.OnlineConsultation.ToListAsync();
        }

        // GET: api/OnlineConsultations/5
        [HttpGet("{id}")]
        public async Task<ActionResult<OnlineConsultation>> GetOnlineConsultation(int id)
        {
          if (_context.OnlineConsultation == null)
          {
              return NotFound();
          }
            var onlineConsultation = await _context.OnlineConsultation.FindAsync(id);

            if (onlineConsultation == null)
            {
                return NotFound();
            }

            return onlineConsultation;
        }

        // PUT: api/OnlineConsultations/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOnlineConsultation(int id, OnlineConsultation onlineConsultation)
        {
            if (id != onlineConsultation.OnlineConsultationID)
            {
                return BadRequest();
            }

            _context.Entry(onlineConsultation).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OnlineConsultationExists(id))
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

        // POST: api/OnlineConsultations
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<OnlineConsultation>> PostOnlineConsultation(OnlineConsultation onlineConsultation)
        {
          if (_context.OnlineConsultation == null)
          {
              return Problem("Entity set 'ApplicationDbContext.OnlineConsultation'  is null.");
          }
            _context.OnlineConsultation.Add(onlineConsultation);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetOnlineConsultation", new { id = onlineConsultation.OnlineConsultationID }, onlineConsultation);
        }

        // DELETE: api/OnlineConsultations/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOnlineConsultation(int id)
        {
            if (_context.OnlineConsultation == null)
            {
                return NotFound();
            }
            var onlineConsultation = await _context.OnlineConsultation.FindAsync(id);
            if (onlineConsultation == null)
            {
                return NotFound();
            }

            _context.OnlineConsultation.Remove(onlineConsultation);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool OnlineConsultationExists(int id)
        {
            return (_context.OnlineConsultation?.Any(e => e.OnlineConsultationID == id)).GetValueOrDefault();
        }
    }
}
