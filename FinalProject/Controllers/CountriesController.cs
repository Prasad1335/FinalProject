using FinalProject.Dtos;
using FinalProject.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountriesController : ControllerBase
    {
        private readonly ICountryService _CountryService;
        private readonly ILogger<CountriesController> _logger;

        public CountriesController(
          ICountryService CountryService,
          ILogger<CountriesController> logger)
        {
            _CountryService = CountryService;
            _logger = logger;
        }

        // GET: api/<CountriesController>
        [HttpGet]
        public async Task<IEnumerable<CountryDto>> GetAsync()
        {

            var Countrys = await _CountryService.GetAllAsync();
            return (Countrys);

        }

        // GET api/<CountriesController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CountryDto>> GetAsync(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Country = await _CountryService.GetByIdAsync((int)id);

            if (Country == null)
            {
                return NotFound();
            }

            return Ok(Country);
        }

        // POST api/<CountriesController>
        [HttpPost]
        public async Task PostAsync([FromBody] CountryDto countryDto)
        {
            await _CountryService.CreateAsync(countryDto);
        }

        // PUT api/<CountriesController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> PutAsync(int id, [FromBody] CountryDto countryDto)
        {
            if (id != countryDto.CountryId)
            {
                return NotFound();
            }

            await _CountryService.UpdateAsync(countryDto);

            return Ok(countryDto);
        }

        // DELETE api/<CountriesController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteAsync(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Country = await _CountryService.GetByIdAsync((int)id);

            if (Country == null)
            {
                return NotFound();
            }
            await _CountryService.DeleteAsync((int)id);

            return Ok(Country);
        }
    }
}
