using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SSDInternalProject.ViewModels
{
    public class RoleVM
    {
        // Primary Key
        [Required(ErrorMessage = "Must have an id")]
        public int RoleVMId { get; set; }

        [Required(ErrorMessage = "Must include a role")]
        [MaxLength(20, ErrorMessage = "Maximum length of 20 characters")]
        public string Role { get; set; }

        // Relationship lists
        public List<UserRoleVM> UserRoleVMs { get; set; }
        public List<UserTicketVM> UserTicketVMs { get; set; }
    }
}