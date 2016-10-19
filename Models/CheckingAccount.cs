using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HRMEng.Models
{
    public class CheckingAccount
    {
        public int id { get; set; }
        [Required]
        [RegularExpression(@"\d{6,10]",ErrorMessage ="Account Need 6-10 numbers")]
        [Display(Name = "Account #")]
        public string AccountNumber { get; set; }

        [Required]
        [Display(Name = "First name ")]

        public string Firstname { get; set; }

        [Required]
        [Display(Name = "Last name ")]
        public string LastName { get; set; }
        public string Name
        {
            get
            {
                return string.Format("{0} {1}", Firstname, LastName);
            }
        }
        [DataType(DataType.Currency)]
        public decimal Balance { get; set; }

        public virtual ApplicationUser User { get; set; }
        [Required]
        public string ApplicationUserId { get; set; }

    }
}