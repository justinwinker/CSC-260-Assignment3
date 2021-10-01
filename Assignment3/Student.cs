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
        private double _gpa;
        public string log;
        public bool privacyFilter;
        public static int id_count = 0;
        public static int stud_count = 0;

        public Student()
        {
            stud_count++; // Update student count variable for each new student created.
            id_count++; // Update id count variable for each id generated automatically.
            Id = id_count; // Set new ID equal to the new ID generated above.
            Console.WriteLine("\nCreating student with ID: {0}", Id); // Inform user of ID just created.
            Console.WriteLine("Enter student's Name:");
            Name = Console.ReadLine();
            Console.WriteLine("Enter student's Major:");
            Major = Console.ReadLine();
            //Populates additional details automatically for simplicity. 
            Console.WriteLine("Populating additional details automatically.");
            StartDate = DateTime.Parse("08/20/2018");
            ExpGradDate = DateTime.Parse("05/18/2023");
            GPA = 3.5;
            State = "SD";
            Country = "US";
            EmailAddress = "justin.winker@trojans.dsu.edu";
            PhoneNumber = "605-555-9058";
            MailingAddress = "100 S Main Ave, Sioux Falls, SD 57103";
        }

        public Student(int val)
        {
            stud_count++; // Update student count variable for each new student created.
            Id = val; // Set new ID equal to the ID provided by the program user.
            Console.WriteLine("\nCreating student with ID: {0}", Id);
            Console.WriteLine("Enter student's Name:");
            Name = Console.ReadLine();
            Console.WriteLine("Enter student's Major:");
            Major = Console.ReadLine();
            //Populates additional details automatically for simplicity. 
            Console.WriteLine("Populating additional details automatically.");
            StartDate = DateTime.Parse("08/20/2018");
            ExpGradDate = DateTime.Parse("05/18/2023");
            State = "SD";
            GPA = 4.5;
            Country = "US";
            EmailAddress = "justin.winker@trojans.dsu.edu";
            PhoneNumber = "605-555-9058";
            MailingAddress = "100 S Main Ave, Sioux Falls, SD 57103";
        }

        public int Id
        {
            get { return (int)id; }
            set { if (id == null) //If id is not already set, do not allow user to change it. 
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
            get { if (privacyFilter == true)
                {
                    return "Hidden";
                }
                else { return _major; }
            }
            set 
            { 
                _major = value;
                log += DateTime.Now.ToString() + " - Set Major to " + Major + "\n";
            }
        }

        public DateTime StartDate
        {
            get {

                if (privacyFilter == true)
                {
                    return DateTime.Parse("00-00-0000");
                }
                else { return _startDate; }
            }
            set 
            { 
                _startDate = value;
                log += DateTime.Now.ToString() + " - Set School Start Date to " + StartDate + "\n";
            }
        }

        public DateTime ExpGradDate
        {
            get { 
                if (privacyFilter == true)
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
                log += DateTime.Now.ToString() + " - Set Anticipated Graduation Date to " + ExpGradDate + "\n";
            }
        }

        public string State
        {
            get { 
                if (privacyFilter == true)
                {
                    return "Hidden";
                }
                else { return _state; }                
                }
            set 
            { 
                _state = value;
                log += DateTime.Now.ToString() + " - Set State to " + State + "\n";
            }
        }

        public double GPA
        {
            get
            {
                if (privacyFilter == true)
                {
                    return 0.0;
                }
                else { return _gpa; }
            }
            set
            {
                if (value > 4.0)
                {
                    _gpa = 4.0;
                }
                else if (_gpa < 0.0)
                {
                    _gpa = 0.0;
                }
                else
                {
                    _gpa = value;
                }
                log += DateTime.Now.ToString() + " - Set GPA to " + GPA + "\n";
            }
        }

        public string Country
        {
            get {
                if (privacyFilter == true) { return "Hidden"; }
                else { return _country; }
            }
            set 
            { 
                _country = value;
                log += DateTime.Now.ToString() + " - Set Country to " + Country + "\n";
            }
        }

        public string EmailAddress
        {
            get { if (privacyFilter == true) { return "Hidden"; }
                else { return _emailAddress; }
            }
            set
            {
                _emailAddress = value;
                log += DateTime.Now.ToString() + " - Set email to " + EmailAddress + "\n";
            }
        }
        public string PhoneNumber
        {
            get { 
                if (privacyFilter == true)
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
                log += DateTime.Now.ToString() + " - Set Phone Number to " + PhoneNumber + "\n";
            }
        }

        public string MailingAddress
        {
            get {     
                if (privacyFilter == true)
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
                log += DateTime.Now.ToString() + " - Set Mailing Address to " + MailingAddress + "\n";
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
                Console.WriteLine( details + "\n");
            }
            else
            {
                details += "\nStudent Major: " + Major;
                details += "\nStudent GPA: " + GPA;
                details += "\nStudent Start Date: " + StartDate;
                details += "\nStudent Anticipated Graduation Date: " + ExpGradDate;
                details += "\nStudent Home State: " + State;
                details += "\nStudent Home Country: " + Country;
                details += "\nStudent Email Address: " + EmailAddress;
                details += "\nStudent Phone Number: " + PhoneNumber;
                details += "\nStudent Mailing Address: " + MailingAddress;
                Console.WriteLine(details + "\n");
            }
        }

        public void Log()
        {
            Console.WriteLine(log + "\n");
        }
    }
}
