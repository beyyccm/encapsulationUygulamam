using System;

class Araba
{
    // Marka, model ve renk için auto-property tanımlamaları
    public string Marka { get; set; }
    public string Model { get; set; }
    public string Renk { get; set; }

    // Kapı sayısı kapsüllenmiş property olarak tanımlanır
    private int _kapiSayisi;

    public int KapiSayisi
    {
        get { return _kapiSayisi; }
        set
        {
            if (value == 2 || value == 4)
            {
                _kapiSayisi = value;
            }
            else
            {
                Console.WriteLine("Hatalı kapı sayısı! Sadece 2 veya 4 olabilir. Varsayılan olarak -1 atanıyor.");
                _kapiSayisi = -1;
            }
        }
    }

    // Araba bilgilerini ekrana yazdırmak için metot
    public void BilgileriGoster()
    {
        Console.WriteLine("Araba Bilgileri:");
        Console.WriteLine($"Marka: {Marka}");
        Console.WriteLine($"Model: {Model}");
        Console.WriteLine($"Renk: {Renk}");
        Console.WriteLine($"Kapı Sayısı: {KapiSayisi}");
    }
}

class Program
{
    static void Main()
    {
        // Geçerli bir araba nesnesi
        Araba araba1 = new Araba();
        araba1.Marka = "Toyota";
        araba1.Model = "Corolla";
        araba1.Renk = "Beyaz";
        araba1.KapiSayisi = 4;
        araba1.BilgileriGoster();

        Console.WriteLine();

        // Geçersiz kapı sayısıyla oluşturulan bir araba
        Araba araba2 = new Araba();
        araba2.Marka = "Honda";
        araba2.Model = "Civic";
        araba2.Renk = "Siyah";
        araba2.KapiSayisi = 3; // Geçersiz değer -> -1 olarak atanacak
        araba2.BilgileriGoster();
    }
}
