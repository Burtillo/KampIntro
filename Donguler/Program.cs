using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya Başlangıç İçin Temel Kurs";
            string kurs3 = "Java Kursu";                             //static yazma şekli hamallıktır!

            //array - dizi

            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı",
                "Programlamaya Başlangıç İçin Temel Kurs", "Java Kursu" };     //dynamic yazma şekli hayattır!

            for (int i = 0; i<kurslar.Length; i++) //i sayaç demek ve i++ bir bir arttır demek. i+=2 ikişer artar. 0,1,2 - 3 eleman o yüzden i<3. 3 dahil değil!
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("for bitti");

            foreach (string kurs in kurslar)    //dizileri tek tek kolayca dolaşır
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa sonu - footer");
        }
    }
}
