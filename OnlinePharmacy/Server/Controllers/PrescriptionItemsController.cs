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
    public class PrescriptionItemsController : ControllerBase
    {
        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;

        public PrescriptionItemsController(IUnitOfWork unitOfWork)
        {
            //_context = context;
            _unitOfWork = unitOfWork;
        }

        // GET: api/PrescriptionItems
        [HttpGet]
        public async Task<IActionResult> GetPrescriptionItems()
        {
            var prescriptionitems = await _unitOfWork.PrescriptionItems.GetAll();
            return Ok(prescriptionitems);
        }

        // GET: api/PrescriptionItems/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPrescriptionItem(int id)
        {
            var prescriptionitem = await _unitOfWork.PrescriptionItems.Get(q => q.PrescriptionItemID == id);
            if (prescriptionitem == null)
            {
                return NotFound();
            }
            return Ok(prescriptionitem);
        }

        // PUT: api/PrescriptionItems/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPrescriptionItem(int id, PrescriptionItem prescriptionitem)
        {
            if (id != prescriptionitem.PrescriptionItemID)
            {
                return BadRequest();
            }

            _unitOfWork.PrescriptionItems.Update(prescriptionitem);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await PrescriptionItemExists(id))
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
        public async Task<ActionResult<PrescriptionItem>> PostPrescriptionItem(PrescriptionItem prescriptionitem)
        {
            await _unitOfWork.PrescriptionItems.Insert(prescriptionitem);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetPrescriptionItem", new { id = prescriptionitem.PrescriptionItemID }, prescriptionitem);
        }

        // DELETE: api/PrescriptionItems/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePrescriptionItem(int id)
        {
            var prescriptionitem = await _unitOfWork.PrescriptionItems.Get(q => q.PrescriptionItemID == id);
            if (prescriptionitem == null)
            {
                return NotFound();
            }

            await _unitOfWork.PrescriptionItems.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();

        }

        private async Task<bool> PrescriptionItemExists(int id)
        {
            var prescriptionitem = await _unitOfWork.PrescriptionItems.Get(q => q.PrescriptionItemID == id);
            return prescriptionitem != null;
        }
    }
}
