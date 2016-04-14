using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationInheritance
{

    //create a very simple class called Employee with a few fields.
    //class Employee is the parent of class Fortune Teller. 

    class Employee
    {
        public virtual int EmployeeAge { get; set; } = 21;
        public virtual int EmployeeHeight { get; set; } = 60;
        public virtual int EmployeeWeight { get; set; } = 200;

        //a simple method to prove class Employee is up and running.

        public void PrintEmployeeDetails()
        {
            Console.WriteLine("Employee is " + EmployeeAge + " years old, " + EmployeeHeight + " inches tall, and " + EmployeeWeight + " pounds in weight.");
        }

    }
}
