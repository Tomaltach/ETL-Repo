using FarmSystem.Test2.Interfaces;
using System;

namespace FarmSystem.Test1.Animals
{
    public abstract class MilkingAnimal : FarmAnimal, IMilkableAnimal
    {
        public void ProduceMilk() => Console.WriteLine($"{Animal} produced milk");
    }
}
