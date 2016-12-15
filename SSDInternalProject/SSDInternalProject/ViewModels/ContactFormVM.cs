using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SSDInternalProject.ViewModels
{
    public class ContactFormVM
    {
        [MaxLength(50, ErrorMessage = "Max length of 50 characters")]
        public string Name { get; set; }

        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$")]
        [MaxLength(50, ErrorMessage = "Max length of 50 characters")]
        public string Email { get; set; }

        [MaxLength(50, ErrorMessage = "Max length of 50 characters")]
        public string Subject { get; set; }
        
        [Required(ErrorMessage = "Message is Required")]
        [MaxLength(500, ErrorMessage = "Max length of 500 characters")]
        public string Message { get; set; }
    }
}