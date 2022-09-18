using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone
{
    public class Person
    {
        private string name;
        private string surname;
        private string number;

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
       
        public string Number { get => number; set => number = value; }
    }
}
