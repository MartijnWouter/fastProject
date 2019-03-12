using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace ConsoleApp2
{
    public class Program
    {
        
        public static void Main(string[] args)
        {
            Console.WriteLine("starting up the program");
            string curPlace = Directory.GetCurrentDirectory();
            DirectoryInfo diract = new DirectoryInfo(curPlace);
            Console.WriteLine("curent location found");
            var files = diract.GetFiles("*.bin");
            var name = "database" + ".bin";
            var fileName = Path.Combine(diract.FullName, name);
            var file = new FileInfo(fileName);
            Console.WriteLine("filepath generated");
            Data rides;
            Console.WriteLine("variables initiated");
            if (file.Exists)
            {
                Console.WriteLine("file exists");
                rides = new Data();
            }
            else
            {
                Console.WriteLine("generating file");
                rides = new Data(new object[0]);
            }
            Console.WriteLine("done");
            string startingInput = Console.ReadLine();
            if (startingInput.ToLower() == "test")
            {

                Ride ride = new Ride(new Date(1, 6, 2019), new Time(13, 30), new Vehicle("bus", new Price("€", 5, 12), new Price("€", 1, 55)), "spectrum");
                Console.WriteLine(ride.getStartingDate("day") + " " + ride.getStartingTime("min") + " from: " + ride.getStartingPlace());
                Console.ReadLine();
            }
            else
            {
                bool keepGoing = true;
                while (keepGoing)
                {
                    Console.Clear();
                    Console.WriteLine("add: to add a new ride");
                    Console.WriteLine("edit: to edit a ride");
                    Console.WriteLine("delete: to delete a ride");
                    Console.WriteLine("start: to start a ride");
                    Console.Write("enter 'add', 'edit', 'delete' or 'start': ");
                    string input = Console.ReadLine().ToLower();
                    if (input == "add")
                    {
                        Console.Write("year: ");
                        int year = Int32.Parse(Console.ReadLine());
                        Console.Write("month: ");
                        int month = Int32.Parse(Console.ReadLine());
                        Console.Write("day: ");
                        int day = Int32.Parse(Console.ReadLine());
                        Console.Write("hour: ");
                        int hour = Int32.Parse(Console.ReadLine());
                        Console.Write("min: ");
                        int min = Int32.Parse(Console.ReadLine());
                        Console.Write("from: ");
                        string fromWhere = Console.ReadLine();
                        Ride ride = new Ride(new Date(day, month, year), new Time(hour, min), new Vehicle("bus", new Price("€", 5, 12), new Price("€", 1, 55)), fromWhere);
                        Console.WriteLine(ride.getStartingDate("day") + " " + ride.getStartingTime("min") + " from: " + ride.getStartingPlace());
                        Console.Write("press 'enter' to continu");
                        rides.add(ride);
                        Console.ReadLine();
                        Console.Clear();
                    }
                    else if(input == "edit")
                    {

                    }
                    else if (input == "delete")
                    {

                    }
                    else if (input == "start")
                    {

                    }
                    else
                    {
                        rides.save(rides);
                        object[] database = rides.getData();
                        int length = database.Length;
                        for (int i = 0; i < length; i++)
                        {
                            if (database[i] != null)
                            {
                                Console.WriteLine(database[i]);
                            }
                        }
                        Console.ReadLine();
                        keepGoing = false;
                    }
                }
            }
        }
    }
}
