using System.ComponentModel.DataAnnotations;

namespace DVDRental.ViewModels.RegistrationViewModels
{
    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}