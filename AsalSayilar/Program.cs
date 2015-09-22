using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsalSayilar
{
    class Program
    {

        static void Main(string[] args)
        {
            for (;;)
            {
                try {
                    Console.Clear();
                    Console.WriteLine("1. n. sıradaki asal sayı");
                    Console.WriteLine("2. n tane asal sayıyı yazdır");
                    Console.WriteLine("3. Girilen sayı asal mı?");
                    Console.WriteLine("0. Çıkış");
                    Console.Write("Seçim: ");
                    int secenek = int.Parse(Console.ReadLine());

                    if (secenek == 1)
                    {
                        Console.Write("Kaçıncı asal sayıyı bulmak istedğinizi giriniz: ");
                        int asalSayi = int.Parse(Console.ReadLine());
                        Console.WriteLine(asalSayi + ". Asal Sayı: " + kacinciAsalSayi(asalSayi).ToString());
                    }
                    else if (secenek == 2)
                    {
                        Console.Write("Kaç tane asal sayıyı yazdırmak istedğinizi giriniz: ");
                        int kacTane = int.Parse(Console.ReadLine());
                        kacinciAsalSayiYaz(kacTane);
                    }
                    else if (secenek == 3)
                    {
                        Console.Write("Bir sayı giriniz: ");
                        int sayi = int.Parse(Console.ReadLine());
                        if (asalMi(sayi))
                        {
                            Console.WriteLine("ASAL SAYI");
                        }
                        else
                        {
                            Console.WriteLine("ASAL DEĞİL");
                        }
                    } else if (secenek == 0)
                    {
                        break;
                    }
                    Console.ReadLine();
                }
                catch (Exception ex)
                {
                    // 
                }
            }
            Console.Read();
        }
        static bool asalMi(int sayi)  // parametre olarak aldığı sayı asalsa true değilse false döndürür
        {
            for (int i = 2; i < sayi/2+1; i++)
            {
                if (sayi % i == 0)
                {
                    return false;
                }
             }
            return true;
        }
        static int kacinciAsalSayi(int kacinci) // parametre olarak kaçıncı asal sayı isteniyorsa o sayı gönderilir
        {
            int i = 2, kac=0; // 'kac' değişkeni bulunan asal sayısının kaçıncı asal sayı olduğunu tutacak
            for (;;)
            {
                if (asalMi(i))
                {
                    kac++; // i sayısı asal ise 'kac' değişkenini 1 artır
                }
                if (kac == kacinci) 
                {
                    return i; // istenilen sıradaki asal sayıya ulaşınca döndür
                }
                i++;
            }
        }
        static int kacinciAsalSayiYaz(int kacinci) // parametre olarak kaçıncı asal sayı isteniyorsa o sayı gönderilir
        {
            int i = 2, kac = 0; // 'kac' değişkeni bulunan asal sayısının kaçıncı asal sayı olduğunu tutacak
            for (;;)
            {
                if (asalMi(i))
                {
                    kac++; // i sayısı asal ise 'kac' değişkenini 1 artır
                    Console.Write(i+",");
                }
                if (kac == kacinci)
                {
                    return i; // istenilen sıradaki asal sayıya ulaşınca döndür
                }
                i++;
            }
        }
    }
}
