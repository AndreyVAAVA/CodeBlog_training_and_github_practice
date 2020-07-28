using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBlog_1.NewFolder1
{
    public class GC : Component
    {
        public int Bandwidth { get; set; }
        public GC(string Vendor, int Price, int SIZE, int PowerConsuming, int Bandwidth) : base(Vendor, Price, SIZE, PowerConsuming)
        {
            this.Bandwidth = Bandwidth;
        }
    }
}
