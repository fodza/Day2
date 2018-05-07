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

            
            Console.WriteLine("Kad esi dzimis?");//izvade

            String dati; // pieskirt simbolu virknei definiciju
            dati = Console.ReadLine(); //uz ekrana ieraksta dzimsanas gadu

            Console.WriteLine("Jus esat dzimis " + dati);//izvada tekstu(rezultatu) + to, kas tika ievadits uz ekrana zem "dati" 

            Console.ReadLine();
                        
        }
    }
}