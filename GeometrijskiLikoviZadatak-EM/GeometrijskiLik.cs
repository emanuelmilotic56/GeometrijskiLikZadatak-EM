using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometrijskiLikoviZadatak_EM
{
    class GeometrijskiLik
    {
        public int BrojStranica
        {
            get;
            set;
        }
        public float[] Stranice
        {
            get;
            set;
        }
        public GeometrijskiLik(int brojStranica)
        {
            BrojStranica = brojStranica;
        }
        public void UcitajStranice()
        {
            Stranice = new float[BrojStranica];
            for (int i=0; i< BrojStranica; i++)
            {
                Console.WriteLine($"Unesite {i + 1} stranicu: ");
                Stranice[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        public float Opseg()
        {
            float vrijednost = 0;
            foreach(var broj in Stranice)
            {
                vrijednost += broj;

            }
            return vrijednost;
        }
    }
}
