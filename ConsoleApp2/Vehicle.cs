using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Vehicle
    {
        private string type;
        private Price price;
        public Vehicle(string newType, Price price)
        {
            if (newType == "car" || newType == "bus")
            {
                type = newType;
            }
            else
            {
                type = "car";
            }
            this.price = price;
        }
        public string getType()
        {
            return type;
        }
    }
}
