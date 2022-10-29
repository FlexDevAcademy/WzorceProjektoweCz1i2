using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDemo
{
    // interfejs wskazuje czynności jakie bedzie moze wykonywac kazdy Builder
    public interface IBuilder
    {
            void BuildFloors();

            void BuildWalls();

            void BuildRoof();
        
    }
}


