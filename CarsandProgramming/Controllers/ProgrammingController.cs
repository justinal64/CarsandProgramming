﻿using CarsandProgramming.DAL;
using CarsandProgramming.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CarsandProgramming.Controllers
{
    public class ProgrammingController : ApiController
    {
        readonly IProgrammingRepository _getter;

        public ProgrammingController()
        {
            _getter = new ProgrammingRepository();
        }

        public ProgrammingController(IProgrammingRepository getter)
        {
            _getter = getter;
        }

        [HttpGet]
        [Route("api/programming/{id}")]
        public HttpResponseMessage CrazyTime(int id)
        {
            var programmingLanguage = _getter.GetById(id);

            if (programmingLanguage == null)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound,
                    $"No programming language with an id of {id} exist");
            }

            return Request.CreateResponse(HttpStatusCode.OK, programmingLanguage);
        }
    }
}
