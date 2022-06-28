

namespace FinalProject.Dtos
{
   
    public class CustomerDto
    {
    
        public int CustomerId { get; set; }
       
        public string CustomerFirstName { get; set; }
        
        public string CustomerLastName { get; set; }
       
        public DateTime CustomerDateOfBirth { get; set; }
      
        public string CustomerAddress1 { get; set; }
       
        public string CustomerAddress2 { get; set; }
        public int CityRefId { get; set; }
       
        public string CustomerPinCode { get; set; }
        public int CustomerTelephone { get; set; }
      
        public string CustomerEmail { get; set; }


    }
}
