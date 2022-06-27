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

        public int AmenitiesRefId { get; set; }
        [ForeignKey(nameof(AmenitiesRefId))]
        public Amenities Amenities { get; set; }

    }
}
