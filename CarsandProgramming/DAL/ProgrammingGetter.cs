using CarsandProgramming.Interfaces;
using CarsandProgramming.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarsandProgramming.DAL
{
    public class ProgrammingGetter : IProgrammingGetter
    {
        public ProgrammingLanguage GetById(int id)
        {
            if (id == 0) return null;

            if (id == 1) {
                return new ProgrammingLanguage
                {
                    ActiveUsers = 100,
                    Language = "Javascript",
                    YearCreated = "A Long Time Ago"
                };
            } else {
                return new ProgrammingLanguage
                {
                    ActiveUsers = 21,
                    Language = "Ruby on Rails",
                    YearCreated = "2004"
                };
            }
        }
    }
}