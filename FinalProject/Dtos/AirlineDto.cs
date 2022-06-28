
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalProject.Dtos
{
 
    public class AirlineDto
    {
        public int AirlineId { get; set; }
        public string AirlineName { get; set; }
        public string AirlineShortName { get; set; }
        public string AirlineLogo { get; set; }
        public string AirlineAddress { get; set; }
        public int CityRefId { get; set; }
        public string AirlinePinCode { get; set; }
        public long AirlineTelephone1 { get; set; }
        public long AirlineTelephone2 { get; set; }
        public string AirlineEmail1 { get; set; }
        public string AirlineEmail2 { get; set; }
    }
}

