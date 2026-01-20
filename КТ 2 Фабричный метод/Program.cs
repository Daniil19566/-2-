using КТ_2_Фабричный_метод;

class Program
{
    static void Main(string[] args)
    {
        VehicleCreator carCreator = new CarCreator();
        Console.WriteLine(carCreator.SomeOperation());

        VehicleCreator truckCreator = new TruckCreator();
        Console.WriteLine(truckCreator.SomeOperation());

        VehicleCreator motorcycleCreator = new MotorcycleCreator();
        Console.WriteLine(motorcycleCreator.SomeOperation());
    }
}