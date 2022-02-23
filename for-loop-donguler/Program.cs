﻿using System;

namespace for_loop_donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Ekrandan girilen sayiya kadar olan tek sayilari ekrana yazdir.
            Console.Write("Lutfen bir sayi giriniz: ");
            int sayac =int.Parse(Console.ReadLine());
            for (int i = 1; i <= sayac; i++)
            {
                if(i%2 ==1)
                Console.WriteLine(i);
            }

            // //1 ile 1000 arasındaki tek ve çift sayiların kendi iclerindeki toplamlarini ekrana yazdir. 
            int tektoplam = 0;
            int ciftoplam = 0;
            for (int i = 1; i <= 1000; i++)
            {
                if(i%2 ==1)
                    tektoplam += i; //tektoplam = tektoplam + i;
                else   
                    ciftoplam += i; //cifttoplam = cifttoplam + i;
            }
            Console.WriteLine("Tek Toplam:" + tektoplam);
            Console.WriteLine("Çift Toplam:" + ciftoplam);

            //break, continue

            for (int i = 1; i < 10; i++)
            {
                if(i==4)
                    break;
                Console.WriteLine(i);
            }
            for (int i = 1; i < 10; i++)
            {
                if(i==4)
                    continue;
                Console.WriteLine(i);                
            }

            // for (;;) - sonsuz döngüdür kaçınılması gerekir.
        }
    }
}