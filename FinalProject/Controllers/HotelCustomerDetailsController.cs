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
    public class HotelCustomerDetailsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public HotelCustomerDetailsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/HotelCustomerDetails
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HotelCustomerDetail>>> GetHotelCustomerDetails()
        {
            return await _context.HotelCustomerDetails.ToListAsync();
        }

        // GET: api/HotelCustomerDetails/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HotelCustomerDetail>> GetHotelCustomerDetail(int id)
        {
            var hotelCustomerDetail = await _context.HotelCustomerDetails.FindAsync(id);

            if (hotelCustomerDetail == null)
            {
                return NotFound();
            }

            return hotelCustomerDetail;
        }

        // PUT: api/HotelCustomerDetails/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHotelCustomerDetail(int id, HotelCustomerDetail hotelCustomerDetail)
        {
            if (id != hotelCustomerDetail.HotelCustomerDetailId)
            {
                return BadRequest();
            }

            _context.Entry(hotelCustomerDetail).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HotelCustomerDetailExists(id))
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

        // POST: api/HotelCustomerDetails
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<HotelCustomerDetail>> PostHotelCustomerDetail(HotelCustomerDetail hotelCustomerDetail)
        {
            _context.HotelCustomerDetails.Add(hotelCustomerDetail);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetHotelCustomerDetail", new { id = hotelCustomerDetail.HotelCustomerDetailId }, hotelCustomerDetail);
        }

        // DELETE: api/HotelCustomerDetails/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHotelCustomerDetail(int id)
        {
            var hotelCustomerDetail = await _context.HotelCustomerDetails.FindAsync(id);
            if (hotelCustomerDetail == null)
            {
                return NotFound();
            }

            _context.HotelCustomerDetails.Remove(hotelCustomerDetail);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HotelCustomerDetailExists(int id)
        {
            return _context.HotelCustomerDetails.Any(e => e.HotelCustomerDetailId == id);
        }
    }
}
