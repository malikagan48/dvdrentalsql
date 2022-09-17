using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projects.Try_Catch
{
    internal class TrycatchFinally
    {
         try 
            {
                Console.WriteLine("Bir sayı giriniz:");
                int sayi = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Girmiş olduğunuz sayı: " + sayi);
            }
            catch(Exception ex) 
            {
                Console.WriteLine("Hata:" + ex.Message.ToString());
            }
            finally
            {
                Console.WriteLine("İşlem tamamlandı.");
            }
            try
            {
   
             int a = int.Parse("-123456789123");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Boş değer girdiniz!");
                Console.WriteLine(ex);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Veri tipi uygun değil!");
                Console.WriteLine(ex);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Çok küçük ya da çok büyük bir değer girdiniz!");
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("İşlem başarıyla tamamlandı.");
            }
          }
        }
