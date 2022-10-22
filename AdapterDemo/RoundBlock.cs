using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDemo
{
    internal class RoundBlock
    {
        private double _radius;

        public RoundBlock(double radius)
        {
            _radius = radius;
        }

        public virtual double GetRadius()
        {
            return _radius;
        }


    }
}
