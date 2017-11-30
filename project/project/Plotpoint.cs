using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace project
{
    class Plotpoint
    {
        protected List<Plotpoint> childPointList;
        public string text;
        Button textEditButton;

        public string getText()
        {
            return text;
        }
        public void initialize(string text, List<Plotpoint> childPoints, Button textEditButton)
        {
            this.text = text;
            childPointList = childPoints;
            this.textEditButton = textEditButton;
        }
    }
}
