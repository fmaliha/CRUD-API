using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PatientInfoAPI.Model;

namespace PatientInfoAPI.Data
{
    public class PatientInfoAPIContext : DbContext
    {
        public PatientInfoAPIContext (DbContextOptions<PatientInfoAPIContext> options)
            : base(options)
        {
        }

        public DbSet<PatientInfoAPI.Model.Country> Country { get; set; } = default!;

        public DbSet<PatientInfoAPI.Model.Customer> Customer { get; set; }

        public DbSet<PatientInfoAPI.Model.CustomerAddress> CustomerAddress { get; set; }

        
    }
}
