using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //naming convention
        //syntax
        public void Ekle(Urun urun)      //hızlıca print yazmak istiyorsan cw tab tab bas.
        {
            Console.WriteLine("Tebrikler! Sepete eklendi : " + urun.Adi);
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("Tebrikler! Sepete eklendi : " + urunAdi);
        }
    }
}
