using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDesafiosDio
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor;
            int inteiro, auxNotas, auxMoedas;

            //multiplicado as moedas por 100 para facilitar a 
            //programacao
            double[] tipos = { 100.0, 50.0, 20.0, 10.0, 5.0, 2.0, 1.0, 0.50, 0.25, 0.10, 0.05 , 0.01 };

            valor = Convert.ToDouble(188.00); //Console.ReadLine()

            inteiro = (int)valor;
            valor *= 100;
            double valorTotal = valor/100;
            double totalNotas = 0;
            double totalMoedas;

            for (int i = 0; i < tipos.Length; i++)
            {
                if (((int)(tipos[i])) >= 2)
                {
                    auxNotas = ((int)(inteiro % tipos[i]));

                    Console.WriteLine("NOTAS:");
                    Console.WriteLine("{0} nota(s) de R$ " + (tipos[i]), (int)(inteiro / tipos[i]));
                    totalNotas = totalNotas + ((int)(inteiro / tipos[i]) * tipos[i]);

                    inteiro = auxNotas;                    
                    //Console.WriteLine("TOTAL NOTAS : "+ totalNotas);
                }
            }

            totalMoedas = (valorTotal - totalNotas) * 100;
            inteiro = (int) totalMoedas;
            //Console.WriteLine("TOTAL MOEDAS : " + totalMoedas);

            for (int i = 0; i < tipos.Length; i++)
            {
                if (((int)(tipos[i])) <= 1)
                {
                    auxMoedas = ((int)(inteiro % (tipos[i]*100)));

                    Console.WriteLine("MOEDAS:");
                    Console.WriteLine("{0} moeda(s) de R$ " + (tipos[i]), (int)(inteiro / (tipos[i]*100)));

                    //Console.WriteLine("RESTO: "+auxMoedas);

                    inteiro = auxMoedas;
                }
            }

            Console.ReadLine();
        }

        

    }
}
