﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationInheritance
{
    //class FortuneTeller is now the child of class Employee.

    class FortuneTeller:Employee
    {
        //I'm just setting this up as a regular old class. 
        //Later, I might choose to make it in a game where I inherit from a Human class
        //(and have a customer also inherit from Human), but for our first round, this is great.

        //Properties
        public string Name { get; set; } = "Esmerelda";

        public string ExperienceLevel { get; set; }


        //Methods

        public void Greet()
        {
            Console.WriteLine("Hello! Welcome to my humble shop.");
            Console.WriteLine("Let me see what I have to offer you today.");

        }

        public void StartService(Service service)
        {
            Console.WriteLine("For you, my {0}! Yes, perfect. It only costs {1} and that's fine by everyone.", service.Name, service.Price);
        }


        public void Farewell()
        {
            Console.WriteLine("Thank you for your patronage.");
        }

        // this method will prove that as a child, class FortuneTeller has properly inherited the Fields listed it's parent, class Employee

        public void PrintFortuneTellerDetails()
        {
            Console.WriteLine("FortuneTeller is " + EmployeeAge + " years old, " + EmployeeHeight + " inches tall, and " + EmployeeWeight + " pounds in weight.");
        }

        /// <summary>
        /// Create a new fortune teller, giving it a name and experience level.
        /// </summary>
        /// <param name="name">The fortune teller's name.</param>
        /// <param name="experienceLevel">A string value (beginner, intermediate, advanced) for this fortune teller.</param>
        //Constructors
        public FortuneTeller(string name, string experienceLevel)
        {
            this.Name = name;
            this.ExperienceLevel = experienceLevel;
        }

        public FortuneTeller()
        {
        }
    }
}
