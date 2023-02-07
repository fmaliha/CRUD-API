using System.ComponentModel.DataAnnotations.Schema;

namespace PatientInfoAPI.Model
{
    public class CustomerAddress
    {
        public int Id { get; set; }
        public string Customer_Address { get; set; }

        public int CustomerId { get; set; }
        [ForeignKey("CustomerId")]
        public Customer Customer { get; set; }
    }
}
