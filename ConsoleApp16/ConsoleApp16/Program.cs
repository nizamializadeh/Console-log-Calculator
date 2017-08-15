using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] taxi = { 30,120,100,130, 20 };
            int[] musderi = new int[5];
            for (int i = 0; i <5; i++)
            {
                Console.WriteLine("cordinatlarinizi girin:");
                musderi[i] = Convert.ToInt16(Console.ReadLine());
                int enkicikm;
                enkicikm = Math.Abs(taxi[0] - musderi[i]);
                    for (int j = 1; j < 5; j++)
                    {
                    if (enkicikm>= Math.Abs(taxi[j] - musderi[i]))
                    {
                        enkicikm = Math.Abs(taxi[j] - musderi[i]);
                    }
                    else if (j>3)
                    {
                        Console.WriteLine(taxi[j]);
                    }
                   
                
                }
                Console.WriteLine(enkicikm+ musderi[i]);
               

            }
        }
    }
}
