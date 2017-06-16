using DungeonCrawl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dungeon_Crawl
{
    public partial class CombatWindow : Form
    {
        private bool attackButtonPressed = false;
        private bool specialButtonPressed = false;
        public CombatWindow()
        {
            InitializeComponent();
            System.Threading.Thread combatThread = new System.Threading.Thread(new System.Threading.ThreadStart(startTimer));
            combatThread.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("it works");
        }

        
        public void startTimer()
        {
            timer1.Start();
        }

        private void attackButton_Click(object sender, EventArgs e)
        {
            attackButtonPressed = true;
        }

        private void specialButton_Click(object sender, EventArgs e)
        {
            specialButtonPressed = true;
        }

        private void itemButton_Click(object sender, EventArgs e)
        {

        }

        private void fleeButton_Click(object sender, EventArgs e)
        {

        }
        #region timerHandlers
        private void timer1_Tick(object sender, EventArgs e)
        {
            CombatEngine.AttackQueue.Add(CombatEngine.PlayerTeam.ElementAt(0));
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            CombatEngine.AttackQueue.Add(CombatEngine.PlayerTeam.ElementAt(1));
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            CombatEngine.AttackQueue.Add(CombatEngine.PlayerTeam.ElementAt(2));
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            CombatEngine.AttackQueue.Add(CombatEngine.EnemyTeam.ElementAt(0));
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            CombatEngine.AttackQueue.Add(CombatEngine.EnemyTeam.ElementAt(1));
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            CombatEngine.AttackQueue.Add(CombatEngine.EnemyTeam.ElementAt(2));
        }
        #endregion
        #region pictureHandlers
        private void rightPictureBox1_Click(object sender, EventArgs e)
        {
            //to attack press the attack button or special button that switches the boolean to true and allows the target to be attacked
            if(attackButtonPressed)
            {
                CombatEngine.attack(CombatEngine.AttackQueue.ElementAt(0), CombatEngine.EnemyTeam.ElementAt(0));//takes the objects who's turn it is and attacks the target
                CombatEngine.AttackQueue.RemoveAt(0);//after the attack remove the first element in the queue 
                CombatEngine.AttackQueue.TrimExcess();//not sure if this is needed but i put it in to ensure the second element is now the first element
                attackButtonPressed = false;
                specialButtonPressed = false;
            }
            if(specialButtonPressed)
            {
                CombatEngine.useSpecial(CombatEngine.AttackQueue.ElementAt(0), CombatEngine.EnemyTeam.ElementAt(0));
                CombatEngine.AttackQueue.RemoveAt(0);
                CombatEngine.AttackQueue.TrimExcess();
                attackButtonPressed = false;
                specialButtonPressed = false;
            }
            
        }

        private void rightPictureBox2_Click(object sender, EventArgs e)
        {
            if (attackButtonPressed)
            {
                CombatEngine.attack(CombatEngine.AttackQueue.ElementAt(0), CombatEngine.EnemyTeam.ElementAt(1));
                CombatEngine.AttackQueue.RemoveAt(0);
                CombatEngine.AttackQueue.TrimExcess();
                attackButtonPressed = false;
                specialButtonPressed = false;
            }
            if (specialButtonPressed)
            {
                CombatEngine.useSpecial(CombatEngine.AttackQueue.ElementAt(0), CombatEngine.EnemyTeam.ElementAt(1));
                CombatEngine.AttackQueue.RemoveAt(0);
                CombatEngine.AttackQueue.TrimExcess();
                attackButtonPressed = false;
                specialButtonPressed = false;
            }
        }

        private void rightPictureBox3_Click(object sender, EventArgs e)
        {
            if (attackButtonPressed)
            {
                CombatEngine.attack(CombatEngine.AttackQueue.ElementAt(0), CombatEngine.EnemyTeam.ElementAt(2));
                CombatEngine.AttackQueue.RemoveAt(0);
                CombatEngine.AttackQueue.TrimExcess();
                attackButtonPressed = false;
                specialButtonPressed = false;
            }
            if (specialButtonPressed)
            {
                CombatEngine.useSpecial(CombatEngine.AttackQueue.ElementAt(0), CombatEngine.EnemyTeam.ElementAt(2));
                CombatEngine.AttackQueue.RemoveAt(0);
                CombatEngine.AttackQueue.TrimExcess();
                attackButtonPressed = false;
                specialButtonPressed = false;
            }
        }

        private void leftPictureBox1_Click(object sender, EventArgs e)
        {
            if (attackButtonPressed)
            {
                CombatEngine.attack(CombatEngine.AttackQueue.ElementAt(0), CombatEngine.PlayerTeam.ElementAt(0));
                CombatEngine.AttackQueue.RemoveAt(0);
                CombatEngine.AttackQueue.TrimExcess();
                attackButtonPressed = false;
                specialButtonPressed = false;
            }
            if (specialButtonPressed)
            {
                CombatEngine.useSpecial(CombatEngine.AttackQueue.ElementAt(0), CombatEngine.PlayerTeam.ElementAt(0));
                CombatEngine.AttackQueue.RemoveAt(0);
                CombatEngine.AttackQueue.TrimExcess();
                attackButtonPressed = false;
                specialButtonPressed = false;
            }
        }

        private void leftPictureBox2_Click(object sender, EventArgs e)
        {
            if (attackButtonPressed)
            {
                CombatEngine.attack(CombatEngine.AttackQueue.ElementAt(0), CombatEngine.PlayerTeam.ElementAt(1));
                CombatEngine.AttackQueue.RemoveAt(0);
                CombatEngine.AttackQueue.TrimExcess();
                attackButtonPressed = false;
                specialButtonPressed = false;
            }
            if (specialButtonPressed)
            {
                CombatEngine.useSpecial(CombatEngine.AttackQueue.ElementAt(0), CombatEngine.PlayerTeam.ElementAt(1));
                CombatEngine.AttackQueue.RemoveAt(0);
                CombatEngine.AttackQueue.TrimExcess();
                attackButtonPressed = false;
                specialButtonPressed = false;
            }
        }

        private void leftPictureBox3_Click(object sender, EventArgs e)
        {
            if (attackButtonPressed)
            {
                CombatEngine.attack(CombatEngine.AttackQueue.ElementAt(0), CombatEngine.PlayerTeam.ElementAt(2));
                CombatEngine.AttackQueue.RemoveAt(0);
                CombatEngine.AttackQueue.TrimExcess();
                attackButtonPressed = false;
                specialButtonPressed = false;
            }
            if (specialButtonPressed)
            {
                CombatEngine.useSpecial(CombatEngine.AttackQueue.ElementAt(0), CombatEngine.PlayerTeam.ElementAt(2));
                CombatEngine.AttackQueue.RemoveAt(0);
                CombatEngine.AttackQueue.TrimExcess();
                attackButtonPressed = false;
                specialButtonPressed = false;
            }
        }
        #endregion
    }
}
