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
    
    public partial class PlayerInfoScreen : Form
    {
        private Item usedItem;
        private List<Panel> panels = new List<Panel>();
        private Player play;
        public Panel Panel1
        {
            get
            {
                return panel1;
            }
            set
            {
                panel1 = value;
            }
        }
        public Player Play
        {
            get
            {
                return play;
            }

            set
            {
                play = value;
                displayParty();
                displayInventory();
            }
        }
        public PlayerInfoScreen()
        {
            InitializeComponent();
        }
        public void displayInventory()
        {
            foreach(Item i in play.Items)
            {
                inventoryListBox.Items.Add(i.ToString());
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form1.returnToOriginalSize();
            Owner.Controls.Remove(panel1);
            foreach(Control c in Owner.Controls)
            {
                c.Visible = true;
            }
        }

        public void displayParty()
        {
            displayPlayer();
            displayAlly1();
            displayAlly2();
        }
        public void displayPlayer()
        {
            nameLabel.Text = Play.Name;
            healthLabel.Text = "Health: " + Play.HP + "";
            equippedArmorLabel.Text ="Equipped Armor: " + Play.EquippedArmor + "";
            equippedWeaponLabel.Text ="Equipped Weapon: " + Play.EquippedWeapon + "";       }
        public void displayAlly1()
        {
            try
            {
                if (Play.Party[0] != null)
                {
                    label4.Text = Play.Party[0].Name;
                    label3.Text = "Health: " + Play.Party[0].HP + "";
                    label2.Text = "Equipped Weapon: " + Play.Party[0].EquippedWeapon + "";
                    label1.Text = "Equipped Armor: " + Play.Party[0].EquippedArmor + "";
                }
            }
            catch (Exception ex)
            {
                label4.Visible = false;
                label3.Visible = false;
                label2.Visible = false;
                label1.Visible = false;
                pictureBox2.Visible = false;
            }
        }
        public void displayAlly2()
        {
            try
            {


                if (Play.Party[1] != null)
                {
                    label8.Text = Play.Party[1].Name;
                    label7.Text = "Health: " + Play.Party[1].HP + "";
                    label6.Text = "Equipped Weapon: " + Play.Party[1].EquippedWeapon + "";
                    label5.Text = "Equipped Armor: " + Play.Party[1].EquippedArmor + "";
                }
            }
            catch (Exception ex)
            {
                label8.Visible = false;
                label7.Visible = false;
                label6.Visible = false;
                label5.Visible = false;
                pictureBox3.Visible = false;
            }
        }

        private void useButton_Click(object sender, EventArgs e)
        {
            if(inventoryListBox.SelectedIndex != -1)
            {
                foreach (Item i in play.Items)
                {
                    if(i.ItemName.Equals(inventoryListBox.SelectedItem.ToString()))
                    {
                        usedItem = i;
                        break;
                    }
                }
            }
        }
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            usedItem.use(play, play);
            displayParty();
            displayInventory();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try {
                usedItem.use(play.Party[0], play);
            }
            catch(Exception ex)
            {

            }
            displayParty();
            displayInventory();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            try {
                usedItem.use(play.Party[1], play);
            }
            catch(Exception ex)
            {

            }
            displayParty();
            displayInventory();

        }
    }
}
