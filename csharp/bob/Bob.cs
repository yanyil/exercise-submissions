using System;

namespace bob
{
	public class Bob
	{
		public static string Hey (string message)
		{
			if (IsEmpty (message)) {
				return "Fine. Be that way!";
			}
			if (IsYelling (message)) {
				return "Whoa, chill out!";
			}
			if (IsQuestion (message)) {
				return "Sure.";
			}
			return "Whatever.";
		}

		private static bool IsEmpty (string message)
		{
			return string.IsNullOrWhiteSpace(message.Trim());
		}

		private static bool IsYelling (string message)
		{
			return message.ToUpper () == message && message.ToLower () != message;
		}

		private static bool IsQuestion (string message)
		{
			return message.Trim().EndsWith("?");
		}
	}
}
