using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationInheritance
{

    //created a class that is a sibling to class Magic

    class NotMagic : Service
    {
        public virtual string Hair { get; set; } = "hair salon";
        public virtual string Nails { get; set; } = "nail salon";

        public override string Name { get; set; } = "NotMagic Services";
        public override decimal Price { get; set; } = 100.00m;
        public override string Result { get; set; } = "Result";

        //the below methods test overwriting of Properties.  
        
        public void CutHair()
        {
            Console.WriteLine("the initial cost of your salon visit is : " + this.Price);
            this.Price = 50.00m;
            Console.WriteLine("but now, the cost of your salon visit is : " + this.Price);
            Console.WriteLine("the Name of NotMagic is : " + this.Name);
        }

        public void PaintNails()
        {
            Console.WriteLine("the initial cost of your nail treatment is : " + this.Price);
            this.Price = 200.00m;
            Console.WriteLine("but now, the cost of your nail treatment is : " + this.Price);
            Console.WriteLine("the Result of NotMagic is : " + this.Result);
        }
        

    }
}
