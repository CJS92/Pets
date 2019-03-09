using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets
{
    class Cat
    {
        public string Name { get; }
        public string Owner { get; }
        public double Weight { get; }

        public Cat(string petName, string petOwner, double petWeight)
        {
            Name = petName;
            Owner = petOwner;
            Weight = petWeight;
        }

        public string Meow (int times)
        {
            int i = 0;
            string meow = "meow.";
            string meows = "";
            while (i <= times)
            {
                meows = meows + meow;
                i++;
            }
            return meows;
        }

        public string GetTag()
        {
            string tag = "If lost, call " + Owner;
            return tag;
        }
    }
}