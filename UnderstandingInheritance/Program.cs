using System.Runtime.InteropServices;

namespace UnderstandingInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "BMW";
            myCar.Model = "745li";
            myCar.Color = "Black";
            myCar.Year = 2005;
            //myCar.TowingCapacity = 1200; dette kan man ikke da det er specifik for den speciele katergori af "Car" nemlig "truck"


            printVehicleDetails(myCar);

            Truck myTruck = new Truck();

            myTruck.Make = "Ford";
            myTruck.Model = "F950";
            myTruck.Color = "Black";
            myTruck.Year = 2006;
            myTruck.TowingCapacity = 1200;
            printVehicleDetails(myTruck);

            Console.ReadLine();
        }
        private static void printVehicleDetails(Vehicle vehicle)
        {
            Console.WriteLine("Here are the Vehicle's details: {0}",
                vehicle.FormatMe());
        }
    }

    abstract class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        
        public abstract string FormatMe();
    }
    class Car : Vehicle //base class
    {
        public override string FormatMe() //man kan benytte abstract(betyder at man SKAL lave et override et sted, eller at man skal bruge stream da det er en abstract class) Virtual(betyder at man KAN lave et override et sted) i visse tilfælde
        {
            return String.Format("{0} - {1} - {2} - {3}",
                this.Make,
                this.Model,
                this.Color,
                this.Year);
        }
    }
    sealed class Truck : Vehicle //sub class ---- "sealed" lukker classen så den ikke kan blive hentet andre steder
    {
        public int TowingCapacity { get; set; }
        public override string FormatMe()
        {
            return String.Format("{0} - {1} - {2} Towing units",
                this.Make,
                this.Model,
                this.TowingCapacity);
        }
    }
}