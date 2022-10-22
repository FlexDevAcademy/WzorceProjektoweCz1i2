namespace BuilderDemo
{
    public interface IBuilder
    {
        void BuildFloors();

        void BuildWalls();

        void BuildRoof();
    }

    public class HouseBuilder : IBuilder
    {
        private House _house = new House();

        public HouseBuilder()
        {
            this.Reset();
        }

        public void Reset()
        {
            this._house = new House();
        }
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

        public House GetProduct()
        {
            House result = this._house;

            this.Reset();

            return result;
        }
    }

    public class House
    {
        private List<object> _parts = new List<object>();

        public void Add(string part)
        {
            this._parts.Add(part);
        }

        public string ListParts()
        {
            string str = string.Empty;

            for (int i = 0; i < this._parts.Count; i++)
            {
                str += this._parts[i] + ", ";
            }

            str = str.Remove(str.Length - 2);

            return "House parts: " + str + "\n";
        }
    }

    public class Director
    {
        private IBuilder _builder;

        public IBuilder Builder
        {
            set { _builder = value; }
        }

        public void BuildMinimalViableProduct()
        {
            this._builder.BuildFloors();
        }

        public void BuildFullFeaturedProduct()
        {
            this._builder.BuildFloors();
            this._builder.BuildWalls();
            this._builder.BuildRoof();
        }
    }
}
