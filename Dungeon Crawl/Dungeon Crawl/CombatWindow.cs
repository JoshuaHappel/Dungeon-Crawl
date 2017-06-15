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

        private void timer1_Tick(object sender, EventArgs e)
        {
            Console.WriteLine("timer tick");
        }
        public void startTimer()
        {
            timer1.Start();
        }
    }
}
