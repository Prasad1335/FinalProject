
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalProject.MasterDataModels
{
    [Table("Airport", Schema = "Master")]
    [Index(nameof(AirportCode), IsUnique = true)]
    public class Airport
    {
        [Key]
        public int AirportId { get; set; }
        public string AirportCode { get; set; }
        [Unicode(false)]
        public string AirportName { get; set; }
        [Unicode(false)]
        public string AirportAddress { get; set; }
        public int CityRefId { get; set; }
        [ForeignKey(nameof(CityRefId))]

        public City City { get; set; }
        [Unicode(false)]
        public string AirportPinCode { get; set; }
        public long AirportTelephone1 { get; set; }
        public long AirportTelephone2 { get; set; }
        [Unicode(false)]
        public string AirportEmail1 { get; set; }
        [Unicode(false)]
        public string AirportEmail2 { get; set; }


    }
}
