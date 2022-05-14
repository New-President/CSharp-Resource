// See https://aka.ms/new-console-template for more information
internal class S10219524_Question03
{
    static void Main(string[] args)
    {
        S10219524_Question03.DisplayBusRoute();
        Console.Write("\nEnter boarding bus stop: ");
        int boarding = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter alighting bus stop: ");
        int alighting = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Distance travelled: {0}km", S10219524_Question03.ProcessData("A", boarding, alighting));
        Console.WriteLine("Fare to pay: $" + S10219524_Question03.ProcessData("B", boarding, alighting));
        Console.WriteLine("Estimated duration: {0}mins", Convert.ToInt32(S10219524_Question03.ProcessData("C", boarding, alighting)));
    }
    static double ReadDistanceBasedFare(double distance)
    {
        string[] lines = File.ReadAllLines("distance-based-fare(5).csv");
        double fare = 0;
        for (int i = 1; i < lines.Length; i++)
        {
            string[] line = lines[i].Split(",");
            if (Convert.ToDouble(line[0]) >= distance)
            {
                fare = Convert.ToDouble(line[1]) / 100;
                break;
            }
            else
            {
                continue;
            }
        }
        return fare;
    }
    static double ReadBusRoute(int boarding, int alighting)
    {
        string[] lines = File.ReadAllLines("bus_174(5).csv");
        double distance = 0;
        for (int i = 1; i < lines.Length; i++)
        {
            string[] line = lines[i].Split(",");
            if (Convert.ToInt32(line[1]) == boarding)
            {
                distance -= Convert.ToDouble(line[0]);
            }
            else if (Convert.ToInt32(line[1]) == alighting)
            {
                distance += Convert.ToDouble(line[0]);
            }
            else
            {
                continue;
            }
        }
        return distance;
    }
    static void DisplayBusRoute()
    {
        string[] lines = File.ReadAllLines("bus_174(5).csv");
        for (int i = 0; i < lines.Length; i++)
        {
            string[] line = lines[i].Split(",");
            if (lines[i] == lines[0])
            {
                Console.WriteLine("{0} {1,15} {2,5} {3,36}", line[0], line[1], line[2], line[3]);
            }
            else
            {
                Console.WriteLine("{0,-15} {1,-14} {2,-20} {3,-15}", line[0], line[1], line[2], line[3]);
            }
        }
    }
    static double ProcessData(string display, int boarding, int alighting)
    {
        double distances = S10219524_Question03.ReadBusRoute(boarding, alighting);
        double fares = S10219524_Question03.ReadDistanceBasedFare(distances);
        double timing = distances * 4;
        if (display == "A")
        {
            return distances;
        }
        else if (display == "B")
        {
            return fares;
        }
        else
        {
            return timing;
        }
    }
}
