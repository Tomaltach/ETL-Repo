using FarmSystem.Test2.Interfaces;
using System;

namespace FarmSystem.Test1.Animals
{
    public class Cow : FarmAnimal, IMilkableAnimal
    {
        public override string Animal => "Cow";
        public override string Noise => "Moo";
        public override int NoOfLegs => 4;

        public void ProduceMilk() => Console.WriteLine($"{Animal} produced milk");
    }
}