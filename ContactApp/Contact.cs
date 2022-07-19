using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactApp
{
    class Contact
    {
        private int _number;
        public string Name { get; set; }
        public int Number 
        {
            get { return _number; }
            set
            {
                while(value.ToString().Length != 9)
                {
                    Console.WriteLine("Wrong number length, please enter new number");
                    value = int.Parse(Console.ReadLine());
                }
                _number = value;
            } 
        }

        public Contact(string name, int number)
        {
            Name = name;
            Number = number;
        }
    }
}
