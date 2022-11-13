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
	}
}
