using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone
{
    public class Phonebook_Database
    {
        private static List<Person> _phone;
        static Phonebook_Database()
        {
            _phone = new List<Person>();

            _phone.Add(new Person
            {
                Name = "Mustafa",
                Surname = "Arslan",
                Number = "12345678"
            });
            _phone.Add(new Person
            {
                Name = "Ali",
                Surname = "Arslan",
                Number = "11223344"
            });
            _phone.Add(new Person
            {
                Name = "Meriç",
                Surname = "Yilmaz",
                Number = "22334455"
            });
            _phone.Add(new Person
            {
                Name = "Derya",
                Surname = "Yilmaz",
                Number = "66778899"
            });
            _phone.Add(new Person
            {
                Name = "Yilmaz",
                Surname = "Sayar",
                Number = "55443322"
            });
        }

        public static List<Person> Phonebook { get => _phone; }
    }
}
