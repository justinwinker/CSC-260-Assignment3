using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Student
    {
        public int? id;
        public string name;
        private string _major;
        private DateTime _startDate;
        private DateTime _expGradDate;
        private string _state;
        private string _country;
        private string _emailAddress;
        private string _phoneNumber;
        private string _mailingAddress;
        public string log;
        public bool privacyFilter;
        public static int id_count = 0;
        public static int stud_count = 0;

        public Student()
        {
            stud_count++;
            id_count++;
            Id = id_count;
            Console.WriteLine("\nCreating student with ID: {0}", Id);
            Console.WriteLine("Enter student's Name:");
            Name = Console.ReadLine();
            Console.WriteLine("Enter student's Major:");
            Major = Console.ReadLine();
            Console.WriteLine("Enter student's school StartDate in MM/DD/YYYY format:");
            StartDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter student's Anticipated Graduation Date in MM/DD/YYYY format:");
            ExpGradDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter student's home State Abbreviation:");
            State = Console.ReadLine();
            Console.WriteLine("Enter student's home Country:");
            Country = Console.ReadLine();
            Console.WriteLine("Enter student's Email Address:");
            EmailAddress = Console.ReadLine();
            Console.WriteLine("Enter student's Phone Number:");
            PhoneNumber = Console.ReadLine();
            Console.WriteLine("Enter student's Mailing Address:");
            MailingAddress = Console.ReadLine();
        }

        public Student(int val)
        {
            stud_count++;
            Id = val;
            Console.WriteLine("\nCreating student with ID: {0}", Id);
            Console.WriteLine("Enter student's Name:");
            Name = Console.ReadLine();
            Console.WriteLine("Enter student's Major:");
            Major = Console.ReadLine();
            Console.WriteLine("Enter student's school StartDate in MM/DD/YYYY format:");
            StartDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter student's Anticipated Graduation Date in MM/DD/YYYY format:");
            ExpGradDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter student's home State Abbreviation:");
            State = Console.ReadLine();
            Console.WriteLine("Enter student's home Country:");
            Country = Console.ReadLine();
            Console.WriteLine("Enter student's Email Address:");
            EmailAddress = Console.ReadLine();
            Console.WriteLine("Enter student's Phone Number:");
            PhoneNumber = Console.ReadLine();
            Console.WriteLine("Enter student's Mailing Address:");
            MailingAddress = Console.ReadLine();
        }

        public int Id
        {
            get { return (int)id; }
            set { if (id == null)
                {
                    id = value;
                }
            else
                {
                    Console.WriteLine("Cannot change Student ID.\n");
                }
            }
        }

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
            }
        }

        public string Major
        {
            get { if (privacyFilter)
                {
                    return "Hidden";
                }
                else { return _major; }
            }
            set 
            { 
                _major = value;
                log += "Set Major to " + value + "\n";
            }
        }

        public DateTime StartDate
        {
            get {

                if (privacyFilter)
                {
                    return DateTime.Parse("00-00-0000");
                }
                else { return _startDate; }
            }
            set 
            { 
                _startDate = value;
                log += "Set School Start Date to " + value + "\n";
            }
        }

        public DateTime ExpGradDate
        {
            get { 
                if (privacyFilter)
                {
                    return DateTime.Parse("00-00-0000");
                }
                else
                {
                    return _expGradDate;
                }               
                }
            set 
            { 
                _expGradDate = value;
                log += "Set Anticipated Graduation Date to " + value + "\n";
            }
        }

        public string State
        {
            get { 
                if (privacyFilter)
                {
                    return "Hidden";
                }
                else { return _state; }                
                }
            set 
            { 
                _state = value;
                log += "Set State to " + value + "\n";
            }
        }

        public string Country
        {
            get {
                if (privacyFilter) { return "Hidden"; }
                else { return _country; }
            }
            set 
            { 
                _country = value;
                log += "Set Country to " + value + "\n";
            }
        }

        public string EmailAddress
        {
            get { if (privacyFilter) { return "Hidden"; }
                else { return _emailAddress; }
            }
            set
            {
                _emailAddress = value;
                log += "Set email to " + value + "\n";
            }
        }
        public string PhoneNumber
        {
            get { 
                if (privacyFilter)
                {
                    return "Hidden";
                }
                else
                {
                    return _phoneNumber;
                } 
            }
            set
            {
                _phoneNumber= value;
                log += "Set Phone Number to " + value + "\n";
            }
        }

        public string MailingAddress
        {
            get {     
                if (privacyFilter)
                {
                    return "Hidden";
                }
                else
                {
                    return _mailingAddress;
                } 
            }
            set 
            { 
                _mailingAddress = value; 
                log += "Set Mailing Address to " + value + "\n";
            }
        }

        public void Details()
        {
            string details;
            
            details = "Student ID: " + Id;
            details += "\nStudent Name: " + Name;
            details += "\nPrivacy Filter Enabled: " + privacyFilter;

            if (privacyFilter == true)
            {
                Console.WriteLine(details);
            }
            else
            {
                details += "\nStudent Major: " + Major;
                details += "\nStudent Start Date: " + StartDate;
                details += "\nStudent Anticipated Graduation Date: " + ExpGradDate;
                details += "\nStudent Home State: " + State;
                details += "\nStudent Home Country: " + Country;
                details += "\nStudent Email Address: " + EmailAddress;
                details += "\nStudent Phone Number: " + PhoneNumber;
                details += "\nStudent Mailing Address: " + MailingAddress + "\n";
                Console.WriteLine(details);
            }
        }

        public void Log()
        {
            Console.WriteLine(log + "\n");
        }
    }
}
