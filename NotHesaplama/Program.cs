using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotHesaplama
{
    class Program
    {
        private static List<OgrenciNot> notlar;
        static void Main(string[] args)
        {

            NotGirisi();
            NotlariGetir();


            Console.Read();
        }

        private static void IslemDurumuSec()
        {
            Console.Write("1-NotGirisi\n" +
                          "2-NotHesaplama\n" +
                          "3-Grafik Çizdir\n" +
                          "4-Çıktı Al\n" +
                          "5-Çıkış");


            int deger = Convert.ToInt16(Console.ReadLine());


            switch (deger)
            {

                case 1: NotGirisi(); break;
                case 2: NotlariGetir(); break;
            }

        }

        static void NotlariGetir()
        {
            Console.Write("Lütfen Öğrenci No Giriniz  : ");
            int ogrenciNo = Convert.ToInt16(Console.ReadLine());

            Console.Write("Lütfen [1-5] arasında rakam giriniz  : ");
            int tur = Convert.ToInt16(Console.ReadLine());

            OgrenciNot not = notlar.FirstOrDefault(x => x.No == (ogrenciNo-1));

            switch (tur)
            {
                case 1:
                    Console.WriteLine("[{0},{1}]" ,not.No+1, tur);
                    Console.WriteLine("Öğrenci No :" + not.No);
                    ; break;

                case 2:
                    Console.WriteLine("[{0},{1}]" , not.No+1, tur);
                    Console.WriteLine("Vize 1 :"+not.Vize1);
                    ;break;

                case 3:
                    Console.WriteLine("[{0},{1}]" , not.No + 1, tur);
                    Console.WriteLine("Vize 2 :"+not.Vize2);
                    ; break;

                case 4:
                    Console.WriteLine("[{0},{1}]" , not.No + 1, tur);
                    Console.WriteLine("Final :" + not.Final);
                    ; break;
                case 5:
                    Console.WriteLine("[{0},{1}]" , not.No + 1, tur);
                    Console.WriteLine("Ortalama :" + not.Ortalama);
                    ; break;
                default: 
                    Console.WriteLine("Hatalı işlem");
                    break
                        ;
            }
        }


        static void NotGirisi()
        {
            Console.Write("Lütfen Öğrenci Sayısını Giriniz  : ");
            int N = Convert.ToInt16(Console.ReadLine());
             notlar=new List<OgrenciNot>();
            int[] vize1 = new int[N];
            int[] vize2 = new int[N];
            int[] final = new int[N];
            double[] ort = new double[N];
            Random r = new Random();

            Console.WriteLine("\n");
            Console.WriteLine("\nÖğrenci No  1.Vize 2.Vize Final Not Ortalama ");
            for (int i = 0; i < N; i++)
            {
                OgrenciNot not=new OgrenciNot();
                vize1[i] = r.Next(0, 100);
                vize2[i] = r.Next(0, 100);
                final[i] = r.Next(0, 100);
                ort[i] = (vize1[i] + vize2[i]) * 0.2 + final[i] * 0.6;

                not.Vize1 = vize1[i];
                not.No = i;
                not.Vize2 = vize2[i];
                not.Final = final[i];
                not.Ortalama = ort[i];

                //Console.WriteLine((i + 1) + "           " + vize1[i] + "      " + vize2[i] + "        " + final[i] + "       " + ort[i]);
                notlar.Add(not);
                Console.WriteLine((i + 1) + "           " + not.Vize1 + "      " + not.Vize2 + "        " + not.Final + "       " + not.Ortalama);

            }

        }


        class OgrenciNot
        {
            public int No { get; set; }
            public int Vize1 { get; set; }
            public int Vize2 { get; set; }
            public int Final { get; set; }
            public double Ortalama { get; set; }
        }

    }
}
