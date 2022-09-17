using System;

namespace Projects
{
    class Project
    {
        static void Main(string[] args)
        { //String Example
            string str1 = "Mustafa ali kağan";
            string str2 = "Küçük";
            string str3 = str1 + " " + str2;
            Console.WriteLine(str3);
            //Integer Example
            int int1 = 3;
            int int2 = 5;
            int int3 = int1 + int2;
            Console.WriteLine(int3);
            //Boolean Example
            bool k = 5 < 4;
            Console.WriteLine(k);
            //DateTime example
            string h_m = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(h_m);
            // Implicit Conversion (Unconscious/Closed Conversion) --> The machine makes the translation.
            Console.WriteLine("#Implicit#");


            //Assigning
            int y = 4;
            y = y + 2;
            Console.WriteLine(y);
            y /= 2;
            Console.WriteLine(y);
            y *= 6;
            Console.WriteLine(y);

            //Logical Operators
            bool FirstCondition = true;
            bool SecondCondition = false;
            if (FirstCondition && SecondCondition)
            {
                Console.WriteLine(true);
            }
            else if (FirstCondition || SecondCondition)
            {
                Console.WriteLine("maybe");
            }
            else
            {
                Console.WriteLine(false);
            }

            bool sonuc;
            int Fnum = 9;
            int Snum = 10;
            sonuc = Fnum < Snum;
            Console.WriteLine(sonuc);
            sonuc = Snum < Fnum;
            Console.WriteLine(sonuc);
            sonuc = Fnum >= Snum;
            Console.WriteLine(sonuc);
            sonuc = Fnum <= Snum;
            Console.WriteLine(sonuc);
            sonuc = Fnum != Snum;
            Console.WriteLine(sonuc);

            //Arithmetic Operators
            int result;
            int a = 1241;
            int b = 134;
            result = a + b;
            Console.WriteLine(result);
            result = a * b;
            Console.WriteLine(result);
            result = a - b;
            Console.WriteLine(result);
            result = a / b;
            Console.WriteLine(result);
            result = a % b;
            Console.WriteLine(result);




            byte l = 5;
            sbyte p = 30;
            short c = 10;

            int d = p + l + c; // If there was a capacity inequality, this operation would not be possible if d was smaller.
            Console.WriteLine("d: " + d);

            long h = d;
            Console.WriteLine("h: " + h);

            float i = h;
            Console.WriteLine("i: " + i);

            string e = "Ceren";
            char f = 'k';
            object g = e + f + p; // Everything we write in object type can be combined.
            Console.WriteLine("g: " + g);


            // Explicit Transformation (Conscious/Explicit Transformation) --> The machine cannot perform these transformations by itself.

            Console.WriteLine("#Explicit#");

            int x = 4;
            byte q = (byte)x;
            Console.WriteLine("y= " +q);

            int z = 100;
            byte t = (byte)z;
            Console.WriteLine("t= " + t);

            float w = 10.3f;
            byte v = (byte)w; // When converting 10.3 to bytes, it rounds up to 10.
            Console.WriteLine("v= " + v);

            // ToString Methods
            Console.WriteLine("#ToString Metodu#");

            int xx = 6;
            string yy = xx.ToString();
            Console.WriteLine("yy= " + yy);

            string zz = 12.5f.ToString();
            Console.WriteLine("zz= " + zz);

            //System.Convert Class
            Console.WriteLine("#System.Convert Sınıfı#");

            string s1 = "10", s2 = "20";
            int sayi1, sayi2;
            int toplam;

            sayi1 = Convert.ToInt32(s1);
            sayi2 = Convert.ToInt32(s2);

            toplam = sayi1 + sayi2;
            Console.WriteLine("Toplam= " + toplam);

            //Parse Methods
            Console.WriteLine("#Parse Metodu#");
            ParseMetod();
        }
        public static void ParseMetod()
        {
            string metin1 = "10";
            string metin2 = "10.25";

            int rakam1;
            double double1;

            rakam1 = Int32.Parse(metin1);
            Console.WriteLine("rakam1= " + rakam1);

            double1 = Double.Parse(metin2);
            Console.WriteLine("double1= " + double1);
        }
    }
}
