
namespace FinalProject.Dtos
{
    public class HotelBookingDto
    {
        public int HotelBookingId { get; set; }
        public int HotelRefId { get; set; } 
        public int ConfirmationCode { get; set; }
        public DateTime HotelBookingFromDate { get; set; }
        public DateTime HotelBookingToDate { get; set; }
        public List<HotelCustomerDetailDto> HotelCustomerDetails { get; set; }
    }
}
