using System;
namespace AC06EuroToDollar
{
    public class EuroToDollar
    {
        public static void Main()
        {
            const string MSG_INPUT = "Enter amount in euros:";
            const string MSG_RESULT = "Amount in dollars:";

            double EXCHANGE_RATE = 1.12;
            double euros;
            double dollars;

            Console.WriteLine(MSG_INPUT);
            euros = Convert.ToDouble(Console.ReadLine());
            dollars = euros * EXCHANGE_RATE;
            Console.WriteLine(MSG_RESULT + dollars);
        }
    }
}

