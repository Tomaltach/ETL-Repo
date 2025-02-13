﻿using System;

namespace FarmSystem.Test1.Interfaces
{
    public interface IAnimal
    {
        Guid Id { get; set; }
        string Animal { get; }
        string Noise { get; }
        int NoOfLegs { get; }

        void Run();
        void Walk();
        void Talk();
    }
}
