using System;

namespace PolymorphismExample
{
    public class Kare : Sekil
    {
        public int kenar;

        public Kare(string isim, int kenar) : base(isim)
        {
            this.kenar = kenar;
        }

        public override void sekilHesapla()
        {
            base.sekilHesapla();
            Console.WriteLine(getIsim() + "nin alanı: " + (kenar * kenar));
        }

        public override void sekilBilgileriGoster()
        {
            Console.WriteLine(getIsim() + "nin bilgileri");
            Console.WriteLine("Şeklin ismi: " + getIsim());
            Console.WriteLine(getIsim() + "nin kenarı: " + this.kenar);
        }
    }
}
