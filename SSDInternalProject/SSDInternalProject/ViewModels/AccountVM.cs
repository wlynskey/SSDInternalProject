using System.ComponentModel.DataAnnotations;

namespace SSDInternalProject.ViewModels {
    public class AccountVM {

        [Display(Name = "ID")]
        [Required(ErrorMessage = "ID required.")]
        public int ID { get; set; }

        [Display(Name = "User Name")]
        [Required(ErrorMessage = "User Name required.")]
        public string Name { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "Password required.")]
        public string Password { get; set; }

        [Display(Name = "Phone Number")]
        [Required(ErrorMessage = "Phone Number required.")]
        public string Phone { get; set; }

        [Display(Name = "Address")]
        [Required(ErrorMessage = "Address required.")]
        public string Address { get; set; }

    }
}