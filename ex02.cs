using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mentoria_TI_ibbv
{
    public class ex02
    {
        static void Teste3(string[] args){
            string nome;
            int horas, valorHora;
            Console.Write("Nome do funcionario: ");
            nome = Console.ReadLine()!;
            Console.Write("Horas trabalhadas: ");
            horas = int.Parse(Console.ReadLine()!);
            Console.Write("Valor da hora: ");
            valorHora = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Funcionario: {0}.", nome);
            Console.WriteLine("Salario: R${0}.", horas*valorHora*20);
        }
    }
}