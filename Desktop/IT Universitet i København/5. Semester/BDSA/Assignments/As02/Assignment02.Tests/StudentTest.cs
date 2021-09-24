using System;
using Xunit;
using Assignment02;

namespace Assignment02.Tests
{
    public class StudentTest
    {
        [Fact]
        public void Given_a_student_prints_description()
        {
            //Given
            var s1 = new Student
            {
                Id = 1,
                GivenName = "Mohammad",
                SurName = "Hasham",
                StartDate = new DateTime(2021, 09, 22, 00, 00, 00),
                EndDate = new DateTime(2024, 06, 24, 00, 00, 00),
                GraduationDate = new DateTime(2024, 06, 22, 00, 00, 00)
            };

            //When
            var expected = "1: Mohammad Hasham | status: Active | start date: 09/22/2021 00:00:00 | end date: 06/24/2024 00:00:00 | graduation date: 06/22/2024 00:00:00."; 
            var actual = s1.ToString();

            //Then
            Assert.Equal(expected, actual);
        }


        [Fact]
        public void Given_two_record_students_prints_true_if_equal()
        {
            //Given
            var s1 = new ImmutableStudent
            (
                1,
                "Mohammad",
                "Hasham",
                Status.Active,
                new DateTime(2021, 09, 22, 00, 00, 00),
                new DateTime(2024, 06, 24, 00, 00, 00),
                new DateTime(2024, 06, 22, 00, 00, 00)
            );
            var s2 = s1;
            var s3 = s1 with { GId = 3};

            //When 
            var actual = s1.Equals(s2);
            var actual2 = s1.Equals(s3);
            //Then
            Assert.True(actual);
            Assert.False(actual2);
        }

        [Fact]
        public void Given_a_record_student_prints_description()
        {
            //Given
            var s1 = new ImmutableStudent
            (
                1,
                "Mohammad",
                "Hasham",
                Status.Active,
                new DateTime(2021, 09, 22, 00, 00, 00),
                new DateTime(2024, 06, 24, 00, 00, 00),
                new DateTime(2024, 06, 22, 00, 00, 00)
            );

            //When
            var expected = "ImmutableStudent { GId = 1, GgivenName = Mohammad, GsurName = Hasham, Gstatus = Active, GstartDate = 09/22/2021 00:00:00, GendDate = 06/24/2024 00:00:00, GgraduationDate = 06/22/2024 00:00:00 }"; 
            var actual = s1.ToString();

            //Then
            Assert.Equal(expected, actual);
        }
    }
}
