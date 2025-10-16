using System;
namespace AC06SumTwoNumbers
{
    public class SumTwoNumbers
    {
        public static void Main()
        {
            const string MSG_Input1 = "Enter the first integer:";
            const string MSG_Input2 = "Enter the second integer:";
            const string MSG_Input3 = "The sum is:";

            int num1;
            int num2;
            int sum;

            Console.WriteLine(MSG_Input1);
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(MSG_Input2);
            num2 = Convert.ToInt32(Console.ReadLine());

            sum = num1 + num2;
            Console.WriteLine(MSG_Input3);
            Console.Write(sum);
        }
    }
}


