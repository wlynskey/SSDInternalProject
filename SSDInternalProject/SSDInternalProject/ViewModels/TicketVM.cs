using System.ComponentModel.DataAnnotations;
using SSDInternalProject.ViewModels;
using System;

namespace SSDInternalProject.ViewModels {
    public class TicketVM {
        // Primary Key
        [Display(Name = "Ticket ID")]
        [Required(ErrorMessage = "Ticket ID required.")]
        public int TicketVMId { get; set; }

        // Local Variables           
        [Display(Name = "Creation Date")]
        [Required(ErrorMessage = "Ticket Status required.")]
        public DateTime CreationDate { get; set; }

        [Display(Name = "Repair Start Date")]
        public DateTime RepairStartDate { get; set; }

        [Display(Name = "Repair Finish Date")]
        public DateTime RepairFinishDate { get; set; }

        [Display(Name = "FinishDate")]
        public DateTime FinishDate { get; set; }

        [Display(Name = "Notes")]
        [MaxLength(1000, ErrorMessage = "No more than 1000 charaters")]
        public string Notes { get; set; }

        public string imagePath1 { get; set; }
        public string imagePath2 { get; set; }
        public string imagePath3 { get; set; }
        public string imagePath4 { get; set; }
        public string imagePath5 { get; set; }

        [Display(Name = "Hours")]
        public float Hours { get; set; }

        [Display(Name = "Quoted Cost")]
        public decimal QuotedCost { get; set; }

        [Display(Name = "Final Cost")]
        public decimal FinalCost { get; set; }

        // Foreign Keys
        [Display(Name = "Ticket Status")]
        [Required(ErrorMessage = "Ticket Status required.")]
        [MaxLength(20, ErrorMessage = "No more than 20 charaters")]
        public int StatusVMId { get; set; }

        [Display(Name = "Repair")]
        public int RepairVMId { get; set; }

        [Display(Name = "Device")]
        public int DeviceVMId { get; set; }

    }
}