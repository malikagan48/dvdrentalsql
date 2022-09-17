using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projects.for
{
    internal class forr
      {
    Console.Write("Bir sayı giriniz:");
            int sayaç = int.Parse(Console.ReadLine());
            for (int i = 1; i <= sayaç ; i++) 
            {
                if(i % 2 == 1)
                    Console.WriteLine(i);
            }


int tekToplam = 0;
int çiftToplam = 0;
            for (int i = 1; i <= 1000; i++)
            {
                if(i % 2 == 1)
                    tekToplam += i; 
                else
                    çiftToplam += i; 
            }
Console.WriteLine("Tek Toplam: " + tekToplam);
Console.WriteLine("Çift Toplam: " + çiftToplam);



for (int i = 1; i < 10; i++) 
{
    if (i == 4)
        break;
    Console.WriteLine(i);
}

for (int i = 1; i < 10; i++) 
    if (i == 4)
        continue;
    Console.WriteLine(i);
}
      }
}
