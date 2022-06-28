

namespace FinalProject.Dtos
{
    
    public class FlightScheduleDto
    {
     
        public int FlightScheduleId { get; set; }
        public int FlightRefId { get; set; }
       

        public DateTime DepartureDateTime { get; set; }

        public DateTime ArrivalDateTime { get; set; }

       
    }
}
