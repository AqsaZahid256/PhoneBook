using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SE_Lab.Models
{
	public class PersonViewModel
	{
		[Display(Name = "PersonId")]
		public int PersonId { get; set; }

		[Required]
		[Display(Name = " FirstName")]
		public string FirstName { get; set; }

		[Display(Name = " MiddleName")]
		public string MiddleName { get; set; }

		[Required]
		[Display(Name = " LastName")]
		public string LastName { get; set; }

		[Display(Name = " DateOfBirth")]
		[DataType(DataType.Date)]
		public Nullable<System.DateTime> DateOfBirth { get; set; }

		[Display(Name = "Added On ")]
		public System.DateTime AddedOn { get; set; }

		[Display(Name = " Added By")]
		public string AddedBy { get; set; }

		[Display(Name = " HomeAddress")]
		public string HomeAddress { get; set; }

		[Display(Name = " HomeCity")]
		public string HomeCity { get; set; }

		[Display(Name = " FaceBookAccountId")]
		public string FaceBookAccountId { get; set; }

		[Display(Name = " LinkedInId")]
		public string LinkedInId { get; set; }

		[Display(Name = " Update On")]
		public Nullable<System.DateTime> UpdateOn { get; set; }

		[Display(Name = " ImagePath")]
		public string ImagePath { get; set; }

		[Display(Name = " TwitterId")]
		public string TwitterId { get; set; }

		[Required]
		[Display(Name = " EmailId")]
		public string EmailId { get; set; }
	}
}