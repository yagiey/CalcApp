using System;
using System.Collections.Generic;
using System.Linq;

namespace CalcApp
{
	internal class Program
	{
		static void Main()
		{
			double sum = Calc.Sum(Enumerable.Range(1, 10));
			Console.WriteLine($"sum: {sum}");

			var range = Calc.Range(50, 10);

			return;
		}
	}
}
