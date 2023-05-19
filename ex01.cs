using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mentoria_TI_ibbv
{
    public class ex01 {
        static void Teste2(string[] args) {
            int num1, num2;
            System.Console.Write("Numero 1: ");
            num1 = int.Parse(Console.ReadLine()!);
            System.Console.Write("Numero 2: ");
            num2 = int.Parse(Console.ReadLine()!);

            System.Console.WriteLine(num1 + num2);
        }
    }
}