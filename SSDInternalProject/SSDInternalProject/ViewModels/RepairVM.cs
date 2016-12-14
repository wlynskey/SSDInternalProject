using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SSDInternalProject.ViewModels {
    public class RepairVM {
        // Primary key
        [Display(Name = "Repair Id")]
        [Required(ErrorMessage = "Repair Id required.")]
        public int RepairVMId { get; set; }

        [Display(Name = "Name")]
        [Required(ErrorMessage = "Name required.")]
        [MaxLength(50)]
        public string Name { get; set; }

        [Display(Name = "Average Hours")]
        public float AvgHours { get; set; }

        [Display(Name = "Average Cost")]
        public decimal AvgCost { get; set; }

        [Display(Name = "Description")]
        [Required(ErrorMessage = "Description required.")]
        [MaxLength(1000)]
        public string Description { get; set; }

        // Reference
        public List<TicketVM> TicketVMs { get; set; }
    }
}
