using System;

namespace CodeBlog_1
{
    class MyOwnException : Exception
    {
        public MyOwnException() : base("this is my exception")
        {
        }
        public MyOwnException(string message) : base(message)
        {

        }
    }
}
