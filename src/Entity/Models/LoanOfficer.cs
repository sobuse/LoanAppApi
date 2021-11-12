﻿using Entity.Enumerators;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    public class LoanOfficer
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Your Full Name is a required field.")]
        [MaxLength(60, ErrorMessage = "Maximum length for the Name is 60 characters.")]
        public string Fullname { get; set; }

        // the request loan shows the status of the loan the borrower requested for, it could be pending | Appoved | declined
        public RequestLoan RequestLoan { get; set; }
    }
}
