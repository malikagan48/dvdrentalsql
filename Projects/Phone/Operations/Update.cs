using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone.Operations
{
    public class Update
    {
        public void UpdatePerson()
        {
            Person person = new Person();

            while (true)
            {
                Console.WriteLine("Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz:");
                string guncellenecekKisi = Console.ReadLine();

                if (Phonebook_Database.Phonebook.Any(x => x.Name == guncellenecekKisi || x.Surname == guncellenecekKisi))
                {
                    person = Phonebook_Database.Phonebook.Find(x => x.Name == guncellenecekKisi || x.Surname == guncellenecekKisi);

                    Console.Write("Yeni numarayı giriniz:");

                    person.Number = Console.ReadLine();

                    Console.Write("Güncelleme işlemi başarıyla tamamlanmıştır.");
                    break;
                }
                else
                {
                    Console.WriteLine(" Aradığınız kriterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız. \n* Güncellemeyi sonlandırmak için : (1) \n* Yeniden denemek için      : (2)");
                    int n = int.Parse(Console.ReadLine());
                    if (n == 1)
                    {
                        break;
                    }
                }
            }
        }
    }
}
