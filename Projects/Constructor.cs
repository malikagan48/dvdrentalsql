using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projects
{
    internal class Constructor
    {
        //Söz Dizimi
        //class sinifAdi
        //{
        //
        //
        //    [eriişim belirleyici] Veri tipi ozellikAdi;
        //    [Erişim belirleyici] [Geri Dönüş Tipi] metot adi(parameyre listesi)
        //    {
        //     //Metot komutları
        //    }
        //    
        //
        //}
        //sınıf üyeleri proportiler

        //Erişim belirleyiciler
        //**public 
        //**private
        //**Iternal
        //** Protected
        //kurucu fonksiyon overload(aşırı yükleme)yapılabilir.
        Console.WriteLine("*****Çalışan 1*****");
            Calisan calisan1 = new Calisan("ali", "veli", 3422341, "bt");//nesneye ayağı kaldırma işlemi
        calisan1.CalisanBilgileri();

            Console.WriteLine("*****Çalışan 2*****");
            Calisan calisan2 = new Calisan();
        calisan2.Ad = "kagan";
            calisan2.Soyad = "kucuk";
            calisan2.No = 123124123;
            calisan2.Depertman = "backned";

            calisan2.CalisanBilgileri();
            Console.WriteLine("*****Çalışan 3*****");
            Calisan calisan3 = new Calisan("zafer", "ordu");
        calisan3.CalisanBilgileri();

        }
}

class Calisan
{
    public string Ad;//proportiler üzerinde değişiklik yapmak için kurucu metot tanımlıyourz

    public string Soyad;

    public int No;

    public string Depertman;

    public Calisan(string ad, string soyad, int no, string departman)
    {
        this.Ad = ad;//this bu sınıfın elemanı olduğu için kullandık
        this.Soyad = soyad;
        this.No = no;
        this.Depertman = departman;
    }

    public Calisan(string ad, string soyad)
    {
        this.Ad = ad;//this bu sınıfın elemanı olduğu için kullandık
        this.Soyad = soyad;

    }
    //overload işlemi
    public Calisan() { }
    public void CalisanBilgileri()
    {
        Console.WriteLine("Çalışan Adı:{0}", Ad);
        Console.WriteLine("Çalışan Soyadı:{0}", Soyad);
        Console.WriteLine("Çalısan Numarası:{0}", No);
        Console.WriteLine("Çalışan Departmanı:{0}", Depertman);
    }
}
}
//Kurucu metotlar:Bir sınıfın nesnesi oluşturulduğunda yani new ile yeni bir nesne oluşturulduğunuz da
////arka planda otmatik olarak çalışan metotlardır
///dolayısı ile bir nesne oluşturulduğunda otamatikmen arka planda yapılmasını istediğimiz bir nesne ayağa kalktığında
///varsa biz bunu kurucu metotlarla constacterlarla yapılırız
///Bir kurucu metot sınıf isimle aynı olmak zorundandı.classınla aynı olmak zorunda ismi
///kuru metotların erişim belirteçleri public olmak zorundadır
///kurucu metotların geri dönüşleri yoktur
///kuru fonsiyonların geri dönüş tipini yazmıyoruz
///birden fazla parametre alabilir yada hiç parametre almayabilir.
    }
}
