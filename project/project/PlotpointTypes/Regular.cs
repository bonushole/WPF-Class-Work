using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace project
{
    class Regular : Plotpoint, AdvanceablePoint
    {
        public Regular(string text, int childList, Button textEditButton)
        {
            initialize(text, childList, textEditButton);
        }

        public Plotpoint nextPoint(int index)
        {
            return childPointList[index];
        }
    }
}
