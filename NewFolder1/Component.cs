using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBlog_1
{
    public class Component
    {
        public string Vendor { get; private set; }
        public int Price { get; private set; }
        public int SIZE { get; private set; }
        public int PowerConsuming { get; private set; }

        public Component(string Vendor, int Price, int SIZE, int PowerConsuming)
        {
            this.Vendor = Vendor;
            this.Price = Price;
            this.SIZE = SIZE;
            this.PowerConsuming = PowerConsuming;
        }

        public Component(string vendor, int price, int sIZE)
        {
            Vendor = vendor;
            Price = price;
            SIZE = sIZE;
        }
    }
}
