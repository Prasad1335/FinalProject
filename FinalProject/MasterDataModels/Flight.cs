using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalProject.MasterDataModels
{
    [Table("Flight", Schema = "Master")]
    [Index(nameof(FlightCode), IsUnique = true)]
    public class Flight
    {
        [Key]
        public int FlightId { get; set; }
        public string FlightCode { get; set; }
        public int AirlineRefId { get; set; }
        [ForeignKey(nameof(AirlineRefId))]

        public Airline Airline { get; set; }
        public int FromAirportRefId { get; set; }
        [ForeignKey(nameof(FromAirportRefId))]
        public City FromAirport { get; set; }
        public int ToAirportRefId { get; set; }
        [ForeignKey(nameof(ToAirportRefId))]
        public City ToAirport { get; set; }
    }
}

