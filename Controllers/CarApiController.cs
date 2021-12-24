using CarRent.Data;
using CarRent.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CarRent.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarApiController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CarApiController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/<CarApiController>
        [HttpGet]
        public IEnumerable<Car> Get()
        {
            return _context.Cars.ToList();
        }

        // GET api/<CarApiController>/5
        [HttpGet("{id}")]
        public Car Get(int id)
        {
            return _context.Cars.FirstOrDefault(x => x.CarId == id);
        }

        // POST api/<CarApiController>
        [HttpPost]
        public void Post([FromBody] Car car)
        {
            _context.Cars.Add(car);
            _context.SaveChanges();
        }

        // PUT api/<CarApiController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Car c)
        {
            var car = _context.Cars.FirstOrDefault(x => x.CarId == id);
            if(car is null)
            {

            }
            else
            {
                car.CarId = c.CarId;
                car.CarBrand = c.CarBrand;
                car.CarModel = c.CarModel;
                car.CarColor = c.CarColor;
                car.CarCoverImageUrl = c.CarCoverImageUrl;
                car.CarDepositPrice = c.CarDepositPrice;
                car.CarImageUrl = c.CarImageUrl;
                car.CarKilometer = c.CarKilometer;
                car.CarProductYear = c.CarProductYear;
                car.CarRentPrice = c.CarRentPrice;
                car.CarTransmissionType = c.CarTransmissionType;
                car.CarTrimPackage = c.CarTrimPackage;
                car.CarType = c.CarType;
                car.EngineId = c.EngineId;
                car.Engine = c.Engine;
                car.MinimumAge = c.MinimumAge;
                car.OfficeId = c.OfficeId;
                car.Office = c.Office;
                car.Reservations = c.Reservations;
                _context.SaveChanges();
            }
            
        }

        // DELETE api/<CarApiController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var car = _context.Cars.FirstOrDefault(x => x.CarId == id);
            if(car is null)
            {

            }
            else
            {
                _context.Cars.Remove(car);
                _context.SaveChanges();
            }
        }
    }
}
