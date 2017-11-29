using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    class Passive : Plotpoint
    {
        public Plotpoint nextPoint()
        {
            return childPointList[0];
        }
            
    }
}
