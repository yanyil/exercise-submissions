using System;
using System.Collections.Generic;
using System.Linq;

namespace anagram
{
	public class Anagram
	{
		private string _word;

		public Anagram (string word)
		{
			_word = word.ToLower ();
		}

		public string[] Match (string[] words)
		{
			var matches = new List<string> ();
			foreach (var word in words) {
				if (IsAnagram (word)) {
					matches.Add (word);
				}
			}
			return matches.ToArray ();
		}

		private bool IsAnagram (string candidate)
		{
			return _word != candidate.ToLower () && SortWord (_word) == SortWord (candidate.ToLower ());
		}

		private static string SortWord (string word)
		{
			return String.Concat (word.OrderBy (c => c));
		}
	}
}