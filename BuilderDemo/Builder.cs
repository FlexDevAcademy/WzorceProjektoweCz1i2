namespace BuilderDemo
{

    // w tej klasie przypisane zostaja poszczegolne czynnosci/metody dla Builderow. "Rozkaz" wychodzi z klasy director, w ktorej zainicjowane sa metody (zadania) opisane w tej klasie
    // tu nastepuje rozbicie funkcjonalnosci na poszczegolne metody, ktore w naszym wypadku zarzadzane sa klasa Director

    public class HouseBuilder : IBuilder
    {
        private House _house = new House();

        public HouseBuilder() //przy kazdym utworzeniu nowej instancji tego obiektu, usuwane zostaja poprzednie wartosci aby moc przyjmowac kolejne elementy
        {
            this.Reset();
        }

        public void Reset()
        {
            this._house = new House();
        }
        // metody odpowiedzialne za wykonanie zadan (wpisanie do listy zadan) dla builderow
        public void BuildFloors()
        {
            this._house.Add("BuildFloors");
        }

        public void BuildWalls()
        {
            this._house.Add("BuildWalls");
        }

        public void BuildRoof()
        {
            this._house.Add("BuildRoof");
        }

        public House GetProduct() // zwraca zadania z listy (parts), ktore zostaly wykonane na kazdym z obiektow House
        {
            House result = this._house;

            this.Reset(); //wyczyszczenie obiektu House zanim utworzy sie nowy przed wykonywaniem kolejnych zadan

            return result;
        }
    }
}
  