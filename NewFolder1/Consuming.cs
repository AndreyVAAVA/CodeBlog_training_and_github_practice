using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBlog_1.NewFolder1
{
    public class Consuming<T>
    where T : Component
    {
        public double TDP_Perf { get; private set; }
        public double Perf_per_Watt(T component)
        {
            TDP_Perf = (component.PowerConsuming * component.SIZE) / component.Price;
            return TDP_Perf;
        }
    }
}
