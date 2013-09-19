using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prova
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prova per GIT");
            //Console.ReadLine();

            Assistito myAssisitito = new Assistito
                {
                    Nome = "Diego Medici"
                };

            Console.WriteLine("Nome Assistito {0}", myAssisitito.Nome);

            Console.ReadLine();


        }
    }
}
