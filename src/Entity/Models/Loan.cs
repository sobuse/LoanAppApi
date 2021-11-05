using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    public class Loan
    {
        
        public Guid Id { get; set; }

        public int Amount { get; set; }

        public Guid RequesterId { get; set; }
        
        public string Comment { get; set; }

        public DateTime CreatedAt { get; set; }



    }
}

//requesterId - Guid //FK to the loan requester (the person who created the loan application)
//comment - string // the requester comment
//createdAt - Date