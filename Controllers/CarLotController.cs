using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GCCarAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarLotController : ControllerBase
    {
        CarLot cLot = new CarLot();

        [HttpGet]
        public List<Car> GetAllCars()
        {
            return cLot.Inventory;
        }

        [HttpGet("SearchByIndex/{index}")]
        public Car SearchCarByIndex(int index)
        {
            Car errorCar = new Car("Error", "Error", 0000, "Invalid car index");
            try
            {
                return cLot.Inventory[index];
            }
            catch
            {
                return errorCar;
            }
        }

        [HttpGet("SearchByMake/{make}")]
        public List<Car> SearchByMake(string make)
        {
            List<Car> listOfCarsByMake = new List<Car>();
            foreach(Car c in cLot.Inventory)
            {
                if(make.ToLower()==c.Make.ToLower())
                {
                    listOfCarsByMake.Add(c);
                }
            }
            return listOfCarsByMake;
        }

        [HttpGet("SearchByColor/{color}")]
        public List<Car> SearchByColor(string color)
        {
            List<Car> listOfCarsByColor = new List<Car>();
            foreach (Car c in cLot.Inventory)
            {
                if (color.ToLower() == c.Color.ToLower())
                {
                    listOfCarsByColor.Add(c);
                }
            }
            return listOfCarsByColor;
        }
    }
}
