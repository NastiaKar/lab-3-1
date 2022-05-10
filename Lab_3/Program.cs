using static System.Console;

namespace Lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle testTruck = new Truck();
            WriteLine(testTruck);
            Vehicle testCar = new Car();
            WriteLine(testCar);
            Vehicle car1 = new Car("Toyota", "Green", 1400);
            Vehicle car2 = new Car("Toyota", "Green", 1400);

            WriteLine();
            WriteLine($"Truck: {testTruck.GetHashCode()}\nCar: {testCar.GetHashCode()}");
            WriteLine($"Car1 {car1.GetHashCode()}\nCar2: {car2.GetHashCode()}");
            WriteLine();
            WriteLine(car1.Equals(car2));

            testTruck.ChangeLoadCapacity(12121212);
            WriteLine(testTruck);
            ReadKey();
        }
    }
}