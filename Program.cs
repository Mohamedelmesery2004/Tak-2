using System.Diagnostics;
using System.Text;
using System.Threading;

namespace ConsoleApp43
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //student student = new student();
            //student.Grade = 10;
            //student.Age = 20;
            //student.Name = "Mohamed";

            //student.PrintDetails();

            //-----------------------------------------------

            //Employee employee = new Employee();
            //employee._ID = 1;
            //employee._Name = "Mohamed";
            //employee._Salary = 10000;
            //employee._Gender = 'M';
            //employee._SecurityLevel = SecurityPrivilegs.Developer;
            //employee._HireDate = DateTime.Now;

            //Console.WriteLine(employee);
        }


    }


    #region studentClass
    //class student
    //{
    //    public int Age { get; set; }
    //    public string Name { get; set; }
    //    public double Grade { get; set; }

    //    public void PrintDetails()
    //    {
    //        Console.WriteLine($"student name is {Name} , age {Age} , Grade {Grade}");
    //    }
    //}

    //class PostGraduate : student
    //{
    //    public string ThesisTopic { get; set; }
    //}
    #endregion

    #region Employee

    //public enum SecurityPrivilegs
    //{
    //    guest, Developer, Secrtary, DBA
    //}
    //class Employee
    //{
    //    public int _ID { get; set; }
    //    public string _Name { get; set; }
    //    public SecurityPrivilegs _SecurityLevel { get; set; }
    //    public decimal _Salary { get; set; }
    //    public DateTime _HireDate { get; set; }

    //    private char gender;
    //    public char _Gender
    //    {
    //        get
    //        { return gender; }
    //        set
    //        {
    //            if (value == 'M' || value == 'F')
    //                gender = value;
    //            else
    //                throw new ArgumentException("You Must Enter The Correct Value M or F");
    //        }
    //    }

    //    public override string ToString()
    //    {
    //        return $"ID {_ID}  | Name {_Name} | SecurityLevel {_SecurityLevel} | Salary {_Salary} | HireDate {_HireDate} | Gender {_Gender}";

    //    }
    //}
    #endregion



}
