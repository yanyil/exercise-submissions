using System;
using System.Collections.Generic;

namespace etl
{
	public class ETL
	{
		public static Dictionary<string, int> Transform (Dictionary<int, IList<string>> oldScores)
		{
			var newScores = new Dictionary<string, int>();
			foreach (var item in oldScores) {
				foreach (var letter in item.Value) {
					newScores.Add (letter.ToLower(), item.Key);
				}
			}
			return newScores;
		}
	}
}

