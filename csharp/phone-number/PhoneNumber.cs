using System;
using System.Text.RegularExpressions;

namespace phonenumber
{
	public class PhoneNumber
	{
		public string Number { get; }
		public string AreaCode { get; }

		public PhoneNumber (string number)
		{
			Number = ValidatePhoneNumber (number);
			AreaCode = Number.Substring (0, 3);
		}

		public override string ToString()
		{
			return string.Format ("({0}) {1}-{2}", AreaCode, Number.Substring (3, 3), Number.Substring (6));
		}

		private string ValidatePhoneNumber (string number)
		{
			var cleaned = CleanNonDigits (number);
			if(IsUSNumber(cleaned))
			{
				cleaned = cleaned.Substring(1);
			}
			cleaned = ValidateLength (cleaned);
			return cleaned;
		}

		private string CleanNonDigits(string number)
		{
			return Regex.Replace(number, @"\D", "");
		}

		private bool IsUSNumber (string number)
		{
			return number.Length == 11 && number [0] == '1';
		}

		private string ValidateLength(string number)
		{
			return (number.Length == 10) ? number : "0000000000";
		}
	}
}