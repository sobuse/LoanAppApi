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
    public class LoanOfficerConfiguration : IEntityTypeConfiguration<LoanOfficer>
    {
        public void Configure(EntityTypeBuilder<LoanOfficer> builder)
        {  
            builder.HasData(
                new LoanOfficer
                {
                    Id = Guid.NewGuid(),
                    Fullname = "Obuse Samuel",
                    RequestLoan = Enumerators.RequestLoan.Pending
                }
                );
        }
    }
}
