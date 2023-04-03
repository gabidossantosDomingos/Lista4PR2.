using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista4PR2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //exercício 1
            //int I;
            //float flo;
            //Console.WriteLine("A afirmativa do exercício 1 está errada pois não é possível atribuir valores float em valores Int");
            //Console.WriteLine("Podemos resolver esse problema aproximando o valor por meio do comando MathRound, se o número depois da vírgula fo5 <= 5 o número inteiro será o mesmo se o número depois da vírgula for > 5 somará 1 ao número inteiro");
            //flo = 24.3f;
            //I = (int)Math.Round(flo);

            //Console.WriteLine(I);
            //Console.ReadKey();


            //exercício 2
            //Console.WriteLine("ConsoleReadLine(): é responsável por ler uma linha, ou seja, todos os caracteres até que encontre um indicador de fim de linha");
            //Console.WriteLine("ConsoleRead(): é responsável por ler unicamente um caracter e retornar um inteiro indicando qual seria o caractere escolhido");

            //3 Console.WriteLine("O programa só consegue ler uma variavél se ela for a do mesmo tipo declarda inicialmente");


            //exercício 4
            //int num, num2, num3;
            //Console.WriteLine(
            //    "Entre com um número:");
            //num = int.Parse(Console.ReadLine());
            //num2 = num / 2;
            //num3 = num % 2;
            //if (num3 == 0 && num2 * 2 > 10)
            //    Console.WriteLine("Mensagem 1");
            //else
            //    Console.WriteLine("Mensagem 2");
            //Console.ReadKey();


            // Console.WriteLine("O objetivo do programa é identificar se o valor digitado é correspondente a mensagem 1 ou a mensagem 2");
            // Console.WriteLine("se digitar-se o valor 8 a saída será:mensagem2");
            // Console.WriteLine("se digitar-se o valor 27 a saída será: mensagem2");
            // Console.WriteLine("se digitar-se o valor 28 a saída será: mensagem1");

            //exercício 5
            //double posicaoInicial, time, velocidade, posicao;

            //Console.WriteLine("Digite a posição inicial desse objeto em metros");
            //posicaoInicial = double.Parse(Console.ReadLine());
            //Console.WriteLine("qual é o intervalo de tempo em segundos");
            //time = double.Parse(Console.ReadLine());
            //Console.WriteLine("Digite a velocidade em m/s:");
            //velocidade = double.Parse(Console.ReadLine());
            //posicao = posicaoInicial + velocidade * time;

            //Console.WriteLine("Sua posição final será: " + posicao + "m");

            //exercício 6
            //int o;
            //Console.WriteLine("Digite um número qualquer");
            // o = int.Parse(Console.ReadLine());

            //if (o % 3 == 0 && o % 5 == 0 && o % 10 == 0)
            //{
            //    Console.WriteLine("O valor é divisível po 3, 5 e 10");
            //}


            //else if (o % 3 == 0 && o % 5 == 0)
            //{
            //    Console.WriteLine("O valor é divisível po 3 e 5");
            //}


            // else if (o % 3 == 0) 
            //{
            //    Console.WriteLine("O valor é divisível po 3");
            //}

            //else if (o % 5 == 0 ) 
            //{
            //    Console.WriteLine("O valor é divisível po 5");
            //}

            //else
            //{
            //    Console.WriteLine("O valor não é dívisivel por 3, 5 e 10");
            //}

            // Atividade 7
            //Console.WriteLine("");

            //int km, KE = 100, distancia, diferenca;

            //Console.WriteLine("Digite o km onde sua casa está localizada: ");
            //km = int.Parse(Console.ReadLine());

            //diferenca = KE - km;

            //if (diferenca >= 0 && diferenca <= 12)
            //{
            //    Console.WriteLine("Tempo necessário: 14 minutos");
            //}
            //else if (diferenca > 12 && diferenca <= 29)
            //{
            //    distancia = 14 + 17;
            //    Console.WriteLine("O tempo necessário é de " + distancia + " minutos");
            //}
            //else if (diferenca > 29 && diferenca <= 55)
            //{
            //    distancia = 14 + 17 + 13;
            //    Console.WriteLine("O tempo necessário é de " + distancia + " minutos");
            //}
            //else if (diferenca > 55 && diferenca <= 82)
            //{
            //    distancia = 14 + 17 + 13 + 15;
            //    Console.WriteLine("O tempo necessário é de " + distancia + " minutos");
            //}
            //else if (diferenca > 82 && diferenca <= 100)
            //{
            //    distancia = 14 + 17 + 13 + 15 + 12;
            //    Console.WriteLine("O tempo necessário é de " + distancia + " minutos");
            //}
            //Console.ReadKey();

            //exercício 8
            
            //Console.WriteLine("");

            //float produto, LucroLiquido, LucroTotal;
            //string marca;
            //Console.WriteLine("=====MENU====");
            //Console.WriteLine("1- ROYAL");
            //Console.WriteLine("2- WISKAS");
            //Console.WriteLine("3- GOLDEN");
            //Console.WriteLine("4- NUTRIEN");
            //Console.WriteLine("5- SPECIALCAT");
            //Console.WriteLine("6- MARBA");
            //Console.WriteLine("7- GATUS");
            //Console.WriteLine("Digite a marca do produto: ");
            //marca = Console.ReadLine();
            //Console.WriteLine("Digite a quantidade de unidades de um produto: ");
            //produto = float.Parse(Console.ReadLine());

            //switch (marca)
            //{
            //    case "ROYAL":
            //        LucroTotal = produto * 129.50f;
            //        LucroLiquido = ((LucroTotal - (77.5f / 100)) - (33 / 100));
            //        Console.WriteLine("Valor total: " + LucroTotal + " e lucro líquido: " + LucroLiquido);
            //        break;
            //    case "WISKAS":
            //        LucroTotal = produto * 182.78f;
            //        LucroLiquido = ((LucroTotal - (89.7f / 100)) - (27.5f / 100));
            //        Console.WriteLine("Valor total: " + LucroTotal + " e lucro líquido: " + LucroLiquido);
            //        break;
            //    case "GOLDEN":
            //        LucroTotal = produto * 159.46f;
            //        LucroLiquido = ((LucroTotal - (71.7f / 100)) - (22.5f / 100));
            //        Console.WriteLine("Valor total: " + LucroTotal + " e lucro líquido: " + LucroLiquido);
            //        break;
            //    case "NUTRIEN":
            //        LucroTotal = produto * 144.80f;
            //        LucroLiquido = ((LucroTotal - (88.9f / 100)) - (25 / 100));
            //        Console.WriteLine("Valor total: " + LucroTotal + " e lucro líquido: " + LucroLiquido);
            //        break;
            //    case "SPECIALCAT":
            //        LucroTotal = produto * 205.40f;
            //        LucroLiquido = ((LucroTotal - (83.24f / 100)) - (22 / 100));
            //        Console.WriteLine("Valor total: " + LucroTotal + " e lucro líquido: " + LucroLiquido);
            //        break;
            //    case "MARBA":
            //        LucroTotal = produto * 125.10f;
            //        LucroLiquido = ((LucroTotal - (90.4f / 100)) - (17.9f / 100));
            //        Console.WriteLine("Valor total: " + LucroTotal + " e lucro líquido: " + LucroLiquido);
            //        break;
            //    case "GATUS":
            //        LucroTotal = produto * 133.99f;
            //        LucroLiquido = ((LucroTotal - (94.6f / 100)) - (20 / 100));
            //        Console.WriteLine("Valor total: " + LucroTotal + " e lucro líquido: " + LucroLiquido);
            //        break;
            //    default:
            //        Console.WriteLine("Valor inválido");
            //        break;
            //}
            //Console.ReadKey();
        }
    }
}
