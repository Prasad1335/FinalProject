using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalProject.MasterDataModels
{
    [Table("City",Schema="Master")]
    public class City
    {
        [Key]
        public int CityId { get; set; }
        [Unicode(false)]
        public string CityName { get; set; }
        public int CountryRefId { get; set; }
        [ForeignKey(nameof(CountryRefId))]
        public Country CountryModel { get; set; }
    }
}
