using System;

namespace FarmSystem.Test1.Animals
{
    public class Horse : FarmAnimal
    {
        public override string Animal => "Horse";
        public override int NoOfLegs => 4;

        public override void Talk() => Console.WriteLine($"{Animal} says neigh!");
    }
}