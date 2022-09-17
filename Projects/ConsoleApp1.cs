using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projects
{
    internal class ConsoleApp1
    {
        Method instance = new Method();
 

        string param = "n";

        int n = instance.wrteScrn(param);

        int[] dizi = instance.wrteScrnArr(n);
        foreach(int cift in dizi)
        {
            if(cift % 2 == 0)
            {
                Console.Write(cift + " ");
            }
}




        int n = instance.wrteScr_n();
int m = instance.wrteScr_m();
int[] dizi = instance.wrteScrnArr(n);
foreach (int equltyordividing in dizi)
{
    if ((m == equltyordividing) || (m % equltyordividing == 0))
    {
        Console.Write(equltyordividing + " ");
    }

}



        int n = instance.wrteScr_n();
List<string> liste = new List<string>();

for (int k = 0; k < n; k++)
{
    string chr = instance.wrteScr_s(k + 1);
    liste.Add(chr);
}
liste.Reverse();
foreach (string str in liste)
{
    Console.Write(str + " ");
}

        string word = instance.wrteScr_s("ilk");
int wordCount = word.Length;
Console.Write("wordCount: " + wordCount);

    }


}

public class Method
{
    public int wrteScr_n()
    {

        Console.Write("Lütfen pozitif n sayısını giriniz: ");
        int n = Convert.ToInt32(Console.ReadLine());

        return n;
    }
    public int wrteScr_m()
    {

        Console.Write("Lütfen pozitif m sayısını giriniz: ");
        int m = Convert.ToInt32(Console.ReadLine());

        return m;
    }
    public int[] wrteScrnArr(int deger)
    {

        int[] arry = new int[deger];
        for (int i = 0; i < deger; i++)
        {
            Console.Write((i + 1) + ".n sayısını giriniz:");
            arry[i] = Convert.ToInt32(Console.ReadLine());
        }

        return arry;

    }

    public string wrteScr_s(int count)
    {

        Console.Write("Lütfen " + count + " kelime/cümleyi giriniz: ");
        string liste = Console.ReadLine();


        return liste;
    }
    public string wrteScr_s(string count)
    {

        Console.Write("Lütfen " + count + " kelime/cümleyi giriniz: ");
        string liste = Console.ReadLine();


        return liste;
    }
}
}
