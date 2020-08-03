using System;
using System.Threading.Tasks;

namespace CodeBlog_1
{
    public class Perf_Calc
    {
        int cores = 5698;
        int clock = 4863;
        int bandwith = 2048;
        int vram = 8192;
        public int perf()
        {
            var total = 0;
            for (int i = 0; i < vram; i++)
            {
                total = (cores * clock) / bandwith;
                total += total;
            }
            return total;
        }
        public async Task<int> PerfAsync()
        {
            var result = await Task<int>.Run(() => perf());
            return result;
        }
    }
}
