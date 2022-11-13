using System;
using System.Linq;

namespace CalcApp
{
	internal class Program
	{
		static void Main()
		{
			double sum = Calc.Sum(Enumerable.Range(1, 10));
			Console.WriteLine($"sum: {sum}");
		}
	}
}
