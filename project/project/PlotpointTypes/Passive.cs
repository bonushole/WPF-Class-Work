﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace project
{
    class Passive : Plotpoint, AdvanceablePoint
    {
        public Passive(string text, int childList, Button textEditButton)
        {
            initialize(text, childList, textEditButton);
        }

        public Plotpoint nextPoint(int index)
        {
            return childPointList[0];
        }
            
    }
}
