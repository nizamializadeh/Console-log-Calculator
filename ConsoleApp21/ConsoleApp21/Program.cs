using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    class Program
    {
        static void Main(string[] args)
        {
            Masin car = new Masin();
            int masinsureti = 0;
            masinsureti = car.Suretlendir(101);
            car.Suretlendir(20);
            car.Suretlendir(23);
            car.Suretlendir(4);
            car.Suretlendir(12);
            car.Suretlendir(5);
            masinsureti = car.Yavaslad(50);
            car.Model = "Mercedes";
            car.Ili = "23";
            car.Motor = "6.5";      
            car.Reng = "White";
           
            Console.WriteLine("Masnin ozelikleri \nmodeli {0},Ili {1}, Motoru {2}, rengi {3} ",car.Model,car.Ili,car.Motor,car.Reng);
            Console.WriteLine(" suret " + masinsureti);
            Console.WriteLine(car.Suretcontrol());
        }
    }
}
