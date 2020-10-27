using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using step244_Interface_Assignment;
using step244_Interfaces_Assignment;

namespace step244_Interface_Assignment
{
    public class Employee : Person, IQuittable, IUserInput

    {
        

        public Employee()
        {
        }

        public Employee(string firstName, string lastName)
        {

        }
          
        public Employee(string employeeID, string firstName, string lastName, string fullName, string activeStatus, string dateOfEntry)
        {
            this.EmployeeID = employeeID;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.FullName = fullName;
            this.ActiveStatus = activeStatus;
            this.DateOfEntry = dateOfEntry;
        }


        public string EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ActiveStatus { get; set; }
        public string DateOfEntry { get; set; }
        public string FullName { get; set; }


       

        public void CreateEmployeeID()
        {


            Console.WriteLine("Employee Status: (Enter 1 for \"New Employee\"; Enter 2 for \"NOT New Employee\"; Enter 3 for \"I Don't Understand The Question...\")"); 
            string employeeEntryNewOrNot = Console.ReadLine();


            int i = 1;
            if (employeeEntryNewOrNot == "1")
            {

                string activeStatus = "Active";
                string employeeID = Convert.ToString(i);
               
                Console.WriteLine("\n New Employee Successfully Added To DataBase: \n\n Employee Name:" + fullName + "\n Employee ID#: " + employeeID + "\n Employee Status: " + activeStatus);
                Console.ReadLine();
                i++;
            }
            else if (employeeEntryNewOrNot == "2")
            {
                Console.WriteLine("Search Employee DataBase:\n\n You can search by ID# or Name \n\n Enter ID#:(if unknown, press <Enter>)");
                string employeeSearchByID = Console.ReadLine();
               
                Console.WriteLine(" Enter Employee First Name: ");
                string employeeSearchFirstName = Console.ReadLine();
              
                Console.WriteLine(" Enter Employee Last Name: ");
                string employeeSearchLastName = Console.ReadLine();
               
                Console.WriteLine("\n\n\n  Search Feature Under Construction... Coming Soon !");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("I'm Not Sure We Can Help You... Live Green!!! Have A Nice Day!!!!!");
                Console.ReadLine();
            }
        }

        public void EmployeeDateOfEntry()
        {
            string dateOfEntry = DateTime.Now.ToString("yyyy mm dd");
            Console.WriteLine("\n Entry Date: " + dateOfEntry);
            Console.ReadLine();
        }

        public void PrintEmployees()
        {
            Console.WriteLine();
        }





        public override void SayName()
        {

            Console.WriteLine("Enter Employee Fist Name: ");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter Employee Last Name: ");
            string lastName = Console.ReadLine();

            fullName = firstName + " " + lastName;

            Console.WriteLine(fullName + " has been entered into the system");
            Console.ReadLine();
        }



        public void Quit()
        {
            Console.WriteLine("Is " + fullName + " a current employee?\n Enter 1 for \"yes\" or 2 for \"no\"");
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

   
