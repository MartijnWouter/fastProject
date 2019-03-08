using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("started up the program");
            Console.ReadLine();
            Ride ride = new Ride(new Date(1, 6, 2019), new Time(13, 30), new Vehicle("bus", new Price("€", 5, 12), new Price("€", 1, 55)), "spectrum");
            Console.WriteLine(ride.getStartingDate("day") + " " + ride.getStartingTime("min") + " from: " + ride.getStartingPlace());
            Console.ReadLine();
        }
    }
}
