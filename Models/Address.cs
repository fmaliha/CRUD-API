using System.ComponentModel.DataAnnotations.Schema;

namespace PatientEntryFE.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string Customer_Address { get; set; }

        public int CustomerId { get; set; }
        [ForeignKey("CustomerId")]
        public ListUI Customer { get; set; }
    }
}
