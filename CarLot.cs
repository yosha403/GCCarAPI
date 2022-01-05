using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GCCarAPI
{
    public class CarLot
    {
        public List<Car> Inventory { get; set; } = new List<Car>();
        public CarLot()
        {
            Inventory.Add(new Car("Ford", "Focus", 2017, "blue"));
            Inventory.Add(new Car("Ford", "F150", 2017, "red"));
            Inventory.Add(new Car("Chevi", "Impala", 2017, "red"));
            Inventory.Add(new Car("Honda", "CRV", 2015, "grey"));
            Inventory.Add(new Car("Jeep", "Cherokee", 2013, "white"));
            Inventory.Add(new Car("Nissan", "Pathfinder", 2016, "blue"));
        }
    }
}
