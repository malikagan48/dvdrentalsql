using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projects
{
    internal class operators
    {
        Console.WriteLine("*****Atama ve İşlemli Atama*****");
            // Atama ve İşlemli Atama
            int y = 3;

        y = y + 2;
            Console.WriteLine(y);
            y += 2;
            Console.WriteLine(y);
            y /= 2;
            Console.WriteLine(y);

            int x = 3;
        x *= 2;
            Console.WriteLine(x);

            Console.WriteLine("*****Mantıksal Operatörler*****");
            // Mantıksal Operatörler
            // ||, &&, !
            
            bool isSucces = true;
        bool isCompletad = false;

            if(isSucces && isCompletad)
            Console.WriteLine("Perfect!");

             if(isSucces || isCompletad)
            Console.WriteLine("Great!");

             if(isSucces && !isCompletad)
            Console.WriteLine("Fine!");


            Console.WriteLine("*****İlişkisel Operatörler*****");
            // İlişkisel Operatörler
            // <, >, <=, >=, ==, !=

            int a = 3;
        int b = 4;

        bool sonuc = a < b;
        Console.WriteLine(sonuc);
            sonuc = a>b;
            Console.WriteLine(sonuc);
            sonuc = a<=b;
            Console.WriteLine(sonuc);
            sonuc = a>=b;
            Console.WriteLine(sonuc);
            sonuc = a==b;
            Console.WriteLine(sonuc);
            sonuc = a!=b;
            Console.WriteLine(sonuc);


            Console.WriteLine("*****Aritmatik Operatörler*****");
            // Aritmatik  Operatörler
            // /, *, +,-

            int sayi1 = 10;
        int sayi2 = 5;
        int sonuc1 = sayi1 + sayi2;
        Console.WriteLine(sonuc1);

            sonuc1 = sayi1-sayi2;
            Console.WriteLine(sonuc1);

            sonuc1 = sayi1* sayi2;
        Console.WriteLine(sonuc1);

            sonuc1 = sayi1/sayi2;
            Console.WriteLine(sonuc1);

            sonuc1 = ++sayi1; 
            Console.WriteLine(sonuc1);


            // % Mod Alma
            int sonuc3 = 20 % 3;
        Console.WriteLine(sonuc3 );

            
    }
}
