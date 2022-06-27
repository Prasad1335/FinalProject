using FinalProject.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalProject.MasterDataModels
{
    [Table("Hotel", Schema = "Master")]
    public class Hotel
    {
        [Key]
        public int HotelId { get; set; }
        [Unicode(false)]
        public string HotelName { get; set; }
        public int HotelStar { get; set; }
        public int CityRefId { get; set; }

        [ForeignKey(nameof(CityRefId))]
        public City CityModel { get; set; }
    }
}
