using System;
using System.Collections.Generic;
using System.Text;

//comment

namespace Calculate
{
	public class Calculator
	{
		public static double DoOperation(double num1, double num2, string op)
		{
			double result = double.NaN; // Default value is "not-a-number" which we use if an operation, such as division, could result in an error

			// Use a switch statement to do the math
			switch (op)
			{
				case "a":
					result = num1 + num2;
					break;
				case "s":
					result = num1 - num2;
					break;
				case "m":
					result = num1 * num2;
					break;
				case "d":
					if (num2 != 0)
					{
						result = num1 / num2;
					}
					break;
			}
			return result;
		}
	}
}
