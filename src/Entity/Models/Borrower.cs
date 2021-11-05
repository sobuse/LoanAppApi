using Entity.Enumerators;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    public class Borrower
    {
        [Column("BorrowersId")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Your name is a required field.")]
        [MaxLength(60, ErrorMessage = "Maximum length for the Name is 60 characters.")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Your Loan Amount  is a required field.")]
        public int LoanAmount { get; set; }



        
        public Gender Gender { get; set; }

        [Required(ErrorMessage = "Your DOB is a required field.")]
        public DateTime DateOfBirth { get; set; }

        public DateTime BorrowedOn { get; set; }

        public DateTime DueDate { get; set; }

        [Required(ErrorMessage = "Your Monthly Income is a required field.")]
        public int MonthlyIncome { get; set; }

        [Required(ErrorMessage = "Your BVN is a required field.")]
        public string BVN { get; set; }

       

        [ForeignKey(nameof(LoanOfficer))]
        public Guid LoanOfficerId { get; set; }

        public bool IsDeleted { get; set; }
    }
}
