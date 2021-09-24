using System;

namespace Assignment02
{
    class Program
    {
        static void Main(string[] args)
        {
            var s1 = new Student
            {
                Id = 1,
                GivenName = "Mohammad",
                SurName = "Hasham",
                StartDate = new DateTime(2021, 09, 22, 00, 00, 00),
                EndDate = new DateTime(2024, 06, 24, 00, 00, 00),
                GraduationDate = new DateTime(2024, 06, 22, 00, 00, 00)
            };
            var s2 = new ImmutableStudent(1,"Mohammad","Hasham", Status.Active,new DateTime(2021, 09, 22, 00, 00, 00), new DateTime(2024, 06, 24, 00, 00, 00),new DateTime(2024, 06, 22, 00, 00, 00));
            var s3 = s2;
            s3 = new ImmutableStudent(4,"Mohammad","Hasham", Status.Active,new DateTime(2021, 09, 22, 00, 00, 00), new DateTime(2024, 06, 24, 00, 00, 00),new DateTime(2024, 06, 22, 00, 00, 00));
            var s4 = s2;
            s1.ToString();
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(s2.Equals(s4));
        }
    }
}
