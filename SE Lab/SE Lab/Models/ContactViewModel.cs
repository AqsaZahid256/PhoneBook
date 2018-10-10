using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SE_Lab.Models
{
	public class ContactViewModel
	{
		[Display(Name = "ContactId")]
		public int ContactId { get; set; }

		[Required]
		[Display(Name = "ContactNumber")]
		public string ContactNumber { get; set; }

		[Required]
		[Display(Name = "Type")]
		public string Type { get; set; }

		[Required]
		[Display(Name = "PersonId")]
		public int PersonId { get; set; }
    
	}
}