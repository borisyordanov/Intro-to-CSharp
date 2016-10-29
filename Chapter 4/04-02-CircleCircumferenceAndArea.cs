using System;
using System.Linq;
using System.Threading;

namespace CircleCircumferenceAndArea
{
	class CircleCircumferenceAndArea
	{
		static void Main(string[] args)
		{
			Thread.CurrentThread.CurrentCulture =
				System.Globalization.CultureInfo.InvariantCulture;
			float radius = float.Parse(Console.ReadLine());
			double circumference = 2 * Math.PI * radius;
			double area = Math.PI * radius * radius;
			Console.WriteLine("{0:F3}", circumference);
			Console.WriteLine("{0:F3}", area);
		}
	}
}