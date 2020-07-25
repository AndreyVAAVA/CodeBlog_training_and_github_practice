using System;


namespace CodeBlog_1
{
    public class Customer : Person
    {
        private int Money { get; set; }
        public Customer(string secondName, string name, int money) : base(secondName, name)
        {
            Money = money;
        }

        public int PC_Buy(int price)
        {
            Money = Money - price;
            return price;
        }
        public int hm_we_have()
        {
            return Money;
        }
    }
}
