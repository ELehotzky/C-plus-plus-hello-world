using System;

namespace HelloWorld
{
    class Program
    {
        static void MultipleLegs(PetStruct petStruct, PetClass petClass)
        {
            petStruct.Legs = petStruct.Legs * 2;
            petClass.Legs = petClass.Legs * 2;

            Console.WriteLine("Internal Method - A " + petStruct.Type + " has " + petStruct.Legs + " legs.");
            Console.WriteLine("Internal Method - A " + petClass.Type + " has " + petClass.Legs + " legs.");
        }

        static void Main(string[] args)
        {
            // int[5] tells us there will be 5 items in the array
            int[] intArray = new int[5]; 
            string[] strArray = new string[5];

            // storing items in the arrays
            int[] populatedIntArray = new int[] { 0, 1, 2, 3, 4, 5 };
            string[] populatedStrArray = new string[] { "One", "Two", "Three" };

            intArray[0] = 5;
            intArray[2] = 15;

            int firstVal = intArray[0];

            // initializing two arrays with three items each
            int[,] multiInt = new int[2, 3];
            int[,] multiPopulatedInt = { { 1, 2, 3 }, { 5, 6, 7 } };

            int firstMultiVal = multiPopulatedInt[0, 0];
            int secondMultiVal = multiPopulatedInt[1, 2];

            PetStruct dog = new PetStruct();
            dog.Type = PetType.Dog;
            dog.HasFur = true;
            dog.Legs = 4;

            PetClass duck = new PetClass();
            duck.Type = PetType.Duck;
            duck.HasFur = false;
            duck.Legs = 2;

            Console.WriteLine("a " + dog.Type + " has " + dog.Legs + " legs");
            Console.WriteLine("a " + duck.Type + " has " + duck.Legs + " legs");

            MultipleLegs(dog, duck);
            Console.WriteLine("a " + dog.Type + " has " + dog.Legs + " legs");
            Console.WriteLine("a " + duck.Type + " has " + duck.Legs + " legs");

            Console.ReadLine();
        }

        class PetClass
        {
            public int Legs;
            public PetType Type;
            public string Name;
            public bool HasFur;
        }

        struct PetStruct
        {
            public int Legs;
            public PetType Type;
            public string Name;
            public bool HasFur;
        }

        enum PetType
        {
            Dog, 
            Duck
        }
    }
}
