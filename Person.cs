using System;

namespace CodeBlog_1
{
    class Person
    {

        public string Name { get; set; }
        public string SecondName { get; set; }
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
            SecondName= secondName;
            Name = name;
        }
    }
}
