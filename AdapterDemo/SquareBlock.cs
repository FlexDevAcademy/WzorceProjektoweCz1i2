using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDemo
{
    internal class SquareBlock
    {
        private double _diagonal;

        public SquareBlock(double diagonal)
        {
            _diagonal = diagonal;
        }

        public double GetDiagonal()
        {
            return _diagonal;
        }
    }
}
