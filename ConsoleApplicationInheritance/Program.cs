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
            fortuneTeller.Greet(); //say hi
            fortuneTeller.StartService((Service)crystalBall);

            string clientfavoriteColor = favoriteColor();
            string clientCherishedObject = cherishedObject();
            string myPhrase = "you will lose a " + clientCherishedObject + " in a haze of " + clientfavoriteColor + " surrounding you.";
            crystalBall.CreatePhrases(myPhrase);

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
