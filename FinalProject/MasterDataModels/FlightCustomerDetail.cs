using FinalProject.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalProject.MasterDataModels
{
    [Table(nameof(FlightCustomerDetail), Schema = "Transaction")]
    public class FlightCustomerDetail
    {
        [Key]
        public int FlightCustomerDetailId { get; set; }
        public int FlightBookingRefId { get; set; }
        [ForeignKey(nameof(FlightBookingRefId))]
        public FlightBooking FlightBooking { get; set; }
        public int CustomerRefId { get; set; }
        [ForeignKey(nameof(CustomerRefId))]
        public Customer Customer { get; set; }
    }
}
