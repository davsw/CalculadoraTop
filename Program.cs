using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraTop.ConsoleApp

{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {

                Console.Clear();

                Console.WriteLine("Calculadora top 2023\n");

                Console.WriteLine("Digite 1 para somar");
                Console.WriteLine("Digite 2 para subtrair");
                Console.WriteLine("Digite 3 para multiplicar");
                Console.WriteLine("Digite 4 para dividir");
                Console.WriteLine("Digite 5 para gerar tabuada");
                Console.WriteLine("Digite S para sair");

                string operacao = Console.ReadLine();

                if (operacao == "S" || operacao == "s")
                {
                    break;
                }

                if (operacao != "1" && operacao != "2" && operacao != "3" && operacao != "4" && operacao != "5" && operacao != "S")
                {
                    Console.WriteLine("Operação inválida, tente novamente...");
                    Console.ReadLine();
                    continue;

                }

                Console.WriteLine();

                Console.WriteLine("Digite o primeiro número: ");

                decimal numeroUm = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Digite o segundo número: ");

                decimal numeroDois = Convert.ToDecimal(Console.ReadLine());

                decimal resultado = 0;

                switch (operacao)
                {
                    case "1": resultado = numeroUm + numeroDois; break;
                    case "2": resultado = numeroUm - numeroDois; break;
                    case "3": resultado = numeroUm * numeroDois; break;
                    case "4":

                        { 
                        
                        while (numeroDois == 0)
                            {

                                Console.WriteLine("Segundo número não pode ser ZERO, tente novamente.");
                                Console.ReadLine();
                                Console.WriteLine("Digite o segundo número: ");

                                numeroDois = Convert.ToInt32(Console.ReadLine());
                            }
                        
                        
                        }
                        resultado = numeroUm / numeroDois; break;

                       

                        
                }
                

                bool adicao = operacao == "1";
                bool subtracao = operacao == "2";
                bool multiplicacao = operacao == "3";
                bool divisao = operacao == "4";

                if (operacao == "1")
                {
                    resultado = numeroUm + numeroDois;
                }

                else if (operacao == "2")
                {
                    resultado = numeroUm - numeroDois;

                }

                else if (operacao == "3")
                {
                    resultado = numeroUm * numeroDois;
                }

                else if (operacao == "4")
                {
                    resultado = numeroUm / numeroDois;

              
                }

                decimal formatado = Math.Round(resultado, 2);

                Console.WriteLine("O resultado da operação é: " + formatado);

                Console.ReadLine();

                if (operacao == "5")
                {
                    Console.Write("Digite o número para gerar tabuada: ");

                    int tabuada = Convert.ToInt32(Console.ReadLine());


                    // tabuada não ta funcionado.. pq?

                    for (int numero = 0; numero <= 10; numero++)
                    {
                        int resultadoMultiplicacao = tabuada * numero;
                        Console.WriteLine(tabuada + " x " + numero + " - " + resultadoMultiplicacao);

                    }

                   
                 
                    }
                    Console.ReadLine();
                    continue;

                
                
            }

            while (true);

        }

    }
}