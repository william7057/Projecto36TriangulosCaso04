using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecto36TriangulosCaso04
{
    class Program
    {
        static void Main(string[] args)
        {//Caso 4 y caso 5 modificar la variable asterico = asterico + "* ";
            string asterico = "";
            int limite = 8;
            for (int i = 1; i <= 9; i++)
            {
                for (int x = 1; x <= limite; x++) {
                    Console.Write(" ");  
                }
                limite = limite - 1;
                asterico = asterico + "* ";
                Console.Write(asterico);
                Console.WriteLine();
            }


            Console.ReadKey();


        }
    }
}
