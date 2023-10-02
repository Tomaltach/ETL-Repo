using FarmSystem.Test1.Interfaces;
using System;

namespace FarmSystem.Test1.Animals
{
    public abstract class FarmAnimal : IAnimal
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public abstract string Animal { get; }
        public abstract string Noise { get; }
        public abstract int NoOfLegs { get; }

        public void Talk() => Console.WriteLine($"{Animal} says {Noise}!");
        public void Run() => Console.WriteLine($"{Animal} is running");
        public void Walk() => Console.WriteLine($"{Animal} is walking");
    }
}
