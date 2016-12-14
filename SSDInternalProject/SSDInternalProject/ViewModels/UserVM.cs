using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SSDInternalProject.ViewModels {
    public class UserVM {
        // Primary key
        [Display(Name = "User ID")]
        [Required(ErrorMessage = "User ID required.")]
        public int UserVMId { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Email Address required.")]
        [MaxLength(50)]
        public string Email { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "Password  required.")]
        [MaxLength(50)]
        public string Password { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "FirstName required.")]
        [MaxLength(25)]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "LastName required.")]
        [MaxLength(25)]
        public string LastName { get; set; }

        [Display(Name = "MiddelInitial")]
        [MaxLength(3)]
        public string MiddelInitial { get; set; }

        [Display(Name = "Phone Number")]
        [Required(ErrorMessage = "Phone Number required.")]
        [MaxLength(25)]
        public string PhoneNumber { get; set; }

        [Display(Name = "Street Address")]
        [Required(ErrorMessage = "Street Address required.")]
        [MaxLength(50)]
        public string StreetAddress { get; set; }

        [Display(Name = "City")]
        [Required(ErrorMessage = "City required.")]
        [MaxLength(25)]
        public string City { get; set; }

        [Display(Name = "Province")]
        [Required(ErrorMessage = "Province required.")]
        [MaxLength(25)]
        public string Province { get; set; }

        [Display(Name = "Postal Code")]
        [Required(ErrorMessage = "Postal Code required.")]
        [MaxLength(10)]
        public string PostalCode { get; set; }

        [Display(Name = "Country")]
        [Required(ErrorMessage = "Country required.")]
        [MaxLength(25)]
        public string Country { get; set; }

        // Reference
        public List<UserRoleVM> UserRoleVMs { get; set; }
    }
}