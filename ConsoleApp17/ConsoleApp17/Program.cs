using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Calculator cem = new Calculator();
                Calculator cix = new Calculator();
                Calculator vur = new Calculator();
                Calculator bol = new Calculator();
                Console.WriteLine("Emeliyat Secin: ");
                var operation = Console.ReadLine();
                if (operation == "+")
                {
                    Console.Write("1 ci Eded  ");
                    var z = Convert.ToInt32(Console.ReadLine());
                    Console.Write("2 ci Eded  ");
                    var e = Convert.ToInt32(Console.ReadLine());
                    var ce = cem.Toplama(z, e);
                    Console.WriteLine("cavab: " + ce);
                }
                else if (operation == "-")
                {
                    Console.Write("1 ci Eded  ");
                    var z = Convert.ToInt32(Console.ReadLine());
                    Console.Write("2 ci Eded  ");
                    var e = Convert.ToInt32(Console.ReadLine());
                    var ce = cix.Cixma(z, e);
                    Console.WriteLine("cavab: " + ce);
                }
                else if (operation == "*")
                {
                    Console.Write("1 ci Eded  ");
                    var z = Convert.ToInt32(Console.ReadLine());
                    Console.Write("2 ci Eded  ");
                    var e = Convert.ToInt32(Console.ReadLine());
                    var ce = vur.Vurma(z, e);
                    Console.WriteLine("cavab: " + ce);
                }
                else if (operation == "/")
                {
                    Console.Write("1 ci Eded  ");
                    var z = Convert.ToInt32(Console.ReadLine());
                    Console.Write("2 ci Eded  ");
                    var e = Convert.ToInt32(Console.ReadLine());
                    var ce = bol.Bolme(z, e);
                    Console.WriteLine("cavab: " + ce);
                }
                else
                {
                    Console.WriteLine("duzgun emeliyat secin +,-,*,/");
                }

            }
            catch (Exception )
            {
                Console.WriteLine("xahis edirik yeniden cehd edin :)");
                
            }
           


        }
        class Calculator
        {
            public int Toplama(int a, int b)
            {
                return a + b;
            }
            public int Cixma(int a, int b)
            {
                return a - b;
            }
            public int Vurma(int a, int b)
            {
                return a * b;
            }
            public int Bolme(int a, int b)
            {
                return a / b;
            }
        }
    }
    }

