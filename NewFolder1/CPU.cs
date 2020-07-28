using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBlog_1.NewFolder1
{
    public class CPU : Component
    {
        public int COREs { get; private set; }
        public CPU(string Vendor, int Price, int SIZE, int PowerConsuming, int COREs) : base(Vendor, Price, SIZE, PowerConsuming)
        {
            this.COREs = COREs;
        }
    }
}
