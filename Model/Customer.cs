using System.ComponentModel.DataAnnotations.Schema;

namespace PatientInfoAPI.Model
{
    public class Customer
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string MaritalStatus { get; set; }
        public string CustomerPhoto { get; set; }

        public int CountryId { get; set; }
        [ForeignKey("CountryId")]
        public Country Country { get; set; }

    }
}
