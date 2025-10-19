using System;
namespace AC06AverageThreeNumbers
{
    public class AverageThreeNumbers
    {
        public static void Main()
        {
            const string MSG_INPUT1 = "Enter the first number:";
            const string MSG_INPUT2 = "Enter the second number:";
            const string MSG_INPUT3 = "Enter the third number:";
            const string MSG_RESULT = "The average is:";

            double num1;
            double num2;
            double num3;
            double average;

            Console.WriteLine(MSG_INPUT1);
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(MSG_INPUT2);
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(MSG_INPUT3);
            num3 = Convert.ToDouble(Console.ReadLine());

            average = (num1 + num2 + num3) / 3;
            Console.WriteLine(MSG_RESULT + average);
        }
    }
}


