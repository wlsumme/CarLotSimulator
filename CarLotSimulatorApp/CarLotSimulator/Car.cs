using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace CarLotSimulator
{
    //Create a seperate class file called Car
    //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
    //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
    //The methods should take one string parameter: the respective noise property
    public class Car
    {
        public int Year { get; set; }
        public string Make {  get; set; }
        public string Model { get; set; }
        public string Enginenoise { get; set; }
        public string HonkNoise { get; set; }

        public bool IsDrivable { get; set; }

        public void MakeEngineNoise(string engineNoise)
        {
            Console.WriteLine($"{Make} {Model}'s engine sounds like {engineNoise}");

        }

        public void MakeHonkNoise(string honkNoise)
        {
            Console.WriteLine($"{Make} {Model}'s horn sounds like {honkNoise}");
        }

        public Car()
        {
            CarLot._numberOfCars++;
        }

        public Car(int year, string make, string model, string enginenoise, string honkNoise, bool isDrivable)
        {
            Year = year;
            Make = make;    
            Model = model;
            Enginenoise = enginenoise;
            HonkNoise = honkNoise;
            IsDrivable = isDrivable;
            CarLot._numberOfCars++;
            
        }


    }

}
