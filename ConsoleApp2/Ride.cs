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
        private Time startingTime;
        private Vehicle vehicle;
        private string startingPlace;

        public Ride(Date startingDate, Time startingTime, Vehicle vehicle, string startingPlace)
        {
            this.startingDate = startingDate;
            this.startingTime = startingTime;
            this.vehicle = vehicle;
            this.startingPlace = startingPlace;
        }
        public String getStartingDate(string precition)
        {
            if(precition.ToLower() == "month")
            {
                return startingDate.getMonth() + "-" + startingDate.getYear();
            }else if(precition.ToLower() == "year")
            {
                return "" + startingDate.getYear();
            }
            else
            {
                return startingDate.getDay() + "-" + startingDate.getMonth() + "-" + startingDate.getYear();
            }
        }
        public Date getStartingDate()
        {
                return startingDate;
        }
        public Time getStartingTime()
        {
            return startingTime;
        }
        public String getStartingTime(string precition)
        {
            if (precition.ToLower() == "hour")
            {
                return startingTime.getHour() + "";
            }
            else if (precition.ToLower() == "min")
            {
                return startingTime.getHour() + ":" + startingTime.getMin();
            }
            else
            {
                return startingTime.getHour() + ":" + startingTime.getMin() + ":" + startingTime.getSec();
            }
        }
        public Vehicle getVehicle()
        {
            return vehicle;
        }
        public String getStartingPlace()
        {
            return startingPlace;
        }
    }
}
