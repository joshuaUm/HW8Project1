/// Homework No. 8 Project No. 1
/// File Name : Program.cs
/// @author : Joshua Um
/// Date : Oct 25 2021
/// 
/// Problem Statement :Define a class called Odometer that will be used to track fuel usage and miles per gallon.
/// 
/// Plan:
/// 1. Create Odometer.
/// 2. Test Default constructor.
/// 3. Test Full constructor.
/// 4. Test add().
/// 5. Test reset().


using System;

namespace HW8Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            Odometer odo = new Odometer();

            Console.WriteLine("Default constructor" + odo);

            odo = new Odometer(19, 20);

            Console.WriteLine("Full constructor : " + odo);

            odo.add(10, 10);

            Console.WriteLine("add() test: " + odo);

            odo.reset();

            Console.WriteLine("reset() test: " + odo);






        }
    }

    class Odometer
    {
        private int milage;
        private int fuelConsumed;

        public int Milage { get { return milage; } set { milage = value; } }
        public int FuelConsumed { get { return fuelConsumed; } set { fuelConsumed = value; } }


        public Odometer()
        {
            milage = 0;
            fuelConsumed = 0;
        }

        public Odometer(int milage, int fuelConsumed)
        {
            this.milage = milage;
            this.fuelConsumed = fuelConsumed;
        }


        public void reset()
        {
            milage = 0;
            fuelConsumed = 0;
        }

        public void add(int mileage, int fuelConsumed)
        {
            this.milage += milage;
            this.fuelConsumed += fuelConsumed;
        }



        public override string ToString()
        {
            return "\nMileage : " + milage + "mpg\n" +
                   "Fuel consumed : " + fuelConsumed + " gallons";
        }






    }
}
