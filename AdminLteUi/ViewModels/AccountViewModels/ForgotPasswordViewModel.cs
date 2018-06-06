using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AdminLteUi.ViewModels.AccountViewModels
{

    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}
