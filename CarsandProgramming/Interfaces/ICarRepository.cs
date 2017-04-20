using CarsandProgramming.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsandProgramming.Interfaces
{
    public interface ICarRepository
    {
        Car GetById(int id);
        List<Car> GetAll();
        Car Create(string year, string make, string model, int yearsOwned);
    }
}