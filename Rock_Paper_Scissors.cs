using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Taş-Kağıt-Makas Oyunu ===");

        while (true)
        {
            Console.WriteLine("Seçiminizi yapın: ");
            Console.WriteLine("1. Taş");
            Console.WriteLine("2. Kağıt");
            Console.WriteLine("3. Makas");
            Console.WriteLine("4. Çıkış");

            string kulSecim = Console.ReadLine();

            if (kulSecim == "4")
            {
                Console.WriteLine("Oyundan çıkılıyor...");
                break;
            }

            if (kulSecim != "1" && kulSecim != "2" && kulSecim != "3")
            {
                Console.WriteLine("Geçerli bir seçenek giriniz.");
                continue;
            }

            int kulSecim2 = Convert.ToInt32(kulSecim);

            Random random = new Random();
            int bilSecimi = random.Next(1, 4);

            Console.WriteLine($"Bilgisayarın seçimi: {SecimAdi(bilSecimi)}");

            Console.WriteLine($"Sizin seçiminiz: {SecimAdi(kulSecim2)}");

            SonucuGoster(kulSecim2, bilSecimi);
        }
    }

    static void SonucuGoster(int kulSecim2, int bilSecimi)
    {
        if (kulSecim2 == bilSecimi)
        {
            Console.WriteLine("Berabere! Tekrar deneyin.");
        }
        else if ((kulSecim2 == 1 && bilSecimi == 3) ||
                 (kulSecim2 == 2 && bilSecimi == 1) ||
                 (kulSecim2 == 3 && bilSecimi == 2))
        {
            Console.WriteLine("Tebrikler! Kazandınız.");
        }
        else
        {
            Console.WriteLine("Maalesef kaybettiniz. Başka bir seferde tekrar deneyin.");
        }
    }

    static string SecimAdi(int secim)
    {
        switch (secim)
        {
            case 1:
                return "Taş";
            case 2:
                return "Kağıt";
            case 3:
                return "Makas";
            default:
                return "Geçersiz";
        }
    }
}
