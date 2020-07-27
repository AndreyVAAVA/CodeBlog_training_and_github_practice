using System;

namespace CodeBlog_1
{
    public class Product
    {

        public string Name { get; set; }
        // Калорийность на 100 гр продукта
        public int Energy { get; set; }
        //Объём в граммах
        public int Volume { get; set; }
        
        public double Calorie
        {
            get
            {
                return 0;/*Volume / 100.0 * Energy;*/
            }
        }

        public Product(string name, int volume, int energy)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException(nameof(name));
            }
            /*if (energy < 0)
            {
                throw new ArithmeticException(nameof(energy));
            }
            if (volume <= 0)
            {
                throw new ArithmeticException(nameof(volume));
            }*/
            Name = name;
            Volume = volume;
            Energy = energy;
        }

        public override string ToString()
        {
            return $"{Name}. Калорийность{Calorie}, Объём{Volume}";
        }
    }
}
