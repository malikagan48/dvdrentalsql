using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone.Operations
{
    public class Save
    {
        public void SavePerson()
        {
            Console.Write("Lütfen isim giriniz             : ");
            string name = Console.ReadLine();

            Console.Write("Lütfen soyisim giriniz          : ");
            string surname = Console.ReadLine();

            Console.Write("Lütfen telefon numarası giriniz : ");
            string number = Console.ReadLine();

            Person person = new Person();
            person.Name = name;
            person.Surname = surname;
            person.Number = number;

            Phonebook_Database.Phonebook.Add(person);

            Console.WriteLine("Kişi kaydı yapılmıştır..");
        }
    }
}
