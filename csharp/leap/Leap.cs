﻿using System;

namespace leap
{
	public static class Year
	{
		public static bool IsLeap(int year)
		{
			return (year % 400 == 0 ) || ( year % 100 != 0 && year % 4 == 0);
		}
	}
}
