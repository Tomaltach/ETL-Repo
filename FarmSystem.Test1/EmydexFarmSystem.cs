using FarmSystem.Test1.Animals;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FarmSystem.Test1
{
    public class EmydexFarmSystem
    {
        private readonly IList<FarmAnimal> _heldAnimals = new List<FarmAnimal>();

        //TEST 1
        public void Enter(FarmAnimal animal)
        {
            //TODO Modify the code so that we can display the type of animal (cow, sheep etc) 
            //Hold all the animals so it is available for future activities
            _heldAnimals.Add(animal);
            Console.WriteLine($"{animal.Animal} has entered the Emydex farm");
        }
     
        //TEST 2
        public void MakeNoise()
        {
            //Test 2 : Modify this method to make the animals talk
            if (!_heldAnimals.Any()) Console.WriteLine("There are no animals in the farm");
            else foreach (var animal in _heldAnimals) animal.Talk();
        }

        //TEST 3
        public void MilkAnimals()
        {
            Console.WriteLine("Cannot identify the farm animals which can be milked");
        }

        //TEST 4
        public void ReleaseAllAnimals()
        {
           Console.WriteLine("There are still animals in the farm, farm is not free");
        }
    }
}