using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double rezultats = Aprekins();
            tekstaIzvade();
            tekstaIzvade();
            Console.WriteLine(rezultats);
            Console.ReadLine();
                        
        }

        static void tekstaIzvade() //f-ja neatgriez vertibu
        {
            Console.WriteLine("Jus esat dzimis "); //izvada tekstu(rezultatu) + to, kas tika ievadits uz ekrana zem "dati" 
            Console.WriteLine("Git.hub tests!!! ");
        }

        static double Aprekins()//f-ja, kas atgriez vertibu 
        {
            double a = 5.4;
            double b = 6.8;
            double c = a + b;
            return c;
        }
    }
}