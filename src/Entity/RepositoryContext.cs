using Entity.Configuration;
using Entity.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BorrowerConfiguration());
            modelBuilder.ApplyConfiguration(new LoanOfficerConfiguration());
            modelBuilder.ApplyConfiguration(new LoanConfiguration());
        }

        public DbSet<Borrower> Borrowers { get; set; }
        public DbSet<LoanOfficer> LoanOfficers { get; set; }
        public DbSet<Loan> Loans { get; set; }
        
    }
}
//LoanConfiguration