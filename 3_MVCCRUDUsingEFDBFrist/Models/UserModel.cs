using _3_MVCCRUDUsingEFDBFrist.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _3_MVCCRUDUsingEFDBFrist.Models
{

    [MetadataType(typeof(UserMetadata))]  // data about data = metadata 
    public partial class User
    {
        [DisplayName("Confirm Email")]
        [System.ComponentModel.DataAnnotations.Compare("Email", ErrorMessage = "Email And ConfirmEmail Shoud be Same")]
        public string ConfirmEmail { get; set; }
    }

    public class UserMetadata
    {
        [Required(ErrorMessage = "Please Enter Name")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Name Should be 3 to 20 Characters long")]
        public string Name { get; set; }


        [Required(ErrorMessage = "Please Enter Age")]
        [Range(1, 150, ErrorMessage = "Age Should be Between 1 and 150")]
        public Nullable<int> Age { get; set; }


        [Required(ErrorMessage = "Please Enter Mobile Number")]
        [RegularExpression("\\d{10}", ErrorMessage = "10 digit Mobile Number allow")]
        public string Mobile { get; set; }


        [Remote("IsEmailExit", "Account", ErrorMessage = "Email Already Used")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Invalid Email")]
        [Required(ErrorMessage = "Please Enter Email")]
        public string Email { get; set; }



        [Required(ErrorMessage = "Please Enter Date of Birth")]
        [DisplayName("Date Of Birth")]
        [DataType(DataType.Date, ErrorMessage = "Please Enter Valid date")]
        [DateRange(ErrorMessage = "Date of Birth Should be less than today's date")] // iske liye common filder me method override karke logic likha hai aaj ki date ke aage ki date nahi honi chaiye
        public Nullable<System.DateTime> DateOfBirth { get; set; }

    }
}