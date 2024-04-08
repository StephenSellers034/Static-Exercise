using System;
namespace StaticExercise
{
	public static class TempConverter
	{
		public static double FahrenheitToCelsius( )
		{
			Console.WriteLine("Enter the Temperature in Fahrenheit: ");
			double fahrenheit = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Temperature in Fahrenheit is: " + fahrenheit);
			double celsius = (fahrenheit - 32) * 5 / 9;
			Console.WriteLine("Temperature in Celsius is: " + celsius);
			return celsius;
		}

		public static double CelsiusToFahrenheit()
		{
			Console.WriteLine("Enter Temperature in Celsius: ");
			double celsius = Convert.ToDouble(Console.ReadLine());
			double fahrenheit = ((celsius * 9) / 5) + 32;
			Console.WriteLine("The converted Fahrenheit Temperature is:" + fahrenheit);
			return fahrenheit;
		}
	}
}

