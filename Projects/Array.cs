using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projects
{
    internal class Array
    {
        int[] sayiDizisi = { 23, 12, 4, 86, 72, 3, 11, 17 };

        Console.WriteLine("*****Sırasız Liste*****");
            foreach (var say in sayiDizisi)
                    Console.WriteLine(say);
            
            
            Console.WriteLine("*****Sıralı Liste*****");
            Array.Sort(sayiDizisi);            
            foreach (var say in sayiDizisi)
                    Console.WriteLine(say);
            
            //clear
            Console.WriteLine("*****Array Clear*****");
            //2.indexten itibaren 2 elemanı o yapar.
            Array.Clear(sayiDizisi,2,2);
            foreach (var say in sayiDizisi)
                    Console.WriteLine(say);

            //Reverse
            Console.WriteLine("*****Array Reverse*****");
            Array.Reverse(sayiDizisi);
            foreach (var say in sayiDizisi)
                    Console.WriteLine(say);
            
            //IndexOf
            Console.WriteLine("*****Array IndexOf*****");
            Console.WriteLine(Array.IndexOf(sayiDizisi,23));
            
            //Resize
            Console.WriteLine("*****Array Resize*****");
            Array.Resize<int>(ref sayiDizisi,9);
            sayiDizisi[8] = 99;
            
            foreach (var say in sayiDizisi)
                    Console.Write(say+" ");
    }
}
