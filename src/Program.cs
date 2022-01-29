using System;
using JogoHeroiDIO.src.Entities;


namespace estudo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus", 2, "Knight"); 
            Ninja wedge = new Ninja("Wedge", 42, "Ninja");
            WhiteWizard jennica = new WhiteWizard("Jennica", 23, "Knight");
            BlackWizard topapa = new BlackWizard("Topapa", 42, "Black Wizard");
            

            Console.WriteLine(arus.Attack());
            Console.WriteLine(wedge.Attack(113));
            Console.WriteLine(jennica.Attack(10));
            Console.WriteLine(topapa.Attack(2));
        }
    }
}
