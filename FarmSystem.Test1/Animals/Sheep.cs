using System;

namespace FarmSystem.Test1.Animals
{
    public class Sheep : FarmAnimal
    {
        public override string Animal => "Sheep";
        public override int NoOfLegs => 4;

        public override void Talk() => Console.WriteLine($"{Animal} says baa!");
    }
}