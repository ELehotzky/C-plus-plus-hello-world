using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            PetStruct dog;
            dog.Type = PetType.Dog;
            dog.HasFur = true;
            dog.Legs = 4;

            PetClass duck = new PetClass();
            duck.Type = PetType.Duck;
            duck.HasFur = false;
            duck.Legs = 2;

            Console.Write("a " + dog.Type + " has " + dog.Legs + " legs");
            Console.Write("a " + duck.Type + " has " + duck.Legs + " legs");

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
