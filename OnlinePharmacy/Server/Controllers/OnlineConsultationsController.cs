using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlinePharmacy.Server.Data;
using OnlinePharmacy.Server.IRepository;
using OnlinePharmacy.Shared.Domain;

namespace OnlinePharmacy.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OnlineConsultationsController : ControllerBase
    {
        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;

        public OnlineConsultationsController(IUnitOfWork unitOfWork)
        {
            //_context = context;
            _unitOfWork = unitOfWork;
        }

        // GET: api/OnlineConsultations
        [HttpGet]
        public async Task<IActionResult> GetOnlineConsultations()
        {
            var onlineconsultations = await _unitOfWork.OnlineConsultations.GetAll(
            includes: q => q.Include(x =>x.Customer).Include(x => x.Staff));
            return Ok(onlineconsultations);
        }

        // GET: api/OnlineConsultations/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetOnlineConsultation(int id)
        {
            var onlineconsultation = await _unitOfWork.OnlineConsultations.Get(q => q.OnlineConsultationID == id);
            if (onlineconsultation == null)
            {
                return NotFound();
            }
            return Ok(onlineconsultation);
        }

        // PUT: api/OnlineConsultations/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOnlineConsultation(int id, OnlineConsultation onlineconsultation)
        {
            if (id != onlineconsultation.OnlineConsultationID)
            {
                return BadRequest();
            }

            _unitOfWork.OnlineConsultations.Update(onlineconsultation);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await OnlineConsultationExists(id))
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
        public async Task<ActionResult<OnlineConsultation>> PostOnlineConsultation(OnlineConsultation onlineconsultation)
        {
            await _unitOfWork.OnlineConsultations.Insert(onlineconsultation);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetOnlineConsultation", new { id = onlineconsultation.OnlineConsultationID }, onlineconsultation);
        }

        // DELETE: api/OnlineConsultations/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOnlineConsultation(int id)
        {
            var onlineconsultation = await _unitOfWork.OnlineConsultations.Get(q => q.OnlineConsultationID == id);
            if (onlineconsultation == null)
            {
                return NotFound();
            }

            await _unitOfWork.OnlineConsultations.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();

        }

        private async Task<bool> OnlineConsultationExists(int id)
        {
            var onlineconsultation = await _unitOfWork.OnlineConsultations.Get(q => q.OnlineConsultationID == id);
            return onlineconsultation != null;
        }
    }
}
