using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SSDInternalProject.ViewModels
{
    public class BrandVM
    {
        // Primary Key
        [Required(ErrorMessage="Must have an id")]
        public int BrandVMId { get; set; }

        [Required(ErrorMessage = "Must have a brand")]
        [MaxLength(50, ErrorMessage = "Max length of 50 characters")]
        public string Brand { get; set; }

        // Relationship group
        public List<DeviceVM> DeviceVMs { get; set; }
    }
}