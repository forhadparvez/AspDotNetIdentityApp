﻿using System.ComponentModel.DataAnnotations;
using CoreLibrary.IdentityCore;

namespace AdminLteUi.ViewModels.AccountViewModels
{
    public class RegisterViewModel
    {

        [Required]
        [Display(Name = "User Name")]
        public string UserName { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }


        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        public string ApplicationRoleId { get; set; }
        public ApplicationRole ApplicationRole { get; set; }
    }
}
