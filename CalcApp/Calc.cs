using CalcLib;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CalcApp
{
	internal class Calc
	{
		public static double Sum(IEnumerable<int> nums)
		{
			int s = nums.Aggregate((ac, it) => CalcLib.Operators.Add(ac, it));
			return s;
		}

		public static Tuple<double, double> Range(int value, int diff)
		{
			if(diff < 0)
			{
				diff = -diff;
			}
			return Tuple.Create((double)Operators.Sub(value, diff), (double)Operators.Add(value, diff));
		}
	}
}
