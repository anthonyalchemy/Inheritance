using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //one class inherit all functionality of another class it superclass

            Chef chef = new Chef();//chef object
            chef.MakeChicken();
            chef.MakeSpecialDish();



            ItalianChef italianchef = new ItalianChef();
            italianchef.MakeChicken();
            italianchef.MakePasta();
            italianchef.MakeSpecialDish();


            //chef is the super class
            //italian chef is the sub class 


            Console.ReadLine();
        }
    }
}
