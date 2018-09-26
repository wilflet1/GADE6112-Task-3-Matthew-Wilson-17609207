using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRTSGame
{
    class ResourceBuilding
    {




        public void generateResources()
        {
            if (resourcesRemaining >= 0)
                resourcesRemaining -= resourcesPerGameTick;
        }
    }
}
