using FarmSystem.Test1.Animals;
using FarmSystem.Test2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FarmSystem.Test1
{
    public class EmydexFarmSystem
    {
        private readonly Queue<FarmAnimal> _heldAnimals = new Queue<FarmAnimal>();

        public delegate void EventHandler(object sender, EventArgs args);
        public event EventHandler FarmEmpty = delegate { };

        //TEST 1
        public void Enter(FarmAnimal animal)
        {
            //TODO Modify the code so that we can display the type of animal (cow, sheep etc) 
            //Hold all the animals so it is available for future activities
            _heldAnimals.Enqueue(animal);
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
            var animalsThatProduceMilk = 0;
            if (!_heldAnimals.Any()) Console.WriteLine("There are no animals in the farm");
            else
            {
                foreach (var animal in _heldAnimals)
                {
                    if (!(animal is IMilkableAnimal)) continue;
                    ((IMilkableAnimal)animal).ProduceMilk();
                    animalsThatProduceMilk++;
                }
            }
            if (animalsThatProduceMilk <= 0) Console.WriteLine("Cannot identify the farm animals which can be milked");
        }

        //TEST 4
        public void ReleaseAllAnimals()
        {
            if (!_heldAnimals.Any()) return;
            while (_heldAnimals.Count > 0)
            {
                var animal = _heldAnimals.Dequeue();
                Console.WriteLine($"{animal.Animal} has left the farm");
            }
            FarmEmpty(this, new EventArgs());
        }
    }
}