using static System.Console;

namespace Lab_3;

public abstract class Vehicle
{
    protected int _loadCapacity;
    
    public string Brand { get; protected set; }
    public string Color { get; protected set; }
    public virtual int LoadCapacity
    {
        protected set
        {
            if (value > 0) _loadCapacity = value;
        }
        get => _loadCapacity;
    }

    public Vehicle(string brand = "Mercedes", string color = "Black", int capacity = 1500) {
        Brand = brand;
        Color = color;
        LoadCapacity = capacity;
    }

    public override string ToString() => $"Brand: {Brand}\nColor: {Color}\nCapacity: {LoadCapacity} kg";

    public override bool Equals(object? obj)
    {
        if (obj == null)
            return false;
        Vehicle? v = obj as Vehicle;
        Write("Equality: ");
        
        return Brand == v!.Brand && Color == v.Color && LoadCapacity == v.LoadCapacity;
    }

    public override int GetHashCode()
    {
        Write("Hashcode: ");
        return Brand.GetHashCode() + Color.GetHashCode() + LoadCapacity.GetHashCode();
    }

    public void ChangeBrand(string newBrand)
    {
        WriteLine($"Brand changed to {newBrand}");
        Brand = newBrand;
    }

    public void ChangeColor(string newColor)
    {
        WriteLine($"Color changed to {newColor}");
        Color = newColor;
    }

    public void ChangeLoadCapacity(int newCapacity)
    {
        LoadCapacity = newCapacity;
        WriteLine($"Load capacity changed to {LoadCapacity} kg");
    }
}

sealed class Truck : Vehicle {
    public override int LoadCapacity
    {
        protected set
        {
            if (value < 10000) _loadCapacity = 10000;
            else _loadCapacity = value;
        }
        get => _loadCapacity;
    }

    public Truck(string brand = "Ford", string color = "Red", int capacity = 10000) : base (brand, color)
    {
        LoadCapacity = capacity;
    }
}

sealed class Car : Vehicle
{
    public override int LoadCapacity
    {
        protected set
        {
            if (value > 10000) _loadCapacity = 9000;
            else _loadCapacity = value;
        }
        get => _loadCapacity;
    }

    public Car(string brand = "Toyota", string color = "Yellow", int capacity = 2000) : base(brand, color)
    {
        LoadCapacity = capacity;
    }
}