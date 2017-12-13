using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace project
{
    public class Plotpoint
    {
        public Plotpoint[] childPointList;
        public string text;
        Button textEditButton;

        public string getText()
        {
            return text;
        }

        public void setText(string text)
        {
            this.text = text;
        }

        public int countChoices()
        {
            return childPointList.Count();
        }

        public void initialize(string text, int choiceCount, Button textEditButton)
        {
            this.text = text;
            childPointList = new Plotpoint[choiceCount];
            this.textEditButton = textEditButton;
        }
        
    }
}
