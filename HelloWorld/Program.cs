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
