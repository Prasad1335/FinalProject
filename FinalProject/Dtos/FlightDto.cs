using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalProject.Dtos
{

    public class FlightDto
    {
        public int FlightId { get; set; }
        public string FlightCode { get; set; }
        public int AirlineRefId { get; set; }
        public int FromAirportRefId { get; set; }
        public int ToAirportRefId { get; set; }

        public DateTime DepartureDateTime { get; set; }
        public DateTime ArrivalDateTime { get; set; }

    }
}

