using System;

namespace CodeBlog_1
{
    public abstract class Product
    {
        public string Name { get; set; }
        // Калорийность на 100 гр продукта
        public int Calorie { get; set; }
        //Объём в граммах
        public int Volume { get; set; }
        
        public double Energy
        {
            get
            {
                return Volume / 100.0 * Calorie;
            }
        }

        public Product(string name, int calorie, int volume)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (calorie < 0)
            {
                throw new ArithmeticException(nameof(calorie));
            }
            if (volume <= 0)
            {
                throw new ArithmeticException(nameof(volume));
            }
            Name = name;
            Calorie = calorie;
            Volume = volume;
        }

        public override string ToString()
        {
            return $"{Name}. Калорийность{Calorie}, Объём{Volume}";
        }
    }
}
