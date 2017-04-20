using CarsandProgramming.Interfaces;
using System;
using System.Collections.Generic;
using CarsandProgramming.Models;

namespace CarsandProgramming.DAL
{
    public class CarsRepository : ICarRepository
    {
        public Car Create(string year, string make, string model, int yearsOwned)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            throw new NotImplementedException();
        }

        public Car GetById(int id)
        {
            if (id == 0) return null;

            if (id == 1)
            {
                return new Car
                {
                    Make = "Chevrolet",
                    Model = "Suburban",
                    Year = 1992,
                    YearsOwned = 21
                };
            }
            else
            {
                return new Car
                {
                    Make = "Chevrolet",
                    Model = "Volt",
                    Year = 2016,
                    YearsOwned = 1
                };
            }
        }
    }
}