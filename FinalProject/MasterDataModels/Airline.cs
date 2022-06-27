using FinalProject.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalProject.MasterDataModels
{
    [Table("Airline", Schema = "Master")]
    public class Airline
    {
        [Key]

        public int AirlineId { get; set; }

        [Unicode(false)]
        public string AirlineName { get; set; }
        [Unicode(false)]
        public string AirlineShortName { get; set; }
        [Unicode(false)]
        public string AirlineLogo { get; set; }
        [Unicode(false)]
        public string AirlineAddress { get; set; }
        public int CityRefId { get; set; }
        [ForeignKey(nameof(CityRefId))]
        public City CityModel { get; set; }
        [Unicode(false)]
        public string AirlinePinCode { get; set; }
        public long AirlineTelephone1 { get; set; }
        public long AirlineTelephone2 { get; set; }
        [Unicode(false)]
        public string AirlineEmail1 { get; set; }
        [Unicode(false)]
        public string AirlineEmail2 { get; set; }
    }
}

