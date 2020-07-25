using System;

namespace CodeBlog_1
{
    public class Person
    {

        public string Name { get; set; }
        public string SecondName { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public string FullName
        {
            get
            {
                return SecondName + " " + Name;
            }
        }
        public string ShortName
        {
            get
            {
                return $"{SecondName} {Name.Substring(0, 5)}";
            }
        }
        public Person(string secondName, string name)
        {
            SecondName = secondName;
            Name = name;

            X = 0;
            Y = 0;
        }

        public string Run()
        {
            var rnd = new Random();

            X += rnd.Next(-2, 2);
            Y += rnd.Next(-2, 2);

            return $"{Name} ({X},{Y})";
        }

        public string RunToPosition(int x, int y)
        {
            X += x;
            Y += y;

            return $"{Name} ({X},{Y})";
        }
        public string RunToPosition(int x)
        {
            return $"{Name} ({x},{Y})";
        }
        public string RunToPosition(double y)
        {
            return $"{Name} ({X},{y})";
        }
    }
}
