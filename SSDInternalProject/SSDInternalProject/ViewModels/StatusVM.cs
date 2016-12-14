using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SSDInternalProject.ViewModels
{
    public class StatusVM
    {
        // Primary Key
        [Required(ErrorMessage = "Primary Key Required"]
        public int StatusVMId { get; set; }

        [Required(ErrorMessage = "Need to include a status")]
        [MaxLength(20, ErrorMessage = "Maximum 20 characters")]
        public string Status { get; set; }

        // Relationship lists
        public List<TicketVM> TicketVMs { get; set; }
    }
}