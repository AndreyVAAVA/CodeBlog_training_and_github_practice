using System;
using System.Collections;

namespace CodeBlog_1.NewFolder1
{
    public class RAM : Component
    {
        public decimal Latency { get; set; }
        public RAM(string Vendor, int Price, int SIZE, int PowerConsuming, decimal Latency) : base(Vendor, Price, SIZE, PowerConsuming)
        {
            this.Latency = Latency;
        }
    }
}
