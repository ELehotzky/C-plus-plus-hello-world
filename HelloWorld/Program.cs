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

            // lists don't need to have the number of items declared
            List<string> listOfStrings = new List<string>();
            listOfStrings.Add("First String");
            listOfStrings.Insert(0, "Inserted String");

            listOfStrings.Remove("First String");
            listOfStrings.RemoveAt(0);

            listOfStrings.Sort();

            var theFirstStrIs = listOfStrings[0];

            Dictionary<string, string> names = new Dictionary<string, string>();
            names.Add("James", "Bond");
            names.Add("Money", "Penny");

            Console.WriteLine("The name is " + names["James"]);

            names.Remove("James");

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

            List<PetClass> pets = new List<PetClass>();
            pets.Add(new PetClass { HasFur = false, Legs = 2, Name = "Donald", Type = PetType.Duck });
            pets.Add(new PetClass { HasFur = true, Legs = 4, Name = "Pluto", Type = PetType.Dog });

            List<PetClass> results = (from p in pets
                                     where p.Type == PetType.Dog
                                     select p).ToList();

            results = pets.Where(p => p.Type == PetType.Dog).ToList();

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
