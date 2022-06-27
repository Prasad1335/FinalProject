using FinalProject.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalProject.MasterDataModels
{
    [Table(nameof(FlightSchedule), Schema = "Transaction")]
    public class FlightSchedule
    {
        [Key]
        public int FlightScheduleId { get; set; }
        public int FlightRefId { get; set; }
        [ForeignKey(nameof(FlightRefId))]
        public Flight Flight { get; set; }

        public DateTime DepartureDateTime { get; set; }

        public DateTime ArrivalDateTime { get; set; }

       
    }
}
