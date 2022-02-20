using System;

namespace degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime dt = DateTime.Now;
            
            Console.WriteLine(dt);

            // string ifadeler

            string str1 = string.Empty;
            str1 = "hakan turan";
            string ad = "hakan";
            string soyad = "turan";
            string tamisim = ad + " " + soyad;
            Console.WriteLine(tamisim);

            // integer ifadeler

            int integer1 = 5;
            int integer2 = 3;
            int interger3 = integer1 * integer2;
            Console.WriteLine(interger3);

            // boolean ifadelre
            
            bool b1 = 10<2;
            Console.WriteLine(b1);

            bool b2 = 10>2;
            Console.WriteLine(b2);

            // değişken dönüşümleri

            string str20 = "20";
            int int20 = 20;

            String yenideger = str20 + int20.ToString();

            Console.WriteLine(yenideger);

            int int21 = int20 + Convert.ToInt32(str20);

            Console.WriteLine(int21);

            int int22 = int20 + int.Parse(str20);
            Console.WriteLine(int22); 

            // DateTime 

            string datetime = DateTime.Now.ToString("M.dd.yyyy"); 
            Console.WriteLine(datetime);  // 2.20.2022

            // saat
            
            string hour = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(hour);








        

        }
    }
}
