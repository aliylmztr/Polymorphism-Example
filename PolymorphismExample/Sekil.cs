using System;

namespace PolymorphismExample
{
    public class Sekil
    {
        public string isim;

        public Sekil(string isim)
        {
            this.isim = isim;
        }

        public string getIsim()
        {
            return this.isim;
        }

        public void setIsim(string isim)
        {
            this.isim = isim;
        }

        public virtual void sekilHesapla()
        {
            Console.WriteLine("Şeklin alanı hesaplanıyor.");
        }

        public virtual void sekilBilgileriGoster()
        {
            Console.WriteLine(getIsim() + "in bilgileri");
        }
    }
}
