using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mentoria_TI_ibbv
{
    public class ex03
    {
        static void Main(string[] args){
            int raio;
            double pi = 3.14;
            Console.Write("Raio do circulo: ");
            raio = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Area do circulo: {0}.", pi*(raio*raio));
        }
    }
}