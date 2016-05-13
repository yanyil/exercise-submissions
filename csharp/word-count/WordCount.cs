using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace phrase
{
	public class Phrase
	{
		public static IDictionary<string, int> WordCount (string phrase)
		{
			var counts = new Dictionary<string, int> ();
			Match match = FindMatch(phrase);
			while (match.Success) {
				string word = match.Value;
				if (!counts.ContainsKey (word))
				{
					counts [word] = 0;
				}
				counts [word]++;
				match = match.NextMatch ();
			}
			return counts;
		}

		private static Match FindMatch (string phrase)
		{
			return Regex.Match (phrase.ToLower (), @"\w+'\w+|\w+");
		}
	}
}