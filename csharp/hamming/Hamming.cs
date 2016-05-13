using System;

namespace hamming
{
	public class Hamming
	{
		public static int Compute (string strandA, string strandB)
		{
			int distance = 0;
			for (int i = 0; i < strandA.Length; i++)
			{
				if (strandA[i] != strandB[i])
				{
					distance++;
				}
			}
			return distance;
		}
	}
}

