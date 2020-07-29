using System;

namespace CodeBlog_1
{
    public class Cyborg : ICar, IPerson
    {
        public void Create()
        {
            Console.WriteLine("AU");
        }

        int ICar.Move(int distance)
        {
            return distance / 100;
        }

        int IPerson.Move(int distance)
        {
            return distance / 5;
        }
    }
}
