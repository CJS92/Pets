using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets
{
    class Dog
    {
        public string Name { get; }
        public string Owner { get; }
        public double Weight { get; }

        public Dog(string petName, string petOwner, double petWeight)
        {
            Name = petName;
            Owner = petOwner;
            Weight = petWeight;
        }

        public string Bark(int times)
        {
            int i = 0;
            string bark = "bark!";
            string barks = "";
            while (i <= times)
            {
                barks = barks + bark;
                i++;
            }
            return barks;
        }

        public string GetTag()
        {
            string tag = "If lost, call " + Owner;
            return tag;
        }
    }
}
