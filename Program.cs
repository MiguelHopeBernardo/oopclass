using System;

// abstraction
abstract class Vehicle {
    // Common Attributes
    public string Model;
    public string Make;
    public int Year;

    // Constructor
    protected Vehicle(string model, string make, int year) {
        Model = model;
        Make = make;
        Year = year;
    }

    // Abstract Method
    public abstract void Drive();
}

// Car class inheriting from Vehicle
class Car : Vehicle {
    // Constructor
    public Car(string model, string make, int year) : base(model, make, year) {
    }

    // Override Drive method
    public override void Drive() {
        Console.WriteLine("The car is now running. Vrroooom!");
    }
}

// ElectricCar class inheriting from Car
class ElectricCar : Car {
    // Unique attribute
    public int BatteryCapacity;

    // Constructor
    public ElectricCar(string model, string make, int year, int batteryCapacity) : base(model, make, year) {
        BatteryCapacity = batteryCapacity;
    }

    // Override Drive method with different implementation
    public override void Drive() {
        Console.WriteLine("The electric car is now running silently.");
    }
}

class Program {
    static void Main(string[] args) {
        // Using Car class
        Car myCar = new Car("Toyota", "Corolla", 2023);
        Console.WriteLine($"Model: {myCar.Model}, Make: {myCar.Make}, Year: {myCar.Year}");
        myCar.Drive();

        // Using ElectricCar class
        ElectricCar myElectricCar = new ElectricCar("Tesla", "Model S", 2024, 100);
        Console.WriteLine($"Model: {myElectricCar.Model}, Make: {myElectricCar.Make}, Year: {myElectricCar.Year}, Battery Capacity: {myElectricCar.BatteryCapacity} kWh");
        myElectricCar.Drive();
    }
}
