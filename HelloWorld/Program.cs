using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string myValue;
            string anotherValue;

            myValue = "Value 1";
            anotherValue = "Value 2";
            Console.WriteLine(myValue);
            Console.WriteLine(anotherValue);

            anotherValue = myValue;
            Console.WriteLine(anotherValue);
            Console.ReadLine();
        }
        static void WriteLine(string value)
        {

        }
    }
}
