using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDemo
{
    class RoundHole
        
    {
        private double _radius;

        public RoundHole(double radius)
        {
            _radius = radius;
        }

        public bool DoesFit(RoundBlock roundBlock)
        {
            if (_radius > roundBlock.GetRadius())
            {
                return true;
            }

            return false;
        }
    }


}
