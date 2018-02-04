using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kullanici_0_girene_kadar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            int sayi;
            bool deger = false;
            // Kullanici sifir girene kadar klavyeden girilen sayilarin tek mi cift mi olduklarini bulan program
            Console.WriteLine("Merhaba, girdiginiz sayilarin tek mi cift mi olduklarina bakalim.");
            Console.WriteLine("Unutmayin, programi kapatmak icin 0 girmeniz gerekiyor.");
            while (deger == false)
            {
                Console.Write("Sayi girin: ");
                A10:;
                try
                {
                    sayi = Convert.ToInt32(Console.ReadLine());
                    if (sayi == 0)
                    {
                        deger = true;
                    }
                    else if (sayi % 2 == 0)
                    {
                        Console.WriteLine(sayi + " sayisi cifttir.\n");
                    }
                    else
                    {
                        Console.WriteLine(sayi + " sayisi tektir.\n");
                    }
                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nBIR TAMSAYI GIRMELISINIZ!");
                    Console.ForegroundColor = ConsoleColor.White;
                    goto A10;
                }
            }
            Console.WriteLine("0 sayisini girdiniz. Bu bir cift sayidir. Program bir tusa basildiktan sonra kapatilacak.");
            Console.ReadKey();
        }
    }
}
