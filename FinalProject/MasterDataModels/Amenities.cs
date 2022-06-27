using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalProject.MasterDataModels
{
    [Table("Amenities", Schema = "Master")]
    public class Amenities
    {
        [Key]
        public int AmenitiesId { get; set; }
        [Unicode(false)]
        public string AmenitiesName { get; set; }
        [Unicode(false)]
        public string AmenitiesDescription { get; set; }

    }
}
