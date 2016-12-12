using System.ComponentModel.DataAnnotations;

namespace SSDInternalProject.ViewModels {
    public class EvaluationVM {
        [Display(Name = "Evaluation ID")]
        [Required(ErrorMessage = "Evaluation ID required.")]
        public string ID { get; set; }

        [Display(Name = "Category")]
        [Required(ErrorMessage = "Category required.")]
        public string Category { get; set; }

        [Display(Name = "Description")]
        [Required(ErrorMessage = "Description required.")]
        public string Description { get; set; }
    }
}