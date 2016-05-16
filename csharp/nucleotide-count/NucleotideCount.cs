using System;
using System.Collections.Generic;
using System.Linq;

namespace dna
{
	public class DNA
	{
		public IDictionary<char, int> NucleotideCounts { get; }

		public DNA(string strand)
		{
			NucleotideCounts = new Dictionary<char, int>{ { 'A', 0 }, { 'T', 0 }, { 'C', 0 }, { 'G', 0 } };
			foreach (char c in strand)
			{
				NucleotideCounts [c]++;
			}
		}

		public int Count (char nucleotide)
		{
			int count;
			if (!NucleotideCounts.TryGetValue(nucleotide, out count))
			{
				throw new InvalidNucleotideException ();
			}
			return count;
		}
	}
}

public class InvalidNucleotideException : Exception {};