using System;

namespace FarmSystem.Test1.Animals
{
    public class Hen : FarmAnimal
    {
        public override string Animal => "Hen";
        public override int NoOfLegs => 2;

        public override void Talk() => Console.WriteLine($"{Animal} says CLUCKAAAAAWWWWK!");
    }
}