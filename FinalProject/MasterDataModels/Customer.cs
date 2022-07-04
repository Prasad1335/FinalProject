using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalProject.MasterDataModels
{
    [Table("Customer", Schema = "Master")]
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        [Unicode(false)]
        public string CustomerFirstName { get; set; }
        [Unicode(false)]
        public string CustomerLastName { get; set; }
        [Unicode(false)]
        public DateTime CustomerDateOfBirth { get; set; }
        [Unicode(false)]
        public string CustomerAddress1 { get; set; }
        [Unicode(false)]
        public string CustomerAddress2 { get; set; }
        public int CityRefId { get; set; }
        [ForeignKey(nameof(CityRefId))]

        public City City { get; set; }
        [Unicode(false)]
        [StringLength(6)]
        public string CustomerPinCode { get; set; }
        public long CustomerTelephone { get; set; }
        [Unicode(false)]
        public string CustomerEmail { get; set; }


    }
}
