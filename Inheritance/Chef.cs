using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Chef
    {

        public void MakeChicken()
        {
            Console.WriteLine("The chef makes the chicken");
        }


        public void MakeSalad()
        {
            Console.WriteLine("The chef makes the salad");
        }


        public virtual void MakeSpecialDish() //virtual is for overiding the chef cooks bbq ribs but the italian chef has a different special dish 
        {
            Console.WriteLine("The chef makes bbq ribs");
        }






    }
}
