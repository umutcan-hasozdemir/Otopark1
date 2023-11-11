using System;

class Program
{
    static void Main(string[] args)
    {
        // Araç türünü ve kalma süresini kullanıcıdan al
        Console.WriteLine("Araç türünü seçin (1: Otomobil, 2: Kamyon, 3: Iş makinası):");
        int aracTuru = int.Parse(Console.ReadLine());

        Console.WriteLine("Kalma süresini saat cinsinden girin:");
        int kalmaSuresi = int.Parse(Console.ReadLine());

        // Ücreti hesapla
        double toplamUcret = HesaplaUcret(aracTuru, kalmaSuresi);

        // Sonucu ekrana yazdır
        Console.WriteLine("Toplam ücret: " + toplamUcret + " TL");
    }

    static double HesaplaUcret(int aracTuru, int kalmaSuresi)
    {
        double ucret = 0;

        if (aracTuru == 1) // Otomobil
        {
            int gun = kalmaSuresi / 24;
            int kalanSaat = kalmaSuresi % 24;

            if (kalanSaat <= 2)
            {
                ucret = gun * 13 + 5;
            }
            else
            {
                ucret = gun * 13 + 5 + (kalanSaat - 2);
            }
        }
        else if (aracTuru == 2) // Kamyon
        {
            int gun = kalmaSuresi / 24;
            int kalanSaat = kalmaSuresi % 24;

            if (kalanSaat <= 2)
            {
                ucret = gun * 32 + 8;
            }
            else
            {
                ucret = gun * 32 + 8 + (kalanSaat - 2) * 2;
            }
        }
        else if (aracTuru == 3) // Iş makinası
        {
            int gun = kalmaSuresi / 24;
            int kalanSaat = kalmaSuresi % 24;

            if (kalanSaat <= 2)
            {
                ucret = gun * 60 + 12;
            }
            else
            {
                ucret = gun * 60 + 12 + (kalanSaat - 2) * 3;
            }
        }
        else
        {
            Console.WriteLine("Geçersiz araç türü.");
        }

        return ucret;
    }
}
