using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations.Schema;

namespace PatientEntryFE.Models
{
    public class ListUI
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


