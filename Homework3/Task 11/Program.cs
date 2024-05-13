public enum VehicleType
{
    Car,
    Truck,
    Bicycle,
    Motorcycle
}

class Vehicle
{
    public string Make;
    public string Model;
    public int Year;
    public VehicleType Type;

    public Vehicle(string make, string model, int year, VehicleType type)
    {
        Make = make;
        Model = model;
        Year = year;
        Type = type;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Марка: {Make}, Модель: {Model}, Год выпуска: {Year}, Тип: {Type}");
    }
}

class Program
{
    static void Main()
    {
        Vehicle car = new Vehicle("Lexus", "Rx", 2023, VehicleType.Car);
        Vehicle truck = new Vehicle("Kamaz", "Belaz", 1990, VehicleType.Truck);
        Vehicle bicycle = new Vehicle("Sportmaster", "Stern", 2024, VehicleType.Bicycle);
        Vehicle motorcycle = new Vehicle("Ducatt", "Panigale", 2024, VehicleType.Motorcycle);

        car.DisplayInfo();
        truck.DisplayInfo();
        bicycle.DisplayInfo();
        motorcycle.DisplayInfo();
    }
}
