using FarmSystem.Test1.Animals;
using FarmSystem.Test1.Enum;

namespace FarmSystem.Test1
{
    public static class AnimalFactory
    {
        public static FarmAnimal GetAnimal(AnimalEnum animal)
        {
            switch (animal)
            {
                case AnimalEnum.Cow: return new Cow();
                case AnimalEnum.Hen: return new Hen();
                case AnimalEnum.Horse: return new Horse();
                case AnimalEnum.Sheep: return new Sheep();
                default: return null;
            }
        }
    }
}
