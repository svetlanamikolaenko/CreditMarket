using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace CreditMarket.ViewModels
{
    public class DateValidation: ValidationAttribute
	{
		public override bool IsValid(object value)
		{
			DateTime dateTime;
			var isValid = DateTime.TryParseExact(Convert.ToString(value),
				"dd-mm-yy", CultureInfo.InvariantCulture,
				DateTimeStyles.None,
				out dateTime);
			return isValid;
		}
	}
}