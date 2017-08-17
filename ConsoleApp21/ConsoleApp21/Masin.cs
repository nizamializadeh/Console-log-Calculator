using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    class Masin
    {
        public string Model;
        public string Reng;
        public string Motor;
        public string Ili;
        public int Suret;

        public int  Suretlendir(int srtartr)
        {
            Suret += srtartr;
            //Console.WriteLine("Sizin Suretiiniz " + Suret);
            return Suret;
        }
        public int  Yavaslad(int srtrazalt)
        {
            Suret -= srtrazalt;
            //Console.WriteLine("Yavaslayirsiniz Sizin Suretiniz" + Suret);
            return Suret;
        }
        public string Suretcontrol()
        {
            string msj = " ";
            if (Suret>60)
            {
                msj = "suret coxdur diqetli olun ";
            }
            else
            {
                msj = "normal suret";
            }
            return msj;
        }
    }
}
