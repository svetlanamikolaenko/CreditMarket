using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CreditMarket.Models
{
	public class Base
	{
		[Key]
		public int Id { get; set; }
	}
}
