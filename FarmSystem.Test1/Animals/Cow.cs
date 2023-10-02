using FarmSystem.Test2;
using System;

namespace FarmSystem.Test1.Animals
{
    public class Cow : FarmAnimal, IMilkableAnimal
    {
        public override string Animal => "Cow";
        public override int NoOfLegs => 4;

        public override void Talk() => Console.WriteLine($"{Animal} says Moo!");
        public void ProduceMilk() => Console.WriteLine($"{Animal} produced milk");
    }
}