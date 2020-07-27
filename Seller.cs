using System;


namespace CodeBlog_1
{
    public class Seller : Human
    {
        private int salary = 0;
        private int ID;
        public int PC_price;
        public int Setup_price;

        public Seller(string secondName, string name, int id, int PC_price, int Setup_price) : base(secondName, name)
        {
            ID = id;
            this.PC_price = PC_price;
            this.Setup_price = Setup_price;

        }

        public int SalaryCount(int Salary)
        {
            salary = (Salary / 10)*2;
            this.salary = salary;
            return salary;
        }

        public static int operator +(Seller seller1, Seller seller2)
        {
            var salary = seller1.salary + seller2.salary;

            return salary;
        }
        public static int operator -(Seller seller1, Seller seller2)
        {
            var salary = seller1.salary + seller2.salary;

            return salary;
        }
        public static bool operator ==(Seller apple1, Seller apple2)
        {
            return apple1.salary == apple2.salary;
        }
        public static bool operator !=(Seller seller1, Seller seller2)
        {
            return seller1.salary != seller2.salary;
        }
        public static bool operator <(Seller seller, Seller seller2)
        {
            return seller.salary < seller2.salary;
        }
        public static bool operator >(Seller seller, Seller seller2)
        {
            return seller.salary > seller2.salary;
        }

    }
}
