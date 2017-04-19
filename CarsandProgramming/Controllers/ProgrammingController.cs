using CarsandProgramming.DAL;
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
        readonly IProgrammingGetter _getter;

        public ProgrammingController()
        {
            _getter = new ProgrammingGetter();
        }

        public ProgrammingController(IProgrammingGetter getter)
        {
            _getter = getter;
        }

        [HttpGet]
        [Route("api/programming/{id}")]
        public HttpResponseMessage CrazyTime(int id)
        {
            var sash = _getter.GetById(id);

            if (sash == null)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound,
                    $"No programming language with an id of {id} exist");
            }

            return Request.CreateResponse(HttpStatusCode.OK, sash);
        }
    }
}
