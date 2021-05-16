using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            // pythondaki yorum satırı işlevi görüyo hashtag gibi
            //type safety - tip güvenliği
            //Do not repeat yourself - kendini tekrarlama!
            //değer tutucu, alias

            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000; //integer belli bir sayıya kadar
            double faizOrani = 1.45; //float ın karşılığı
            bool sistemeGirisYapmisMi = true; //? araştır

            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış oku");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış oku");
            }
            else
            {
                Console.WriteLine("Eşittir oku");
            }
            
            
            
            //if yaz iki tane tab bas otomatik if gelsin

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }

            Console.WriteLine("sayfa sonu - footer");
        }
        
        
        }
    }
