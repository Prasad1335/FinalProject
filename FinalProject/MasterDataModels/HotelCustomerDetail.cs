
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalProject.MasterDataModels
{

   
    public class HotelCustomerDetail
    {
        [Key]

        public int HotelCustomerDetailId { get; set; }

        public int HotelBookingRefId { get; set; }
        [ForeignKey(nameof(HotelBookingRefId))]
        public HotelBooking HotelBooking { get; set; }
        public int CustomerRefId { get; set; }
        [ForeignKey(nameof(CustomerRefId))]
        public Customer Customer { get; set; }

    }
}
