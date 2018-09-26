using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRTSGame
{
    class FactoryBuilding
    {
        public Unit spawnUnit()
        {
            Random rnd = new Random();
            if rnd.Next(0, 2) == 0
                {
                MeleeUnit mU = new MeleeUnit(spawnPointX, spawnPointY, 100, -1, true, 1, this.faction, this.symbol, this.name);
                unitsToProduce--;
                return mU;
            }
            else
            {
                RangedUnit rU = new RangedUnit(spawnPointX, spawnPointY, 100, -1, true, 1, this.faction, this.symbol, this.name);
                unitsToProduce--;
                return mU;
            }
        }
    }
}
