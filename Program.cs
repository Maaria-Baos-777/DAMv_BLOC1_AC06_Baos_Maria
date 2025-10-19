using System;
namespace AC06RectangleArea
{
    public class RectangleArea
    {
        public static void Main()
        {
            const string MSG_INPUT_WIDTH = "Enter the width of the rectangle:";
            const string MSG_INPUT_HEIGHT = "Enter the height of the rectangle:";
            const string MSG_RESULT = "The area of the rectangle is:";

            double width;
            double height;
            double area;

            Console.WriteLine(MSG_INPUT_WIDTH);
            width = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(MSG_INPUT_HEIGHT);
            height = Convert.ToDouble(Console.ReadLine());

            area = width * height;

            Console.WriteLine(MSG_RESULT + area);

        }
    }
}


