using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace MyRTSGame
{
    class MeleeUnit : Unit 
    {
        protected const int DAMAGE = 1;
        public MeleeUnit(int xPos, int yPos, int health, int speed, int attack, int attackRange, string faction, string symbol, string name )
            :base (xPos, yPos, health, speed, attack, attackRange, faction, symbol, name)
        {
            
        }
        public override void moveToPos(int XPos, int yPos)
        {
            if (xPos >= 0 && xPos < 20)
                xPos = XPos;
            if (yPos >= 0 && yPos < 20)
                yPos = YPos;

        }
        public override void combat(Unit enemy)
        {
            if (this.withinRange(enemy))
            {
                enemy.Health -= DAMAGE;
            }
        }
        public override bool withinRange(Unit enemy)
        {
            double distance, xSqr, ySqr;
            int intDistance;
            return true;

        }
        public override bool isDead()
        {
            return (this.Health > 0);
        }
        public override string toString()
        {
            string output = "x : " + xPos + Environment.NewLine
                + "y : " + yPos + Environment.NewLine
                + "Health : " + health + Environment.NewLine
                + "Speed : " + speed + Environment.NewLine
                + "Attack : " + (attack ? "Yes" : "No") + Environment.NewLine
                + "Attack Range : " + attackRange + Environment.NewLine
                + "Faction/Team : " + faction + Environment.NewLine
                + "Symbol : " + symbol + Environment.NewLine
                + "Name : " + name + Environment.NewLine;
            return output;
        }
        public override void save()
        {
            FileStream outFile = null;
            StreamWriter writer = null;
            try
            {
                outFile = new FileStream(@"Files\MeleeUnit.txt", FileMode.Append, FileAccess.Write);
                writer = new StreamWriter(outFile);

            }
            catch (Exception fe)
            {
                Debug.WriteLine("Melee.txt" + fe.Message);
            }
            finally
            {
                if (outFile != null);
                {
                    writer.Close();
                    outFile.Close();
                }
            }
            
        }
    }
}
