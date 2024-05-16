using Microsoft.VisualBasic;
using System;
using System.Security.Cryptography.X509Certificates;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {

            var carLotOne = new CarLot();

            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property



            //Dot notation
            Car myCar = new Car();
            myCar.Year = 2019;
            myCar.Make = "Honda";
            myCar.Enginenoise = "Vroom";
            myCar.Model = "Civic";
            myCar.HonkNoise = "BEEP";
            myCar.IsDrivable = true;

            carLotOne.ParkingLot.Add(myCar);


            // Object Intializer
            Car yourCar = new Car

            {
                Year = 2050,
                Make = "Zyglorfizzatron",
                Enginenoise = "...silent...",
                Model = "LaserBeamPro",
                HonkNoise = "BANG",
                IsDrivable = true



            };
            carLotOne.ParkingLot.Add(yourCar);

            //using a custom constructor

            Car laurensCar = new Car(2019, "Kia", "Soul", "Chug Chug", "AAA", true);
            carLotOne.ParkingLot.Add(laurensCar);

            carLotOne.CarChecker();



            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
            
        }
        
    }
}
