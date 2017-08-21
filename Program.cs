using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElseIfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2;



            Console.Write("Digite um número: ");

            numero1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite outro número: ");

            numero2 = Convert.ToInt32(Console.ReadLine());

            if (numero1 > numero2)

            {

                Console.Write(numero1);

            } else if (numero1 < numero2)
            {
                Console.Write(numero2);
            } else
            {
                Console.Write("Os números são iguais.");
            }

            Console.ReadLine();
        }
    }
}
