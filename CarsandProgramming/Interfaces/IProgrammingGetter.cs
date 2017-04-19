using CarsandProgramming.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsandProgramming.Interfaces
{
    public interface IProgrammingGetter
    {
        ProgrammingLanguage GetById(int id);
    }
}
