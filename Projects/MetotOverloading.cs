using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projects
{
    internal class MetotOverloading
    {
        string sayi = "999";
        int outSayi;
        bool sonuc = int.TryParse(sayi, out outSayi);
            if(sonuc)
            {
                Console.WriteLine("Başarılı!");
                Console.WriteLine(outSayi);
            }
            else
            {
                Console.WriteLine("Başarısız!");
                
            }

Metotlar instance = new Metotlar();
instance.Topla(4, 5, out int toplamSonucu);
Console.WriteLine(toplamSonucu);
//Method Aşırı Yükleme--Overloading

string ifade = "sami yagmur";
instance.EkranYazdır(ifade);
instance.EkranYazdır("Sami ", "yagmur");

            //Metot Imzası
            //metotAdı + parametre sayisi + parametre tipi
        }
    }
    class Metotlar
{
    public void Topla(int a, int b, out int toplam)
    {
        toplam = a + b;
    }
    public void EkranYazdır(string veri)
    {
        Console.WriteLine(veri);
    }
  
    public void EkranYazdır(int veri)
    {
        Console.WriteLine(veri);
    }

    public void EkranYazdır(string veri1, string veri2)
    {
        Console.WriteLine(veri1 + veri2);
    }
}
}
