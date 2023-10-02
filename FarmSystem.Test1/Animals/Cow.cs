namespace FarmSystem.Test1.Animals
{
    public class Cow : MilkingAnimal
    {
        public override string Animal => "Cow";
        public override string Noise => "Moo";
        public override int NoOfLegs => 4;
    }
}