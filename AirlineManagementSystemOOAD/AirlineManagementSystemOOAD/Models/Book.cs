using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace AirlineManagementSystemOOAD.Models
{
    public class Book
    {
        [Required(ErrorMessage = "Enter First Name! ")]
        [Display(Name = "Enter First Name! ")]
        [StringLength(maximumLength: 7, MinimumLength = 3, ErrorMessage = "First Name Must be Max 7 & Min 3 Letters")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Enter Last Name! ")]
        [Display(Name = "Enter Last Name! ")]
        [StringLength(maximumLength: 7, MinimumLength = 3, ErrorMessage = "Last Name Must be Max 7 & Min 3 Letters")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Enter Dob Name! ")]
        [Display(Name = "Enter Last Name! ")]

        public string Dob { get; set; }

        [Required(ErrorMessage = "Enter Gender! ")]
        [Display(Name = "Enter Gender! ")]
        public string gender { get; set; }

        [Required(ErrorMessage = "Enter CNIC! ")]
        [Display(Name = "Enter CNIC! ")]
        public long cnic { get; set; }
        [Required(ErrorMessage = "Enter Phone Number! ")]
        [Display(Name = "Enter Phone Number! ")]
        [StringLength(maximumLength: 11, MinimumLength = 11, ErrorMessage = "Last Name Must be Max 7 & Min 3 Letters")]
        public long phone { get; set; }
        [Required(ErrorMessage = "Enter Arrival! ")]
        [Display(Name = "Enter Arrival! ")]
        public string arrival { get; set; }
        [Required(ErrorMessage = "Enter Departure! ")]
        [Display(Name = "Enter Departure! ")]
        public string dept { get; set; }
        [Required(ErrorMessage = "Enter Departure Date! ")]
        [Display(Name = "Enter Departure Date! ")]
        public string dept_date { get; set; }
        [Required(ErrorMessage = "Enter Return Date! ")]
        [Display(Name = "Enter Return Date! ")]
        public string return_date { get; set; }
        [Required(ErrorMessage = "Enter Adults! ")]
        [Display(Name = "Enter Adults! ")]
        public int adult { get; set; }
        public int child { get; set; }
        [Required(ErrorMessage = "Enter Travel Class! ")]
        [Display(Name = "Enter Travel Class! ")]
        public string travelclass { get; set; }
        public int seatsavailable { get; set; }
        public int totalamount { get; set; }
    }
}