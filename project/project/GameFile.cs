using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    class GameFile
    {
        public List<Plotpoint> plotpoints;
        public GameFile()
        {
            plotpoints = new List<Plotpoint>();
        }

        public int addPlotpoint(Plotpoint plotpoint)
        {
            plotpoints.Add(plotpoint);
            return plotpoints.Count;
        }
        public Plotpoint getPoint(int index)
        {
            return plotpoints[index];
        }
    }
}
