using System;

namespace Assignment3
{
    class Program
    {

        static void Main()
        {
        var student1 = new Student();
            var student2 = new Student(13547245)
            {
                privacyFilter = true
            };
            var student3 = new Student();
        var student4 = new Student();
            var student5 = new Student
            {
                privacyFilter = true
            };
        var student6 = new Student();
        var student7 = new Student(13547753);
            var student8 = new Student
            {
                privacyFilter = true
            };
            var student9 = new Student();
        var student10 = new Student(17325843);
            student2.EmailAddress = "newEmailAddress@gmail.com";
            student5.Country = "Brazil";
            student7.MailingAddress = "820 Washington Ave N, Madison, SD 57042";
            student8.PhoneNumber = "605-963-9958";
            student1.Details();
            student2.Details();
            student3.Details();
            student4.Details();
            student5.Details();
            student6.Details();
            student7.Details();
            student8.Details();
            student9.Details();
            student10.Details();
            student1.Log();
            student2.Log();
            student3.Log();
            student4.Log();
            student5.Log();
            student6.Log();
            student7.Log();
            student8.Log();
            student9.Log();
            student10.Log();
        }
    }
}