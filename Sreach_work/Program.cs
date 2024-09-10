namespace Sreach_work;

class Program
{
    static void Main(string[] args)
    {
       /* 
       1. Nesne Yönelimli Programlama (OOP) Nedir?

Nesne Yönelimli Programlama (OOP), yazılım geliştirmede kullanılan bir programlama paradigmasıdır. OOP, veriyi ve bu veriyi işleyen fonksiyonları bir arada gruplayarak nesneler oluşturur. Bu yaklaşım, yazılımın daha esnek, yeniden kullanılabilir ve yönetilebilir olmasını sağlar.

Temel Amaçları:

Yeniden Kullanılabilirlik: Kodun tekrar tekrar kullanılmasını sağlar.
Bakım Kolaylığı: Kodun daha anlaşılır ve yönetilebilir olmasını sağlar.
Genişletilebilirlik: Yeni özellikler eklemek daha kolaydır.
Diğer Programlama Yaklaşımlarından Farkı:

Fonksiyonel Programlama: OOP'nin aksine, fonksiyonel programlama, veri ve fonksiyonları ayrı tutar ve yan etkileri minimize etmeye çalışır.
Yapısal Programlama: Yapısal programlama, kodun mantıksal bir yapı içinde düzenlenmesini sağlar; ancak veri ve fonksiyonları bir araya getiren OOP'nin sunduğu esnekliği ve yeniden kullanılabilirliği sunmaz.
2. Sınıf (Class) ve Nesne (Object) Nedir?

Sınıf (Class): Sınıf, bir nesnenin özelliklerini ve davranışlarını tanımlayan bir şablondur. Sınıflar, nesnelerin nasıl davranacağını ve hangi özelliklere sahip olacağını belirler.
Örnek: Araba sınıfı, bir arabanın modelini, rengini ve hızını tanımlayabilir.
Nesne (Object): Nesne, sınıfın somut bir örneğidir. Sınıfta tanımlanan özellikler ve davranışlar, nesne üzerinde somutlaşır.
Örnek: Toyota Corolla ve Honda Civic, Araba sınıfının nesneleridir.
Fark ve İlişki:

Fark: Sınıf bir taslak iken, nesne bu taslağın bir örneğidir.
İlişki: Sınıflar, nesneleri oluşturmak için kullanılır. Nesneler, sınıfların tanımladığı özelliklere ve davranışlara sahiptir.

       */
       public class Araba
  {
    
    public string Model { get; set; }
    public string Renk { get; set; }

    Araba benimAraba = new Araba();
    benimAraba.Model = "Toyota Corolla";
    benimAraba.Renk = "Kırmızı";
    benimAraba.Hızlan(100);
    
    public void Hızlan(int hız)
    {
        Console.WriteLine($"{Model} {hız} km/s hızlandı.");
    }
   }

/* 3. Encapsulation (Kapsülleme) Nedir?

Kapsülleme, veriyi (özellikleri) ve bu veriyi işleyen yöntemleri (metotları) bir arada gruplama işlemidir. Bu yaklaşım, veriyi dışarıdan erişime kapatır ve yalnızca belirlenen metotlar aracılığıyla verilere erişim sağlar.

Nasıl Uygulanır ve Ne İşe Yarar:

Uygulama: Erişim belirleyicileri (private, protected, public) kullanılarak yapılır.
Faydaları: Verinin bütünlüğünü korur, kodun bakımını kolaylaştırır ve güvenliği artırır.

*/
public class BankaHesabi
{
    private decimal bakiye; // Kapsüllenmiş veri
    
    public void ParaYatir(decimal miktar)
    {
        if (miktar > 0)
        {
            bakiye += miktar;
        }
    }
    
    public decimal BakiyeGoster()
    {
        return bakiye;
    }
}

/*
4. Inheritance (Kalıtım) Nedir?

Kalıtım, bir sınıfın (alt sınıf) başka bir sınıftan (üst sınıf) özellikler ve metotlar miras almasını sağlar. Bu, kodun yeniden kullanılmasını ve genişletilmesini kolaylaştırır.

Kullanımı ve Avantajları:

Kullanım: : operatörü ile yapılır.
Avantajlar: Kod tekrarını azaltır, hiyerarşik bir yapı oluşturur ve ortak özellikleri paylaşır.


 */

 public class Hayvan
{
    public void SesCikar()
    {
        Console.WriteLine("Hayvan ses çıkarıyor.");
    }
}

public class Kedi : Hayvan
{
    public void Miyavla()
    {
        Console.WriteLine("Kedi miyavlıyor.");
    }
}

// Kullanım
Kedi kedi = new Kedi();
kedi.SesCikar(); // Üst sınıftan miras alındı
kedi.Miyavla(); 

/* 
5. Polymorphism (Çok Biçimlilik) Nedir?

Polymorphism, aynı işlemi farklı biçimlerde gerçekleştirme yeteneğidir. Bu, metotların aynı isimde olmasına rağmen farklı işlevler yerine getirmesini sağlar.

Nasıl Kullanılır:

Method Overloading: Aynı isimde fakat farklı parametrelerle metotlar tanımlanır.
Method Overriding: Üst sınıftan miras alınan metot, alt sınıfta yeniden tanımlanır.

*/
public class Hayvan
{
    public virtual void SesCikar()
    {
        Console.WriteLine("Hayvan ses çıkarıyor.");
    }
}

public class Kedi : Hayvan
{
    public override void SesCikar()
    {
        Console.WriteLine("Kedi miyavlıyor.");
    }
}

Hayvan hayvan = new Kedi();
hayvan.SesCikar(); 
/* 6. Abstraction (Soyutlama) Nedir?

Soyutlama, karmaşıklığı gizleyip yalnızca önemli detayları ortaya çıkarma işlemidir. Sınıfların ve metotların genel yapısını belirleyip, detayları gizler.

Abstraction ve Encapsulation Arasındaki Farklar:

Abstraction: Verinin genel yapısını ve davranışlarını tanımlar, detaylara girmez.
Encapsulation: Veriyi ve metotları bir arada gruplar, veri erişimini sınırlar.

*/
public abstract class Sekil
{
    public abstract double AlanHesapla();
}

public class Daire : Sekil
{
    public double YariCap { get; set; }
    
    public override double AlanHesapla()
    {
        return Math.PI * YariCap * YariCap;
    }
}

/*7. Constructor (Yapıcı Metot) Nedir ve Nasıl Kullanılır?

Yapıcı metot, bir sınıfın yeni bir nesnesi oluşturulduğunda otomatik olarak çağrılan bir metottur. Sınıfın başlangıç değerlerini ayarlamak için kullanılır.

Amacı ve Kullanımı:

Amacı: Nesne oluşturulduğunda varsayılan veya özel değerler atamak.
Kullanım: Sınıf adıyla aynı isme sahip ve geri dönüş tipi olmayan metotlardır.
Örnek:
 */
 public class Kisi
{
    public string Ad { get; set; }
    
    public Kisi(string ad) // Yapıcı metot
    {
        Ad = ad;
    }
}

Kisi kisi = new Kisi("Ali");

/* 8. Interface ve Abstract Class Nedir?

Interface: Yalnızca metod imzalarını içerir, metodların nasıl çalıştığını tanımlamaz. Sınıflar, bir veya daha fazla interface'i uygulayabilir.
Abstract Class: Hem metod imzalarını hem de metod gövdesini içerir. Bir sınıf, bir abstract class'ı miras alabilir.
Aralarındaki Farklar:

Interface: Birden fazla interface implementasyonu sağlar.
Abstract Class: Tek bir abstract class'ı miras alabilir.
Ne Zaman Kullanılırlar:

Interface: Çoklu kalıtım veya farklı sınıfların aynı metodları paylaşması gerektiğinde.
Abstract Class: Ortak metod ve özelliklerin paylaşılması gerektiğinde.
*/
public interface IHayvan
{
    void SesCikar();
}

public abstract class Hayvan : IHayvan
{
    public abstract void SesCikar();
}

public class Kedi : Hayvan
{
    public override void SesCikar()
    {
        Console.WriteLine("Kedi miyavlıyor.");
    }
}
    }
}
