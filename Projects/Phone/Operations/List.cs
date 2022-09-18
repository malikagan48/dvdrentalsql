using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone.Operations
{
    public class List
    {
        public void ListThePhoneBook()
        {
            Phonebook_Database.Phonebook.Sort((x, y) => string.Compare(x.Name, y.Surname));
            Console.WriteLine("Telefon Rehberi \n  **********************************************");

            foreach (var item in Phonebook_Database.Phonebook)
            {
                Console.WriteLine("isim: {0}", item.Name);
                Console.WriteLine("Soyisim: {0}", item.Surname);
                Console.WriteLine("Telefon Numarası: {0}", item.Number);
                Console.WriteLine("-");
            }
        }
    }
}
