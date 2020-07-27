using System;
using System.Collections;

namespace CodeBlog_1
{
    public class Eating<T>
        where T : Product
    {
        public int Volume { get; private set; }

        public void Add(T product)
        {
            Volume += product.Volume * product.Energy;
        }
    }
}
