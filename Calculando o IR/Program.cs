using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculando_o_IR
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variáveis 
            double SBase;
            double GRAF;

            double SB;
            double IR;
            double SL;

            Console.Clear(); //Limpando a tela
            Console.WriteLine("Digite o salário: "); //Interface 1
            Console.SetCursorPosition(23, 0); //Posição 1
            SBase = double.Parse(Console.ReadLine()); //Entrada 1

            Console.WriteLine("Digite a gratificação: "); //Interface 2
            Console.SetCursorPosition(23, 1); //Posição 2
            GRAF = double.Parse(Console.ReadLine()); //Entrada 2

            //Processo 1
            SB = GRAF + SBase;

            if(SB > 2000)
            {
                IR = SB * 0.15;
            }
            else
            {
                IR = SB * 0.11;
            }

            SL = SB - IR;
            
            //Saídas
            Console.WriteLine("Salário Base: " + SBase);
            Console.WriteLine("Salário Bruto: " + SB);
            Console.WriteLine("Imposto de Renda: " + IR);
            Console.WriteLine("Salário Líquido: " + SL);
            Console.ReadLine();
        }
    }
}
