using System;
using System.Linq; // Bu kütüphane ile sıralama işlemlerini yapacağız

class Program
{
    static void Main(string[] args)
    {
        // 1.  burda sayılaırmıız  tanımlıyoruz 10 adet

        int[] sayilar = new int[10];

        // 2. Adım:  for ile diziye girip
        for (int i = 0; i < sayilar.Length; i++)
        {
            Console.Write($"Lütfen {i + 1}. sayıyı giriniz: ");
            sayilar[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nGirdiğiniz sayılar:");
        foreach (int sayi in sayilar)
        {
            Console.WriteLine(sayi);
        }

        //
        Console.Write("\nLütfen eklemek istediğiniz yeni sayıyı giriniz: ");
        int yeniSayi = int.Parse(Console.ReadLine());

        // Yeni eleman eklemek için diziyi genişletiyoruz
        int[] yeniSayilar = new int[sayilar.Length + 1];
        for (int i = 0; i < sayilar.Length; i++)
        {
            yeniSayilar[i] = sayilar[i];
        }
        yeniSayilar[sayilar.Length] = yeniSayi; // 11. elemanı ekledik

        // 4. Adım: Bu diziyi büyükten küçüğe ekrana yazdırınız.
        Array.Sort(yeniSayilar); // Küçükten büyüğe sıralar
        Array.Reverse(yeniSayilar); 

        Console.WriteLine("\nDizinin büyükten küçüğe sıralanmış hali:");
        foreach (int sayi in yeniSayilar)
        {
            Console.WriteLine(sayi);
        }
    }
}
