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
    public class FlightSchedulesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public FlightSchedulesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/FlightSchedules
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FlightSchedule>>> GetFlightSchedules()
        {
            return await _context.FlightSchedules.Include("Flight").ToListAsync();
        }

        // GET: api/FlightSchedules/5
        [HttpGet("{id}")]
        public async Task<ActionResult<FlightSchedule>> GetFlightSchedule(int id)
        {
            var flightSchedule = await _context.FlightSchedules.Include("Flight").SingleOrDefaultAsync(x=>x.FlightScheduleId==id);

            if (flightSchedule == null)
            {
                return NotFound();
            }

            return flightSchedule;
        }


     

        // PUT: api/FlightSchedules/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFlightSchedule(int id, FlightSchedule flightSchedule)
        {
            if (id != flightSchedule.FlightScheduleId)
            {
                return BadRequest();
            }

            _context.Entry(flightSchedule).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FlightScheduleExists(id))
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

        // POST: api/FlightSchedules
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<FlightSchedule>> PostFlightSchedule(FlightSchedule flightSchedule)
        {
            _context.FlightSchedules.Add(flightSchedule);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFlightSchedule", new { id = flightSchedule.FlightScheduleId }, flightSchedule);
        }

        // DELETE: api/FlightSchedules/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFlightSchedule(int id)
        {
            var flightSchedule = await _context.FlightSchedules.FindAsync(id);
            if (flightSchedule == null)
            {
                return NotFound();
            }

            _context.FlightSchedules.Remove(flightSchedule);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool FlightScheduleExists(int id)
        {
            return _context.FlightSchedules.Any(e => e.FlightScheduleId == id);
        }
    }
}
