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
    public class LoanConfiguration : IEntityTypeConfiguration<Loan>
    {
       
        public void Configure(EntityTypeBuilder<Loan> builder)
        {
            builder.HasData(new Loan
            {
                Id = Guid.NewGuid(),
                Amount = 10000000,
                RequesterId = new Guid("47632E5A-6D34-4AD2-869B-CF95C636C3ED"),
                Comment = "Please I need a loan for my house rent",
                CreatedAt = DateTime.Now
            }) ;
        }
    }
}
