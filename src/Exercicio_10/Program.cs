using System;

namespace Exercicio_10
{
    class Program
    {
        static void Main(string[] args)
        {

            //ToDo - Alterar a variável INT para Decimal.

            Console.WriteLine("****************************************");
            Console.WriteLine("*********     Exercicio 10     *********");
            Console.WriteLine("****************************************");

            Console.WriteLine("");

            int Custo_Fabrica;
            int distribuidor = 28;
            int Impostos = 45;
            int Custo_Final;

            Console.Write("Informe o custo de fábrica do veúculo: R$ ");
            Custo_Fabrica = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Será acrescentado ao custo de Fábrica a porcentagem do Distribuidor e impostos.");
            Console.WriteLine($"Sendo {distribuidor} % do Distribuidor e {Impostos} % de Impostos acrescido ao valor de Fábrica.");

            Console.WriteLine("");

            Custo_Final = Custo_Fabrica + ((Custo_Fabrica * distribuidor) / 100) + ((Custo_Fabrica * Impostos) / 100);

            Console.WriteLine($"O valor total do veículo será de R$ {Custo_Final} reais.");

            Console.ReadKey();
        }
    }
}
