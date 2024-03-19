using System;

namespace PolymorphismExample
{
    public class Ucgen : Sekil
    {
        public int taban;
        public int yukseklik;
        public Ucgen(string isim, int taban, int yukseklik) : base(isim)
        {
            this.taban = taban;
            this.yukseklik = yukseklik;
        }

        public override void sekilHesapla()
        {
            base.sekilHesapla();
            Console.WriteLine(getIsim() + "in alanı: " + ((taban * yukseklik) / 2));
        }

        public override void sekilBilgileriGoster()
        {
            base.sekilBilgileriGoster();
            Console.WriteLine("Şeklin ismi: " + getIsim());
            Console.WriteLine(getIsim() + "in tabanı: " + this.taban);
            Console.WriteLine(getIsim() + "in yüksekliği: " + this.yukseklik);
        }
    }
}
