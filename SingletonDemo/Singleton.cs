using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDemo
{
    //Sealed - klasa nie może być dziedziczona
    public sealed class Singleton
    {
        private static int counter = 0;

        //pewność, że tylko jedna instancja jest tworzona
        private static Singleton instance = null;

        private Singleton()
        {
            counter++;
            Console.WriteLine("Counter value " + counter.ToString());
        }

        public static Singleton GetInstance
        {
            get
            {
                // sprawdzamy czy instancja jest null
                if (instance == null)
                {
                    //jeśli tak, utwórz instancję
                    instance = new Singleton();
                }
                return instance;
            }
        }
        // używamy tej metody poza klasą singleton
        public void WypiszSzczególy(string wiadomosc)
        {
            Console.WriteLine(wiadomosc);
        }
    }

}
