using System;

namespace CodeBlog_1
{
    class BMWXSeven : ICar
    {
        public int Move(int distance)
        {
            return distance / 100;
        }
    }
}
