using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class ItalianChef : Chef  // inheritance with colon
    {
        //can do everything the normal chef can do so inherit everything plus own skills 


        public void MakePasta()
        {
            Console.WriteLine ("The chef makes pasta");
        }

        public override void MakeSpecialDish() //override is for overiding the chef cooks bbq ribs but the italian chef has a different special dish 
        {
            Console.WriteLine("The chef makes beef ravioli");
        }



    }
}
