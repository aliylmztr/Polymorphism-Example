using System;

namespace PolymorphismExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Şekil Uygulamasına Hoşgeldiniz!");

            while(true)
            {
                Console.WriteLine("1- Dikdörtgen İşlemleri\n2- Üçgen İşlemleri\n3- Kare İşlemleri\nq- Çıkış Yap");
                Console.Write("İşlem seçiniz: ");
                string secim = Console.ReadLine();

                if(secim == "q")
                {
                    Console.WriteLine("Çıkış yapılıyor...");
                    break;
                }
                else if(secim == "1")
                {
                    while(true)
                    {
                        Console.WriteLine("1- Dikdörtgenin Alanını Hesapla\n2- Dikdörtgenin Bilgilerini Göster\nq- Çıkış Yap");
                        Console.Write("İşlem seçiniz: ");
                        string secimDikdortgen = Console.ReadLine();

                        if(secimDikdortgen == "1")
                        {
                            Console.Write("Kısa kenarı giriniz: ");
                            int kisaKenar = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Uzun kenarı giriniz: ");
                            int uzunKenar = Convert.ToInt32(Console.ReadLine());
                            
                            Dikdortgen dikdortgen = new Dikdortgen("Dikdörtgen", kisaKenar, uzunKenar);
                            dikdortgen.sekilHesapla();
                        }
                        else if(secimDikdortgen == "2")
                        {
                            Console.Write("Kısa kenarı giriniz: ");
                            int kisaKenar = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Uzun kenarı giriniz: ");
                            int uzunKenar = Convert.ToInt32(Console.ReadLine());
                            
                            Dikdortgen dikdortgen = new Dikdortgen("Dikdörtgen", kisaKenar, uzunKenar);
                            dikdortgen.sekilBilgileriGoster();
                        }
                        else if(secimDikdortgen == "q")
                        {
                            Console.WriteLine("Dikdörtgen işlemlerinden çıkılıyor.");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Geçersiz bir değer girdiniz!");
                        }
                    }
                }
                else if (secim == "2")
                {                  
                    while (true)
                    {
                        Console.WriteLine("1- Üçgenin Alanını Hesapla\n2- Üçgenin Bilgilerini Göster\nq- Çıkış Yap");
                        Console.Write("İşlem seçiniz: ");
                        string secimUcgen = Console.ReadLine();

                        if (secimUcgen == "1")
                        {
                            Console.Write("Üçgenin tabanını giriniz: ");
                            int taban = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Üçgenin yüksekliğini giriniz: ");
                            int yukseklik = Convert.ToInt32(Console.ReadLine());

                            Ucgen ucgen = new Ucgen("Üçgen", taban, yukseklik);
                            ucgen.sekilHesapla();
                        }
                        else if(secimUcgen == "2")
                        {
                            Console.Write("Üçgenin tabanını giriniz: ");
                            int taban = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Üçgenin yüksekliğini giriniz: ");
                            int yukseklik = Convert.ToInt32(Console.ReadLine());

                            Ucgen ucgen = new Ucgen("Üçgen", taban, yukseklik);
                            ucgen.sekilBilgileriGoster();
                        }
                        else if (secimUcgen == "q")
                        {
                            Console.WriteLine("Üçgen işlemlerinden çıkılıyor.");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Geçersiz bir değer girdiniz!");
                        }
                    }
                }
                else if(secim == "3")
                {                    
                    while(true)
                    {
                        Console.WriteLine("1- Karenin Alanını Hesapla\n2- Karenin Bilgilerini Göster\nq- Çıkış Yap");
                        Console.Write("İşlem seçiniz: ");
                        string secimKare = Console.ReadLine();

                        if(secimKare == "1")
                        {
                            Console.Write("Karenin kenarını giriniz: ");
                            int kenar = Convert.ToInt32(Console.ReadLine());

                            Kare kare = new Kare("Kare", kenar);
                            kare.sekilHesapla();
                        }
                        else if(secimKare == "2")
                        {
                            Console.Write("Karenin kenarını giriniz: ");
                            int kenar = Convert.ToInt32(Console.ReadLine());

                            Kare kare = new Kare("Kare", kenar);
                            kare.sekilBilgileriGoster();
                        }
                        else if(secimKare == "q")
                        {
                            Console.WriteLine("Kare işlemlerinden çıkılıyor.");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Geçersiz bir değer girdiniz!");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Geçersiz bir değer girdiniz!");
                }
            }
            Console.ReadLine();
        }
    }
}
