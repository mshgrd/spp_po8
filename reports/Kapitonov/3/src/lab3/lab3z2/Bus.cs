namespace lab3z2;

public class Bus
{
    public Bus(string name, int busNumber, int routeNumber, string brand, int year, int mileage, BusStatus status)
    {
        Name = name;
        BusNumber = busNumber;
        RouteNumber = routeNumber;
        Brand = brand;
        Year = year;
        Mileage = mileage;
        Status = status;
    }

    public string Name { get; set; }
    public int BusNumber { get; set; }
    public int RouteNumber { get; set; }
    public string Brand { get; set; }
    public int Year { get; set; }
    public int Mileage { get; set; }
    public BusStatus Status { get; set; }
    
    public static List<Bus> Buses = new List<Bus>();

    public static void ShowAllBuses()
    {
        foreach (var bus in Buses)
        {
            Console.WriteLine(bus);
        }
    }
    public static void ShowAllBusesEnRoute()
    {
        foreach (var bus in Buses)
        {
            if (bus.Status == BusStatus.EnRoute)
            {
                Console.WriteLine(bus);
            }
        }
    }
    
    public static void ShowAllBusesOnTrip()
    {
        foreach (var bus in Buses)
        {
            if (bus.Status == BusStatus.OnTrip)
            {
                Console.WriteLine(bus);
            }
        }
    }
    
    public static void ShowAllBusesWithRouteNumber(int number)
    {
        foreach (var bus in Buses)
        {
            if (bus.RouteNumber == number)
            {
                Console.WriteLine(bus);
            }
        }
    }

    public static void ShowAllBusesElder10Years()
    {
        foreach (var bus in Buses)
        {
            if (bus.Year < DateTime.Now.Year - 10)
            {
                Console.WriteLine(bus);
            }
        }
    }

    public static void ShowAllBusesWithMileage(int mileage)
    {
        foreach (var bus in Buses)
        {
            if (bus.Mileage > mileage)
            {
                Console.WriteLine(bus);
            }
        }
    }
    
    public override string ToString()
    {
        return $"Name: {Name}, BusNumber: {BusNumber}, RouteNumber: {RouteNumber}, Brand: {Brand}, Year: {Year}, Mileage: {Mileage}, Status: {Status}";
    }

}



public enum BusStatus
{
    EnRoute,
    OnTrip
}