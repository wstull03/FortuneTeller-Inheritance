using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationInheritance
{
    //class Customer is a stand alone class with no parents and no children.

    class Customer
    {
        public virtual int CustomerAge { get; set; } =33;
        public virtual int CustomerHeight { get; set; } = 72;
        public virtual int CustomerWeight { get; set; } = 135;

        //a simple method to prove class Customer is up and running.

        public void PrintCustomerDetails()
        {
            Console.WriteLine("Customer is " + CustomerAge + " years old, " + CustomerHeight + " inches tall, and " + CustomerWeight + " pounds in weight.");
        }
    }
}
