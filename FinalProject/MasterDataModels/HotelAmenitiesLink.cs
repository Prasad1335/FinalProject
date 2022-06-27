using FinalProject.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalProject.MasterDataModels
{
    [Table("HotelAmenitiesLink", Schema = "Master")]
    public class HotelAmenitiesLink
    {
        [Key]

        public int HotelAmenitiesLinkId { get; set; }
        public int HotelRefId { get; set; }
        [ForeignKey(nameof(HotelRefId))]
        public Hotel HotelModel { get; set; }

        public int CityRefId { get; set; }
        [ForeignKey(nameof(CityRefId))]
        public City CityModel { get; set; }

    }
}
