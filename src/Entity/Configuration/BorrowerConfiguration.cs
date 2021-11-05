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
                Id = new Guid("47632E5A-6D34-4AD2-869B-CF95C636C3ED"),
                FullName = "OluwaDare John",
                LoanAmount = 1000000,
                Gender = Enumerators.Gender.Female,
                DateOfBirth = DateTime.Now.Subtract(TimeSpan.FromDays(30 * 365)),
                MonthlyIncome = 200000,
                BVN = "7689432176",
                LoanOfficerId = new Guid("9A07B75E-E943-48BC-821C-76685161668D"),
                IsDeleted = false
            });
        }
    }
}
