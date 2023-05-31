using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarefa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vet2;
            int t;
            float media = 0;
            Random rand = new Random();
            Console.WriteLine("entre com o tamanho");
            t = int.Parse(Console.ReadLine());
            vet2 = new int[t];


            for (int i = 0; i < t; i++) ;
            {
                vet2[i] = rand.Next(10, 50);
                media = vet2[i] + media;
            }
            media = media / (float)t;
            Console.WriteLine("a media é" + media);

            for (int i = 0; i < t; i++)
            {
                Console.Writeline(vet2[i]);
            }

            Console.ReadKey();

            int[] vetor3;
            int t;



            int somapar = 0, somaimpar = 0;
            Random rand = new Random();
            Console.WriteLine("entre com  o tamanho");
            t = int.Parse(Console.ReadLine());
            vetor3 = new int[t];



            for (int i = 0; i < t; i++)
            {
                vetor3[i] = rand.Next(10, 50);



                if (vetor3[i] % 2 == 0)
                {
                    somapar = vetor3[i] + somapar;
                }
                else
                {
                    somaimpar = vetor3[i] + somaimpar;
                }



            }
            for (int i = 0; i < t; i++)
            {
                Console.WriteLine(vetor3[i]);



            }
            Console.WriteLine(" a soma dos numeros pares é " + somapar);
            Console.WriteLine(" a soma dos numeros impares é " + somaimpar);



            Console.ReadKey();

        }
        public static void Exercicio3()
        {

            int[] vet2;
            Console.WriteLine("entre com o tamanho");
            int t = int.Parse(Console.ReadLine());

            vet2 = new int[t];
            Random rand = new Random();

            for (int i = 0; i < t; i++)
            {
                vet2[i] = rand.Next(10, 50);


            }
            for (int i = 0; i < t; i++)
            {
                Console.WriteLine("posição [{0}] = {1}", i, vet2[i]);


            }
            Console.WriteLine();
            for (int i = t - 1; i >= 0; i--)
            {

                Console.WriteLine("posição [{0}] = {1}", i, vet2[i]);


            }


            Console.ReadKey();
        }
        public static void Exercicio4()
        {
            float media = 0;
            int[] vet2;
            Console.WriteLine("entre com o tamanho");
            int t = int.Parse(Console.ReadLine());

            vet2 = new int[t];
            Random rand = new Random();

            for (int i = 0; i < t; i++)
            {
                vet2[i] = rand.Next(10, 50);


            }
            for (int i = 0; i < t; i++)
            {
                Console.WriteLine("posição [{0}] = {1}", i, vet2[i]);
                if (vet2[i] % 3 == 0 && vet2[i] % 5 == 0)
                {
                    media = vet2[i] + media;
                }


            }

            media = media / (float)t;
            Console.WriteLine("a media aridimentica é" + media);

            Console.ReadKey();
        }


        static void Main(string[] args)
        {
            int opcao;
            Console.WriteLine("==================menu=================");
            Console.WriteLine("para sair digite 0");
            Console.WriteLine("para executar o exercicio 1 - digite 1");
            Console.WriteLine("para executar o exercicio 2 - digite 2");
            Console.WriteLine("para executar o exercicio 3 - digite 3");
            Console.WriteLine("para executar o exercicio 4 - digite 4");
            Console.WriteLine("======================================");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Exercicio1();
                    break;
                case 2:
                    Exercicio2();
                    break;
                case 3:
                    Exercicio3();
                    break;
                case 4:
                    Exercicio4();
                    break;
                default:
                    Console.WriteLine("o numero não é um exercicio valido");
                    break;


            }
        }
    }

