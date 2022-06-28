
using FinalProject.MasterDataModels;

namespace FinalProject.Dtos
{

    public class FlightBookingDto
    {

        public int Id { get; set; }

        public string PassengerNameRecord { get; set; }
        public DateTime BookingTimeStamp { get; set; }
        public int CustomerRefId { get; set; }
        public int FlightScheduleRefId { get; set; }
        public long CustomerContactMobile { get; set; }
        public string CustomerContactEmail { get; set; }
        public List<FlightCustomerDetail> FlightCustomerDetails { get; set; }
    }
}

