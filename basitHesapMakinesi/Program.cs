using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Yapmak istediğiniz işlemi seçin:");
            Console.WriteLine("• Toplama için 1");
            Console.WriteLine("• Çıkarma için 2");
            Console.WriteLine("• Çarpma için 3");
            Console.WriteLine("• Bölme için 4");
            Console.WriteLine("• Mod alma için 5");
            Console.WriteLine("• Çıkış için 0");

            int secim = -1;
            while (secim < 0 || secim > 5)
            {
                Console.Write("Seçiminizi yapın (0-5): ");
                string input = Console.ReadLine();
                if (!int.TryParse(input, out secim) || secim < 0 || secim > 5)
                {
                    Console.WriteLine("Geçersiz seçim! Lütfen 0-5 arasında bir değer girin.");
                }
            }

            if (secim == 0)
            {
                Console.WriteLine("Programdan çıkılıyor...");
                break;
            }

            double sayi1 = 0, sayi2 = 0;
            int intSayi1 = 0, intSayi2 = 0;

            if (secim == 5)
            {
                while (true)
                {
                    Console.Write("1. sayıyı girin (integer): ");
                    if (int.TryParse(Console.ReadLine(), out intSayi1))
                        break;
                    Console.WriteLine("Geçersiz giriş! Lütfen bir integer değer girin.");
                }

                while (true)
                {
                    Console.Write("2. sayıyı girin (integer): ");
                    if (int.TryParse(Console.ReadLine(), out intSayi2))
                        break;
                    Console.WriteLine("Geçersiz giriş! Lütfen bir integer değer girin.");
                }

                int modSonuc = intSayi1 % intSayi2;
                Console.WriteLine($"Mod sonucu: {modSonuc}");
            }
            else
            {
                while (true)
                {
                    Console.Write("1. sayıyı girin (double): ");
                    if (double.TryParse(Console.ReadLine(), out sayi1))
                        break;
                    Console.WriteLine("Geçersiz giriş! Lütfen bir double değer girin.");
                }

                while (true)
                {
                    Console.Write("2. sayıyı girin (double): ");
                    if (double.TryParse(Console.ReadLine(), out sayi2))
                        break;
                    Console.WriteLine("Geçersiz giriş! Lütfen bir double değer girin.");
                }

                switch (secim)
                {
                    case 1:
                        Console.WriteLine($"Toplama sonucu: {sayi1 + sayi2}");
                        break;
                    case 2:
                        Console.WriteLine($"Çıkarma sonucu: {sayi1 - sayi2}");
                        break;
                    case 3:
                        Console.WriteLine($"Çarpma sonucu: {sayi1 * sayi2}");
                        break;
                    case 4:
                        if (sayi2 == 0)
                        {
                            Console.WriteLine("Bölen 0 olamaz! Lütfen geçerli bir değer girin.");
                        }
                        else
                        {
                            Console.WriteLine($"Bölme sonucu: {sayi1 / sayi2}");
                        }
                        break;
                }
            }
        }
    }
}
