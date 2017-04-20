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
    public class CarController : ApiController
    {
        readonly ICarRepository _getter;

        public CarController()
        {
            _getter = new CarsRepository();
        }

        public CarController(ICarRepository getter)
        {
            _getter = getter;
        }

        [HttpGet]
        [Route("api/car/{id}")]
        public HttpResponseMessage CrazyTime(int id)
        {
            var car = _getter.GetById(id);

            if (car == null)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound,
                    $"No cars with an id of {id} exist");
            }

            return Request.CreateResponse(HttpStatusCode.OK, car);
        }

    }
}
