using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDemo
{
    public class Director
    {
        private IBuilder _builder;

        public IBuilder Builder // ta wlasciwosc umozliwia nadawanie wartosci (zadan) do kazdej z instancji obiektu HouseBuilder
        {
            set { _builder = value; } // do tej zmiennej zapisywana jest kazda nowa instancja HouseBuilder, wykorzystywana przez obiekt Director
        }

        public void BuildMinimalViableProduct()
        {
            this._builder.BuildFloors();
            this._builder.BuildFloors();// przekazanie zadania dla Buildera, ktory bedzie budowal podloge
        }

        public void BuildFullFeaturedProduct()
        {
            this._builder.BuildFloors(); //jw, tylko inne zadania
            this._builder.BuildWalls();
            this._builder.BuildRoof();
        }
    }
}
