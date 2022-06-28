using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FinalProject.MasterDataModels;
using FinalProject.MasterDataModels.DataAccess;

namespace FinalProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlightCustomerDetailsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public FlightCustomerDetailsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/FlightCustomerDetails
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FlightCustomerDetail>>> GetFlightCustomerDetails()
        {
            return await _context.FlightCustomerDetails.ToListAsync();
        }

        // GET: api/FlightCustomerDetails/5
        [HttpGet("{id}")]
        public async Task<ActionResult<FlightCustomerDetail>> GetFlightCustomerDetail(int id)
        {
            var flightCustomerDetail = await _context.FlightCustomerDetails.FindAsync(id);

            if (flightCustomerDetail == null)
            {
                return NotFound();
            }

            return flightCustomerDetail;
        }

        // PUT: api/FlightCustomerDetails/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFlightCustomerDetail(int id, FlightCustomerDetail flightCustomerDetail)
        {
            if (id != flightCustomerDetail.FlightCustomerDetailId)
            {
                return BadRequest();
            }

            _context.Entry(flightCustomerDetail).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FlightCustomerDetailExists(id))
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

        // POST: api/FlightCustomerDetails
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<FlightCustomerDetail>> PostFlightCustomerDetail(FlightCustomerDetail flightCustomerDetail)
        {
            _context.FlightCustomerDetails.Add(flightCustomerDetail);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFlightCustomerDetail", new { id = flightCustomerDetail.FlightCustomerDetailId }, flightCustomerDetail);
        }

        // DELETE: api/FlightCustomerDetails/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFlightCustomerDetail(int id)
        {
            var flightCustomerDetail = await _context.FlightCustomerDetails.FindAsync(id);
            if (flightCustomerDetail == null)
            {
                return NotFound();
            }

            _context.FlightCustomerDetails.Remove(flightCustomerDetail);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool FlightCustomerDetailExists(int id)
        {
            return _context.FlightCustomerDetails.Any(e => e.FlightCustomerDetailId == id);
        }
    }
}
