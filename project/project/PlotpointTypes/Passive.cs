using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace project
{
    class Passive : Plotpoint
    {
        public Passive(string text, List<Plotpoint> childList, Button textEditButton)
        {
            initialize(text, childList, textEditButton);
        }

        public Plotpoint nextPoint()
        {
            return childPointList[0];
        }
            
    }
}
