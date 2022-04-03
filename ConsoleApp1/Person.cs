using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.TelefonRehberi
{
    public class Person
    {
        private string name;
        private string surname;
        private string pNumber;

        public Person(string _name,string _surname, string _pNumber)
        {
            this.Name = _name;
            this.Surname = _surname;
            this.PNumber = _pNumber;
        }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string PNumber { get => pNumber; set => pNumber = value; }
    }
}
