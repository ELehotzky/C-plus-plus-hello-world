using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string myValue = "1";
            string anotherValue = "2";

            int num1 = 1;
            int num2 = 2;
            int converted = 0;

            Console.WriteLine(num1.ToString() + num2.ToString());
            Console.WriteLine(myValue + anotherValue);

            converted = Convert.ToInt32("1");

            Console.WriteLine(converted);

            Console.ReadLine();
        }
        static void WriteLine(string value)
        {

        }
    }
}
