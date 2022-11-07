using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesi bilo koji broj od 1 do 3");
            int n= int.Parse(Console.ReadLine());
            switch (n)
            {
                case 1:
                    Console.WriteLine("*");
                break;

                case 2:
                    Console.WriteLine("**");
                break;

                case 3:
                    Console.WriteLine("***");
                 break;
                    default: Console.WriteLine("Niste uneli nijedan broj od 1 do 3");
                    break;
                   
            }
            Console.WriteLine("Pritisni ENTER za izlazak");
            Console.ReadLine();
        }
    }
}
