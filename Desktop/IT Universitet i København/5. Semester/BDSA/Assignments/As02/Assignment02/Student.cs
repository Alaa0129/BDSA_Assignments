using System;

namespace Assignment02
{
    public class Student 
    {
        public int Id {get; init;}
        public string GivenName {get; set;}
        public string SurName {get; set;}
        public Status Status {get;}
        public DateTime StartDate {get; set;}
        public DateTime EndDate {get; set;}
        public DateTime GraduationDate {get; set;}
        
        Status GetStudentstatus() 
        {
            //Switch statement som tjekker den nuværende dato, hvis datoen idag er senere end gd så sæt til graduated
            var d = DateTime.Now;

            if (DateTime.Compare(d, StartDate) == 0)
            {
                return Status.New;
            }
            else if (DateTime.Compare(d, EndDate) < 0 && DateTime.Compare(d, StartDate) > 0)
            {
                return Status.Active;
            }
            else if (DateTime.Compare(d,GraduationDate) >= 0)
            {    
                return Status.Graduated; 
            }
            else
            {
                return Status.Dropout;
            }
        }

        public override string ToString() 
        {
            var print = Id + ": " + GivenName + " " + SurName + " | status: " + GetStudentstatus() + " | start date: " + StartDate + " | end date: " + EndDate + " | graduation date: " + GraduationDate + ".";
            Console.WriteLine(print);
            return print;
        }
    }

    public record ImmutableStudent(int GId, string GgivenName,string GsurName, Status Gstatus, DateTime GstartDate,DateTime GendDate,DateTime GgraduationDate);

}

