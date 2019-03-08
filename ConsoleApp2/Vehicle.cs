using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    [Serializable]
    public class Vehicle
    {
        private string type;
        private Price startingPrice;
        private Price pricePerKM;
        public Vehicle(string newType, Price startingPrice, Price pricePerKM)
        {
            if (newType == "car" || newType == "bus")
            {
                type = newType;
            }
            else
            {
                type = "car";
            }
            this.startingPrice = startingPrice;
            this.pricePerKM = pricePerKM;
        }
        public string getType()
        {
            return type;
        }
    }
}
