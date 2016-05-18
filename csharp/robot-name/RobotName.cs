using System;

namespace robot
{
	public class Robot
	{
		private static Random _random = new Random ();

		public string Name { get; private set; }

		public Robot ()
		{
			Reset ();
		}

		public void Reset ()
		{
			Name = GenerateName ();
		}

		private string GenerateNumber ()
		{
			return _random.Next (1000).ToString ("000");
		}

		private char GenerateCharacter ()
		{
			return (char)('A' + _random.Next (26));
		}

		private string GenerateName()
		{
			return String.Format ("{0}{1}{2}", GenerateCharacter (), GenerateCharacter (), GenerateNumber ());
		}
	}
}