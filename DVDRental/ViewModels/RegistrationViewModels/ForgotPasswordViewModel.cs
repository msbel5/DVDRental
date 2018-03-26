using System.ComponentModel.DataAnnotations;

namespace DVDRental.ViewModels.RegistrationViewModels
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}
