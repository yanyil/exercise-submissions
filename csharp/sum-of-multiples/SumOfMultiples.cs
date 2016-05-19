using System;
using System.Linq;

namespace sumofmultiples
{
	public class SumOfMultiples
	{
		public static int To (int[] numbers, int max)
		{
			return Enumerable.Range (1, max - 1).
				Where (i => IsMultiple (numbers, i)).Sum ();
		}

		private static bool IsMultiple (int[] numbers, int i)
		{
			return numbers.Any(n => i % n ==0);
		}
	}
}