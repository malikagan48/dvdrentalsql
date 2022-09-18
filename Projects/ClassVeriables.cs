using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projects
{
    internal class ClassVeriables
    {
        Calisan calisan1 = new Calisan("Ayşe", "Kara", 543183, "İnsan kaynakları");//nesneye ayağı kaldırma işlemi

        calisan1.CalisanBilgileri();
            Console.WriteLine("**************************");
            Calisan calisan2 = new Calisan();
        calisan2.Ad = "sami";
            calisan2.Soyad = "yagmur";
            calisan2.No = 165463;
            calisan2.Depertman = "Geme development";

            calisan2.CalisanBilgileri();
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
    //overload işlemi
    public Calisan() { };
    public void CalisanBilgileri()
    {
        Console.WriteLine($"Çalışan Adı:{0}", Ad);
        Console.WriteLine($"Çalışan Soyadı:{0}", Soyad);
        Console.WriteLine($"Çalısan Numarası:{0}", No);
        Console.WriteLine($"Çalışan Departmanı:{0}", Depertman);
    }
}
}
    }
}
