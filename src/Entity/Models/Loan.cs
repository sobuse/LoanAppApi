using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    public class Loan
    {
        //  The primary key of the loan requested
        public Guid Id { get; set; }

        // Amount of the loan requested
        public int Amount { get; set; }

        //FK to the loan requester (the person who created the loan application)
        public Guid RequesterId { get; set; }

        // the requester comment
        public string Comment { get; set; }

        // the exact time the loan request was summited
        public DateTime CreatedAt { get; set; }
    }
}



