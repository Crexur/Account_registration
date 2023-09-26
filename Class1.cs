using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account_registration
{
    internal class StudentInfoClass
    {
        public delegate void DelegateNumber(long number);
        public delegate void DelegateText(string txt);

        public static string FirstName = "";
        public static string LastName = "";
        public static string MiddleName = "";
        public static string Address = "";
        public static string Program = "";

        public static long Age = 0;
        public static long ContactNo = 0;
        public static long StudentNo = 0;

        public static string GetFirstName()
        {
            return FirstName;
        }

        public static string GetLastName()
        {
            return LastName;
        }

        public static string GetMiddleName()
        {
            return MiddleName;
        }

        public static string GetAddress()
        {
            return Address;
        }

        public static string GetProgram()
        {
            return Program;
        }

        public static long GetAge()
        {
            return Age;
        }

        public static long GetContactNo()
        {
            return ContactNo;
        }

        public static long GetStudentNo()
        {
            return StudentNo;
        }

    }
}
