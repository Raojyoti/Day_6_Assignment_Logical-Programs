using System;

namespace Temperature_Conversion
{
    internal class Program
    {
        static void Main(string[] args)
            {
            Console.Write("Enter value for C: ");
            temperatureConversion.C=Convert.ToInt32(Console.ReadLine());
            temperatureConversion.temperaturConversionToFahrenheit();

            Console.WriteLine(" \n ");

            Console.Write("Enter value for F: ");
            temperatureConversion.F = Convert.ToInt32(Console.ReadLine()); ;
            temperatureConversion.temperaturConversionToCelsius();
            Console.WriteLine(" \n ");
        }
       
    }
}
