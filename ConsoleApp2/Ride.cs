using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Ride
    {
        private Date startingDate;
        private int[] startingTime;
        private Vehicle vehicle;
        private string startingPlace;

        public Ride(Date startingDate, Time startingTime, Vehicle vehicle, string startingPlace)
        {
            this.startingDate = startingDate;
            this.startingTime = startingTime;
            this.vehicle = vehicle;
            this.startingPlace = startingPlace;
        }
    }
}
