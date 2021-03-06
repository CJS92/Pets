﻿// This is the pet class

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets
{
    class Pet
    {
        public string Type { get; }
        public string Name { get; }
        public string Owner { get; }
        public double Weight { get; }

        public Pet(string petType, string petName, string petOwner, double petWeight)
        {
            Type = petType;
            Name = petName;
            Owner = petOwner;
            Weight = petWeight;
        }

        public string GetTag()
        {
            string tag = "If lost, call " + Owner;
            return tag;
        }
    }
}
