using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SSDInternalProject.ViewModels
{
    public class UserTicketVM
    {
        // Primary Key
        [Required(ErrorMessage = "Must have an id")]
        public int UserTicketVMId { get; set; }

        // Foreign Keys
        [Required(ErrorMessage = "Must have a user id")]
        public int UserVMId { get; set; }

        [Required(ErrorMessage = "Must have a ticket id")]
        public int TicketVMId { get; set; }

        public int RoleVMId { get; set; }
    }
}