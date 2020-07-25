using System;


namespace CodeBlog_1
{
    public class Customer : Person
    {
        public int ID { get; set; }
        public Customer(string secondName, string name, int id) : base(secondName, name)
        {
            ID = id;
        }
    }
}
