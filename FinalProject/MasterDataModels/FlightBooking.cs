using FinalProject.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalProject.MasterDataModels
{
    [Table(nameof(FlightBooking), Schema = "Transaction")]
    public class FlightBooking
    {
        [Key]
        public int Id { get; set; }
        [Unicode(false)]
        public string PassengerNameRecord { get; set; }
        public int BookingTimeStamp { get; set; }
        public int CustomerRefId { get; set; }
        [ForeignKey(nameof(CustomerRefId))]
        public Customer Customer { get; set; }
        public int FlightScheduleRefId { get; set; }
        public long CustomerContactMobile { get; set; }
        [Unicode(false)]
        public string CustomerContactEmail { get; set; }
        public List<FlightCustomerDetail> FlightCustomerDetails { get; set; }

    }
}


