# 🚗 Araba Sınıfı - Encapsulation (Kapsülleme) Pratiği

Bu proje, C# dilinde encapsulation (kapsülleme) prensibini göstermek amacıyla oluşturulmuş basit bir araba sınıfı örneğidir.

---

## 📌 Proje Özeti

- `Araba` sınıfı içinde `Marka`, `Model`, `Renk` gibi özellikler basit property’ler olarak tanımlanmıştır.
- `KapiSayisi` özelliği kapsüllenmiş (encapsulated) olarak tasarlanmıştır.
- `KapiSayisi` sadece **2** veya **4** değerlerini kabul eder.
- Geçersiz bir değer atanırsa, kullanıcıya konsolda uyarı verilir ve `KapiSayisi` özelliği `-1` olarak atanır.
- Bu sayede, sınıf içi veri bütünlüğü korunur ve yanlış değerler engellenir.

---

## ⚙️ Kullanılan Teknolojiler

- Programlama Dili: **C#**
- Platform: **.NET Console Application**
- IDE: Visual Studio, Visual Studio Code veya benzeri C# destekleyen editörler

---

## 🚀 Nasıl Çalıştırılır?

1. Proje dosyasını .NET Console uygulaması olarak açın.
2. `Program.cs` dosyasına kodu yapıştırın veya projeye dahil edin.
3. `Ctrl + F5` veya `dotnet run` komutu ile uygulamayı çalıştırın.
4. Konsolda araba bilgileri ve kapı sayısı kontrol sonuçlarını göreceksiniz.

---

## 📖 Koddan Örnek Çıktı

```plaintext
Araba Bilgileri:
Marka: Toyota
Model: Corolla
Renk: Beyaz
Kapı Sayısı: 4

Hatalı kapı sayısı! Sadece 2 veya 4 olabilir. Varsayılan olarak -1 atanıyor.
Araba Bilgileri:
Marka: Honda
Model: Civic
Renk: Siyah
Kapı Sayısı: -1
