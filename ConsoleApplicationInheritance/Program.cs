using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //our game will start here
            //let's create a fortune teller
            FortuneTeller fortuneTeller = new FortuneTeller();
            CrystalBall crystalBall = new CrystalBall();

            //Instantiate the new classes to be able to call the below methods.

            NotMagic notMagic = new NotMagic();
            Customer customer = new Customer();
            Employee employee = new Employee();

            fortuneTeller.Greet(); //say hi
            fortuneTeller.StartService((Service)crystalBall);

            string clientfavoriteColor = favoriteColor();
            string clientCherishedObject = cherishedObject();
            string myPhrase = "you will lose a " + clientCherishedObject + " in a haze of " + clientfavoriteColor + " surrounding you.";
            crystalBall.CreatePhrases(myPhrase);

            //call some simple methods to verify changes to Mel's code.

            Console.WriteLine();
            notMagic.CutHair();
            notMagic.PaintNails();
            customer.PrintCustomerDetails();
            employee.PrintEmployeeDetails();
            fortuneTeller.PrintFortuneTellerDetails();
            Console.WriteLine();

            crystalBall.Work();
            crystalBall.Show();
            crystalBall.StateEffectiveness();
            fortuneTeller.Farewell();
        }

        static public string favoriteColor()
        {
            Console.WriteLine("What is your favorite color?");
            string favoriteColor = Console.ReadLine();
            //this.FavoriteColor = favoriteColor;
            return favoriteColor;
        }

        static public string cherishedObject()
        {
            Console.WriteLine("What is your most cherished object?");
            string cherishedObject = Console.ReadLine();
            // this.CherishedObject = cherishedObject;
            return cherishedObject;

        }
    }


}
