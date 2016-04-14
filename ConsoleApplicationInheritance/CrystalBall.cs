using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationInheritance
{
    class CrystalBall : Magic
    {
        //straight up field. I really don't need a property. Just using globally so random behaves well.
        private Random random = new Random();

        //properties
        protected List<string> Phrases { get; set; } = new List<string>();

        public override string Name { get; set; } = "Crystal Ball";

        public string CherishedObject { get; set; }
        public string FavoriteColor { get; set; }


        public override void Work()
        {
            base.Work();
            //now let's call a method that will get a result for the crystal ball
            this.Result = GetPhrase();

        }

        internal void CreatePhrases()
        {
           /* Phrases.Add("Night time is a dark place for you.");
            Phrases.Add("I see shiny objects in your near future");
            Phrases.Add("The decorating around you needs some help.");
    */        
    //Phrases.Add("You will lose " + this.CherishedObject + " in a " + this.FavoriteColor + " haze.");
        }

        //let's create an overloaded method now
        internal void CreatePhrases(string phrase)
        {
            Phrases.Add(phrase);
        }

        private string GetPhrase()
        {
            //local variable
            int randomNumber = random.Next(Phrases.Count);
            return Phrases.ElementAt(randomNumber);

        }

        //constructor
        //let's override some of the properties of what we inherited from magic and service here.
        public CrystalBall()
        {
            this.Price = 45.00M;
            this.PercentEffective = 65;
            this.BlackMagic = false;
            this.Expertise = "beginner";
            //I want to call my initializer for phrases.
            CreatePhrases();
        }

    }
}
