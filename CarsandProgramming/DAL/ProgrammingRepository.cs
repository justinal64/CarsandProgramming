using System;
using System.Collections.Generic;
using CarsandProgramming.Interfaces;
using CarsandProgramming.Models;

namespace CarsandProgramming.DAL
{
    public class ProgrammingRepository : IProgrammingRepository
    {
        public ProgrammingLanguage Create(int activeUsers, string language, string yearCreated)
        {
            throw new NotImplementedException();
        }

        public List<ProgrammingLanguage> GetAll()
        {
            throw new NotImplementedException();
        }

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