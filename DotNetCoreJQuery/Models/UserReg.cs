using System;
using System.ComponentModel.DataAnnotations;
using DotNetCoreJQuery.Helpers;

namespace DotNetCoreJQuery.Models
{
	public class UserReg
	{
        [Key]
        public int Id { get; set; }

        //[Required(ErrorMessage ="Name is required")]
        //[StringLength(20, MinimumLength =5)]
        //[Display(Name ="User Name")]

        //[MyCustomValidation]
		public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Address is required")]
        public string Address { get; set; } = string.Empty;

        [Required(ErrorMessage = "Mobile is required")]
        public string MobileNumber { get; set; } = string.Empty;

        [Required(ErrorMessage = "Email is required")]
        public string EmailAddress { get; set; } = string.Empty;

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; } = string.Empty;

        [Required(ErrorMessage = "Confirm Password is required")]
        [Compare("Password", ErrorMessage ="Password and ConfirmPassword must match")]
        public string ConfirmPassword { get; set; } = string.Empty;

	}
}

