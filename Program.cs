using System;
namespace AC06CelsiusToKelvin
{
    public class CelsiusToKelvin
    {
        public static void Main()
        {
            const string MSG_INPUT = "Enter tempature in Celsius:";
            const string MSG_RESULT = "Temperature in Kelvin:";

            double celsius;
            double kelvin;

            Console.WriteLine(MSG_INPUT);
            celsius = Convert.ToDouble(Console.ReadLine());

            kelvin = celsius + 273.15;

            Console.WriteLine(MSG_RESULT + kelvin);
        }
    }
}


