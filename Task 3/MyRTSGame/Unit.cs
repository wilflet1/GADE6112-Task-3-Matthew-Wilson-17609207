using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRTSGame
{
    abstract class Unit
    {
        protected int xPos, yPos, health, speed, attackRange;
        protected string faction, symbol, name;
        protected bool attack;
        public Unit ()
        {
             
        }
        public Unit(int XPos, int YPos, int Health, int Speed, bool Attack, int AttackRange, string Faction, string Symbol, string Name)
        {
            xPos = XPos;
            yPos = YPos;
            health = Health;
            speed = Speed;
            attack = Attack;
            attackRange = AttackRange;
            faction = Faction;
            symbol = Symbol;
            name = Name
        }
        ~Unit()
        {
        }

        abstract public void moveToPos(int x, int y);
        abstract public void combat(Unit enemy);
        abstract public bool withinRange(Unit enemy);
        abstract public Unit nearestEnemy(List<Unit> u);
        abstract public bool isDead();
        abstract public string toString();
        abstract public void save();

        #region Accessors

        abstract public int XPos { get; set; }
        abstract public int YPos { get; set; }
        abstract public int Health { get; set; }
        abstract public int AttackDamage { get; set; }
        abstract public int Speed { get; set; }
        abstract public int AttackRange { get; set; }

        #endregion
    }
}
