﻿using System;

namespace leap
{
	public static class Year
	{
		public static bool IsLeap(int year)
		{
			if (year % 400 == 0) {
				return true;
			} else if (year % 100 == 0) {
				return false;
			} else if (year % 4 == 0) {
				return true;
			} else {
				return false;
			}
		}
	}
}
