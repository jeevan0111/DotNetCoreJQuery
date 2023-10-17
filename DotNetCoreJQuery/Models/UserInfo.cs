using System;
using System.ComponentModel.DataAnnotations;

namespace DotNetCoreJQuery.Models
{
	public class UserInfo
	{
		public int Id { get; set; }

		[Required(ErrorMessage = "Name is required")]
		[Display(Name ="User Name")]
		public string Name { get; set; } = string.Empty;

		public string Gender { get; set; } = string.Empty;
	}
}

