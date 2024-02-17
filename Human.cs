using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasy
{
    class Human
    {
        public string name = "Simon";
        public string surname = "Wojtowicz";

        public void PrzedstawSie()
        {
            Console.Write("Mam na imie" + " " + name);
            Console.Write(" " + "a na nazwisko" + " " + surname);
        }
    }
}
