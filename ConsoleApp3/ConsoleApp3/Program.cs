using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("                         **** CALCULATOR **** \n\nBir Emeliyat Secin \n\n1.Toplama\n2.Cixma \n3.Vurma \n4.Bolme\n");
            var a = Console.ReadLine();
            Console.WriteLine("1-ci Reqemi yazin");
            var b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2-ci Reqemi yazin");
            var c = Convert.ToInt32(Console.ReadLine());
            if (a == "Toplama")
            {
                Console.WriteLine(b+c);
            }
            else if (a == "Cixma")
            {
                Console.WriteLine(b - c);
            }
            else if(a == "Vurma")
            {
                Console.WriteLine(b * c);
            }
            else if(a == "Bolme")
            {
                Console.WriteLine(b / c);
            }
            else
            {
                Console.WriteLine("Xahis Edirik Duzgun Emeliyat  Yazin");
            }
        }
    }
}