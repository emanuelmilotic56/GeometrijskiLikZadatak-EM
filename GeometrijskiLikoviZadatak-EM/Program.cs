using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometrijskiLikoviZadatak_EM
{
    class Program
    {
        static void Main(string[] args)
        {
            Trokut trokut = new Trokut();
            Kvadrat kvadrat = new Kvadrat();

            Console.WriteLine("Trokut");
            trokut.UcitajStranice();
            float opsegTrokuta = trokut.Opseg();
            Console.WriteLine();

            Console.WriteLine("Kvadrat");
            kvadrat.UcitajStranice();
            float opsegKvadrata = kvadrat.Opseg();
            Console.WriteLine();

            Console.WriteLine($"Opseg trokuta izmosi: {opsegTrokuta}");

            Console.WriteLine($"Opseg kvadrata iznosi: {opsegKvadrata}");

            Console.ReadKey();

        }
    }
}
