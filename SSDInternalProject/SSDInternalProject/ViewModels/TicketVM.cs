using System.ComponentModel.DataAnnotations;

namespace SSDInternalProject.ViewModels {
    public class TicketVM {
        [Display(Name = "Ticket ID")]
        [Required(ErrorMessage = "Ticket ID required.")]
        public string ID { get; set; }

        [Display(Name = "Ticket Status")]
        [Required(ErrorMessage = "Ticket Status required.")]
        public string Status { get; set; }

        [Display(Name = "Cost")]
        [Required(ErrorMessage = "Cost required.")]
        public string Cost { get; set; }

        [Display(Name = "OrderName")]
        [Required(ErrorMessage = "OrderName required.")]
        public string OrderName { get; set; }

    }
}