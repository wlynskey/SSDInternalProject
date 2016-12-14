using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SSDInternalProject.ViewModels
{
    public class DeviceVM
    {
        // Primary Key
        [Required(ErrorMessage = "Make is Required")]        
        public int DeviceVMId { get; set; }

        [Required(ErrorMessage = "Make is Required")]
        [MaxLength(50, ErrorMessage = "Max length of 50 characters")]
        public string Make { get; set; }

        [Required(ErrorMessage = "Model is Required")]
        [MaxLength(50, ErrorMessage = "Max length of 50 characters")]
        public string Model { get; set; }

        public int Year { get; set; }

        // Relationship lists
        public List<TicketVM> TicketVMs { get; set; }
    }
}