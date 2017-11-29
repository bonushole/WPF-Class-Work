using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    class GameFile
    {
        List<Plotpoint> plotpoints;
        public GameFile()
        {
            plotpoints = new List<Plotpoint>();
        }

        public void addPlotpoint(Plotpoint plotpoint)
        {
            plotpoints.Add(plotpoint);
        }
    }
}
