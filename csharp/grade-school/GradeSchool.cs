using System;
using System.Collections.Generic;
using System.Linq;

namespace school
{
	public class School
	{
		public IDictionary<int, IList<string>> Roster { get; private set;} 

		public School ()
		{
			Roster = new Dictionary<int, IList<string>>(); 
		}

		public void Add(string student, int grade)
		{
			if(Roster.ContainsKey (grade))
			{
				Roster [grade].Add (student);
				Roster [grade] = Roster [grade].OrderBy (x => x).ToList ();
			}
			else
			{
				Roster.Add (grade, new List<string>{ student });
			}
		}

		public IList<string> Grade(int grade)
		{
			IList<string> students;
			return Roster.TryGetValue (grade, out students) ? students : new List<string> (0);
		}
	}
}

