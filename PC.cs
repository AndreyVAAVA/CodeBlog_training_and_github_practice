using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBlog_1
{
    class PC : IComponents
    {
        public int GraphicsCard { get; set; }
        public int CPU { get; set; }
        public int RAM { get; set; }
        public int DriveDevice { get; set; }
        public int Motherboard { get; set; }
        public int PowerSupply { get; set; }
        public int Cooler { get; set; }
    }
}
