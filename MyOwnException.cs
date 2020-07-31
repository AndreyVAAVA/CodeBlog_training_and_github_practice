using System;

namespace CodeBlog_1
{
    class MyOwnException : DivideByZeroException
    {
        public MyOwnException() : base("MyException")
        {
            Console.WriteLine("yes");
        }

        public MyOwnException(string message) : base(message)
        {
        }
    }
}
