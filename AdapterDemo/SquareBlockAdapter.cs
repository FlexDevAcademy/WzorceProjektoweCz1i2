using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDemo
{
    internal class SquareBlockAdapter : RoundBlock
    {
        private SquareBlock _squareBlock;
        public SquareBlockAdapter(SquareBlock squareBlock):base(0)
        {
             _squareBlock = squareBlock;
        }

        public override double GetRadius()
        {
            return _squareBlock.GetDiagonal() / 2;
         }
    }
}
