﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeBlog_1
{
    partial class Program
    {

        static void Main(string[] args)
        {
            var eating = new Eating<Apple>();

            /*var p = new Product<int>("Apple", 100, 100);
            var pp = new Product<decimal>("Banan", 10.1M, 11.1M);*/

            var list = new List<int>();
            var map = new Dictionary<int, string>();
            map.Add(5, "Fifth");
        }
    }
}
