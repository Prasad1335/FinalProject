using FinalProject.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalProject.MasterDataModels
{

    [Table(nameof(HotelBooking), Schema = "Transaction")]
    public class HotelBooking
    {

        [Key]
        public int HotelBookingId { get; set; }
        [Unicode(false)]
        public int HotelRefId { get; set; }
        [ForeignKey(nameof(HotelRefId))]
        public Hotel Hotel { get; set; }
        public int ConfirmationCode { get; set; }
        public DateTime HotelBookingFromDate { get; set; }
        public DateTime HotelBookingToDate { get; set; }
        public List<HotelCustomerDetail> HotelCustomerDetails { get; set; }



    }
}
