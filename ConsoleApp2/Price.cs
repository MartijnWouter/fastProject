using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Price
    {
        private string unit;
        private int full;
        private int partial;
        public Price(string unit, int full, int partial)
        {
            this.unit = unit;
            this.full = full;
            this.partial = partial;
        }
        public Price(int full, int partial)
        {
            unit = "€";
            this.full = full;
            this.partial = partial;
        }
    }
}
