using System;
using System.Reflection;
using System.Security.Principal;

namespace outKeyWord
{
    class student
    {
        public int sid;
        public string sname;
        public string sdept;
        public static void Main(String[] abc)
        {
            student s1 = new student();
            Console.WriteLine("Get the student details(sid,sname,sdep) using out keyword.");
            getStudentDetails(out s1.sid, out s1.sname, out s1.sdept);
            Console.WriteLine("Student ID : " + s1.sid);
            Console.WriteLine("Student Name : " + s1.sname);
            Console.WriteLine("Student Department : " + s1.sdept);
        }
        public static void getStudentDetails(out int sid,out string sname,out string sdept)
        {
            sid = 1;
            sname = "Shrikanth";
            sdept = "CSE";
        }
    }
 
}
