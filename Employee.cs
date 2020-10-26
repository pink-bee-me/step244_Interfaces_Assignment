using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using step244_Interface_Assignment;
using step244_Interfaces_Assignment;

namespace step44_Interface_Assignment
{
    public class Employee : Person, IQuittable, IUserInput

    {
        public Employee()
        {
        }

        public Employee(string firstName, string lastName)
        {

        }

        public Employee(int employeeID, string FirstName, string LastName, string ActiveStatus, DateTime entryDate)
        {
            this.EmployeeID = employeeID;
            this.FirstName = " ";
            this.LastName = " ";
            this.ActiveStatus = " ";
            this.EntryDate = entryDate;
            this.CreateEmployeeID();
            this.EmployeeEntry();
            this.GetName();
            this.Quit();
        }

        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ActiveStatus { get; set; }
        public DateTime EntryDate { get; set; }


        public int CreateEmployeeID()
        {
            List<Employee> employees = new List<Employee>();


            Console.WriteLine("Employee Status: (Enter 1 for \"new\"; 2 for \"existing\")");
            string employeeEntryNewOrNot = Console.ReadLine();
            int i = 1;
            if (employeeEntryNewOrNot == "1")
            {
                EmployeeID = i;
                i++;
                string ActiveStatus = "Active";
                Console.WriteLine("\n New Employee ID: " + EmployeeID + "\n Employee Status: " + ActiveStatus);
            }
        }

        public void EmployeeEntry()
        {
            var entryDate = DateTime.Now;
            Console.WriteLine("\n Entry Date: " + entryDate);
        }

        public void GetName()
        {

            Console.WriteLine("Enter Employee Fist Name: ");
            string FirstName = Console.ReadLine();

            Console.WriteLine("Enter Employee Last Name: ");
            string LastName = Console.ReadLine();

            SayName();
        }

        public override void SayName()
        {
            var fullName = FirstName + " " + LastName;
            Console.WriteLine(fullName + " has been entered into the system");
        }




        //    new Employee(){EmployeeID,firstName,lastName, activeStatus, entryDate}
        //  }

        public void Quit()
        {
            Console.WriteLine("Is " + FirstName + " " + LastName +
                              " a current employee?\n Enter 1 for \"yes\" or 2 for \"no\"");
            string trueOrFalse = Console.ReadLine();
            if (trueOrFalse == "1")
            {
                string activeEmployee = "Employee Status : Active";
                Console.WriteLine(activeEmployee);

            }
            else
            {
                Console.WriteLine("Employee Status: Not Active");
            }

            Console.ReadLine();
        }
    }
}


