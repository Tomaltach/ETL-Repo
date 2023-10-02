﻿using System;

namespace FarmSystem.Test1.Animals
{
    public interface IAnimal
    {
        Guid Id { get; set; }
        string Animal { get; }
        int NoOfLegs { get; }

        void Run();
        void Walk();
        void Talk();
    }
}
