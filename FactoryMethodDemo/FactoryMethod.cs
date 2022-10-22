using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDemo
{
    // może posiadać już domyślną implementację
    abstract class Transport
    {
        public abstract IPaczka FactoryMethod();

        // logika np. przed dowiezieniem paczki możemy coś innego zrobić
        public string UtwórzTransport()
        {
            var paczka = FactoryMethod();
            /// inna logika z paczką, zapakowac paczkę
            var result = "Operacja: " + paczka.DowiezPaczke();
            return result;
        }
    }

    class DHL : Transport
    {
        // override - nadpisanie FactoryMethod ponieważ chcemy zwrócić inny typ
        public override IPaczka FactoryMethod()
        {
            return new Paczka1();
        }
    }
    class UPS : Transport
    {
        // override - nadpisanie FactoryMethod ponieważ chcemy zwrócić inny typ
        public override IPaczka FactoryMethod()
        {
            return new Paczka2();
        }
    }


    // nasz interfejs deklaruje metody którą wszystkie paczki muszą wykonać
    public interface IPaczka
    {
        string DowiezPaczke();
    }

    class Paczka1 : IPaczka
    {
        // implementacja interfejsu
        public string DowiezPaczke()
        {
            return "[dowieziona paczka 1]";
        }
    }

    class Paczka2 : IPaczka
    {
        // implementacja interfejsu
        public string DowiezPaczke()
        {
            return "[dowieziona paczka 2]";
        }
    }

    class Klient
    {
        // wywołujemy Main - bo klient chce wysłać dwoma różnymi przewożnikami 
        public void Main()
        {
            Console.WriteLine("Aplikacja używa DHL");
            KorzystajZFirmy(new DHL());

            Console.WriteLine("Aplikacja używa UPS");
            KorzystajZFirmy(new UPS());
        }

        public void KorzystajZFirmy(Transport transport)
        {
            Console.WriteLine("Nie wiem czym jest tutaj klasa transport, ale działa \n" + transport.UtwórzTransport());
        }
    }
}
