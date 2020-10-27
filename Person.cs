using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step244_Interface_Assignment
{
   public abstract class Person
   {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string fullName { get; set; }

        public virtual void SayName()
        {
            string fullName = firstName + " " + lastName;
            Console.WriteLine("Name of Person Added To System: " + fullName);
        }

   }
}

