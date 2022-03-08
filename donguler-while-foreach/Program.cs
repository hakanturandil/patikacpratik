using System;

namespace donguler_while_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            // while
            // 1 den baslayarak console dan girilen sayiya kadar (sayi dahil) ortalama hesaplayıp console a yazdıran program.
            Console.Write("Lutfen bir sayi giriniz:");
            int sayi = int.Parse(Console.ReadLine());
            int sayac= 1;
            int toplam = 0;
            while (sayac <= sayi)
            {
                toplam += sayac;
                sayac ++;
            }
            Console.WriteLine(toplam/sayi);

            // a dan z ye kadar tüm harfleri console a yazdir.
            char character = 'a';
            while (character < 'z')
            {
                Console.Write(character);
                character ++;
            }

            Console.Write("***** Foreach *****");

            string[] arabalar = {"ford","bmw","toyota","nissan"};

            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }

        }
    }
}
