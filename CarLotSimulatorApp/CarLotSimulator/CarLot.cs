using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class CarLot
    {
        public static int _numberOfCars = 0;
        public List<Car> ParkingLot { get; set; } = new List<Car>();

        public void CarChecker()
        {
            foreach (Car car in ParkingLot)
            {
                Console.WriteLine($"{car.Make},\n {car.Model}\n {car.Year}");
                car.MakeEngineNoise(car.Enginenoise);
                car.MakeHonkNoise(car.HonkNoise);

            }
        }
    }
}

