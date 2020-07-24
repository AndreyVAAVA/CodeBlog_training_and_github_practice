using System;

namespace CodeBlog_1
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.FirstName = "Vadim";
            person.SecondName = "Java";

            Person person2 = new Person();
            person2.FirstName = "Fedora";
            person2.SecondName = "Raspberry Pi";

            var doctor = new Doctor();
            doctor.FirstName = "Roman";
            doctor.Specialization = "333";
            Console.WriteLine(doctor.FirstName);
            Console.WriteLine(doctor.Specialization);

            Person p = doctor;
            Console.WriteLine(p.FirstName);

            var dd = (Doctor)p;
            Console.WriteLine(dd.FirstName);
            Console.WriteLine(dd.Specialization);

        }
    }
}
