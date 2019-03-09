using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            // initialize the program
            Console.WriteLine("This is another project for IT 2040.");
            Console.WriteLine("-------------------------------------");
            Pet pet1 = new Pet("dog", "Shadow", "Jose", 42.6);

            Console.WriteLine("\nName: " + pet1.Name);
            Console.WriteLine("Weight: " + pet1.Weight);
            Console.WriteLine(pet1.GetTag());

            Console.WriteLine("");

            Dog dog1 = new Dog("Daisy", "Kent", 23.4);

            Console.WriteLine("Name: " + dog1.Name);
            Console.WriteLine("Weight: " + dog1.Weight);
            Console.WriteLine(dog1.GetTag());
            Console.WriteLine(dog1.Bark(4));

            Console.WriteLine("");

            Cat cat1 = new Cat("Simba", "Maria", 5.2);

            Console.WriteLine("Name: " + cat1.Name);
            Console.WriteLine("Weight: " + cat1.Weight);
            Console.WriteLine(cat1.GetTag());
            Console.WriteLine(cat1.Meow(3));

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadLine();
        }
    }
}
