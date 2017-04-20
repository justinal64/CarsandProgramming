using CarsandProgramming.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsandProgramming.Interfaces
{
    public interface IProgrammingRepository
    {
        ProgrammingLanguage GetById(int id);

        List<ProgrammingLanguage> GetAll();

        ProgrammingLanguage Create(int activeUsers, string language, string yearCreated);

    }
}
