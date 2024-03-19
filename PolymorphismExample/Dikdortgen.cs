using System;

namespace PolymorphismExample
{
    public class Dikdortgen : Sekil
    {
        public int kisaKenar;
        public int uzunKenar;
        public Dikdortgen(string isim, int kisaKenar, int uzunKenar) : base(isim)
        {
            this.kisaKenar = kisaKenar;
            this.uzunKenar = uzunKenar;
        }

        public override void sekilHesapla()
        {
            base.sekilHesapla();
            Console.WriteLine(getIsim() + "in alanı: " + (kisaKenar * uzunKenar));
        }

        public override void sekilBilgileriGoster()
        {
            base.sekilBilgileriGoster();
            Console.WriteLine("Şeklin ismi: " + getIsim());
            Console.WriteLine(getIsim() + "in kısa kenarı: " + this.kisaKenar);
            Console.WriteLine(getIsim() + "in uzun kenarı: " + this.uzunKenar);
        }
    }
}
