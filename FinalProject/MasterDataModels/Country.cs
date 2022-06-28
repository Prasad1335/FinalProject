using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalProject.MasterDataModels
{
    [Table("Country",Schema="Master")]

    [Index(nameof(CountryCode), IsUnique = true)]
    public class Country
    {
        [Key]
        public int CountryId { get; set; }

        [Unicode(false)]
        public string CountryCode { get; set; }
        [Unicode(false)]
        public string CountryName { get; set; }
        [Unicode(false)]
        public string CountryShortName { get; set; }
    }
}
