using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDemo
{
    public class House
    {
        private List<object> _parts = new List<object>();

        public void Add(string part) // ta metoda umozliwia dodawanie zadan builderow do listy
        {
            this._parts.Add(part);
        }

        public string ListParts() // metoda zwraca wartosci wszystkich metod, ktore zostały wywołane dla danego przypadku, rodzielone przecinkami
        {
            string str = string.Empty;

            for (int i = 0; i < this._parts.Count; i++)
            {
                str += this._parts[i] + ", ";
            }

            str = str.Remove(str.Length - 2); // usuwanie przecinka ze spacja na koncu zwracanego stringa

            return "House parts: " + str + "\n";
        }
    }
}
