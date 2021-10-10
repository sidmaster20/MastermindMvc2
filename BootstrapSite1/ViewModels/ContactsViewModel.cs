using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BootstrapSite1.ViewModels
{
    public class ContactsViewModel
    {
        [Required(ErrorMessage ="*")]       
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "*")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "*")]
        [Display(Name = "Company Name")]
        public string CompanyName { get; set; }

        [Required(ErrorMessage = "*")]
        [Display(Name = "Email Address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "*")]
        [Display(Name = "Phone Number")]
        public string Phone { get; set; }
        
        [Display(Name = "Message")]
        public string Message { get; set; }       

    }
}