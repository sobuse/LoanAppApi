using Entity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Configuration
{
    public class BorrowerConfiguration : IEntityTypeConfiguration<Borrower>
    {
        public void Configure(EntityTypeBuilder<Borrower> builder)
        {
            
            builder.HasData(new Borrower
            { 
                Id = Guid.NewGuid(),
                FullName = "OluwaDare John",
                LoanAmount = 1000000,
                Gender = Enumerators.Gender.Female,
                DateOfBirth = DateTime.Now.Subtract(TimeSpan.FromDays(30 * 365)),
                MonthlyIncome = 200000,
                BVN = "7689432176",
                LoanOfficerId = Guid.NewGuid(),
                IsDeleted = false
            });
        }
    }
}
