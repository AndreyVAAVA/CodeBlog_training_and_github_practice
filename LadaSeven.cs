using System;

namespace CodeBlog_1
{
    class LadaSeven : ICar
    {
        public int Move(int distance)
        {
            return distance / 40;
        }
    }
}
