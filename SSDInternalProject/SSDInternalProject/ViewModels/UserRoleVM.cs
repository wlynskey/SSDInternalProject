using System;
using System.ComponentModel.DataAnnotations;

namespace SSDInternalProject.ViewModels {
    // This is bridge talbe for UserVM and RoleVM
    public class UserRoleVM {
        // Primary key
        public int UserRoleVMId { get; set; }

        // Foreign key
        [Display(Name = "User ID")]
        [Required(ErrorMessage = "User ID required.")]
        public int UserVMId { get; set; }

        [Display(Name = "Role")]
        [Required(ErrorMessage = "Role required.")]
        public int RoleVMId { get; set; }

        [Display(Name = "DateAssigned")]
        [Required(ErrorMessage = "DateAssigned required.")]
        public DateTime DateAssigned { get; set; }

    }
}