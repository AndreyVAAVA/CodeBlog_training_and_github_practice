using System;


namespace CodeBlog_1
{
    public class Seller : Person
    {
        private int salary = 0;
        private int ID;
        public int PC_price = 90000;

        public Seller(string secondName, string name, int id) : base(secondName, name)
        {
            ID = id;
        }

        public int SalaryCount(int Salary)
        {
            salary = (Salary / 10)*2;
            return salary;
        }

    }
}
