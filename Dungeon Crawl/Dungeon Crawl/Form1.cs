using System;
using System.Drawing;
using System.Windows.Forms;
using DungeonCrawl.UnitClasses;
using Dungeon_Crawl;
/**
* Joshua Happel
* 12.8.2016
* CSC 253 C# 
* M6P1_happeljoshua
*/
namespace DungeonCrawl
{
    public partial class Form1 : Form
    {
        private Player player;
        private Ally ally1;
        private Ally ally2;
        private MobileObject enemy1;
        private MobileObject enemy2;
        private MobileObject enemy3;
        private MobileObject active;
        private MobileObject target;
        private Dungeon dung;
        private int oldXCoor = 0, oldYCoor = 0;
        private Random rand1 = new Random((int)DateTime.Now.Ticks & 0x0000FFFF);

        public Player Player
        {
            get
            {
                return player;
            }

            set
            {
                player = value;
            }
        }
        public Ally Ally1
        {
            get
            {
                return ally1;
            }

            set
            {
                ally1 = value;
            }
        }
        public Ally Ally2
        {
            get
            {
                return ally2;
            }

            set
            {
                ally2 = value;
            }
        }
        public MobileObject Enemy1
        {
            get
            {
                return enemy1;
            }

            set
            {
                enemy1 = value;
            }
        }
        public MobileObject Enemy2
        {
            get
            {
                return enemy2;
            }

            set
            {
                enemy2 = value;
            }
        }
        public MobileObject Enemy3
        {
            get
            {
                return enemy3;
            }

            set
            {
                enemy3 = value;
            }
        }
        public Form1()
        {
            player = new Player();
            dung = new Dungeon(Player);
            InitializeComponent();
            roomStuff();
            outputLabel.Text = player.ToString();
        }

        private void northButton1_Click(object sender, EventArgs e)
        {
            Player.getMap(this);
            Player.go("north", dung);
            roomStuff();
        }

        private void westButton3_Click(object sender, EventArgs e)
        {
            Player.getMap(this);
            Player.go("west", dung);
            roomStuff();

        }

        private void southButton2_Click(object sender, EventArgs e)
        {
            Player.getMap(this);
            Player.go("south", dung);
            roomStuff();

        }

        private void eastButton4_Click(object sender, EventArgs e)
        {
            Player.getMap(this);
            Player.go("east", dung);
            roomStuff();

        }
        private void Interact_Click(object sender, EventArgs e)
        {
            if (roomListBox.SelectedIndex != -1)
            {
                player.interact(roomListBox.SelectedItem.ToString(), dung);
            }
            roomStuff();
            displayInventory();
        }

        private void attackButton_Click(object sender, EventArgs e)
        {
            if (targetEnemy1Radio.Checked)
            {
                active.attack(enemy1);
            }
            if (targetEnemy2Radio.Checked)
            {
                active.attack(enemy2);
            }
            if (targetEnemy3Radio.Checked)
            {
                active.attack(enemy3);
            }
            attackButton.Enabled = false;
            specialButton.Enabled = false;
            inventoryButton.Enabled = false;
            displayCombatants();
            if (checkStopCombat() == false)
            {
                playerLabel.BackColor = Color.White;
                ally1Label.BackColor = Color.White;
                ally2Label.BackColor = Color.White;
                chooseActive();
            }
        }

        private void specialButton_Click(object sender, EventArgs e)
        {
            if(active.Class.FriendlySpecial)
            {
                if (targetPlayerRadio.Checked)
                {
                    active.useSpecial(player);
                }
                if (targetAlly1Radio.Checked)
                {
                    active.useSpecial(ally1);
                }
                if (targetAlly2Radio.Checked)
                {
                    active.useSpecial(ally2);
                }
            }
            else
            {
                if (targetEnemy1Radio.Checked)
                {
                    active.useSpecial(enemy1);
                }
                if (targetEnemy2Radio.Checked)
                {
                    active.useSpecial(enemy2);
                }
                if (targetEnemy3Radio.Checked)
                {
                    active.useSpecial(enemy3);
                }
            }
            if (active.Class != null)
            {
                if (active.Class is Fighter)
                {
                    specialButton.Enabled = false;
                    displayCombatants();
                }
                else
                {
                    attackButton.Enabled = false;
                    specialButton.Enabled = false;
                    inventoryButton.Enabled = false;
                    displayCombatants();
                    if (checkStopCombat() == false)
                    {
                        chooseActive();
                    }
                }
            }
            else
            {
                attackButton.Enabled = false;
                specialButton.Enabled = false;
                inventoryButton.Enabled = false;
                displayCombatants();
                if (checkStopCombat() == false)
                {
                    playerLabel.BackColor = Color.White;
                    ally1Label.BackColor = Color.White;
                    ally2Label.BackColor = Color.White;
                    chooseActive();
                }
            }
        }

        public void chooseActive()
        {
            int totalSpeed = 0;
            totalSpeed += player.Speed;
            if (ally1 != null)
            {
                if (ally1.HP >= 0)
                {
                    totalSpeed += ally1.Speed;
                }
                if (ally1.HP <= 0)
                {
                    ally1.Speed = 0;
                }
            }
            else
            {
                ally1 = new Ally();
            }
            if (ally2 != null)
            {
                if (ally2.HP > 0)
                {
                    totalSpeed += ally2.Speed;
                }
                if (ally2.HP <= 0)
                {
                    ally2.Speed = 0;
                }
            }
            else
            {
                ally2 = new Ally();
            }
            if (enemy1 != null)
            {
                if (enemy1.HP > 0)
                {
                    totalSpeed += enemy1.Speed;
                }
                if(enemy1.HP <= 0)
                {
                    enemy1.Speed = 0;
                }
            }
            else
            {
                enemy1 = new MobileObject();
            }
            if (enemy2 != null)
            {
                if (enemy2.HP >= 0)
                {
                    totalSpeed += enemy2.Speed;
                }
                if (enemy2.HP <= 0)
                {
                    enemy2.Speed = 0;
                }
            }
            else
            {
                enemy2 = new MobileObject();
            }
            if (enemy3 != null)
            {
                if (enemy3.HP >= 0)
                {
                    totalSpeed += enemy3.Speed;
                }
                if (enemy3.HP <= 0)
                {
                    enemy3.Speed = 0;
                }
            }
            else
            {
                enemy3 = new MobileObject();
            }
            int choosen = rand1.Next(totalSpeed);
            if (choosen <= player.Speed)
            {
                active = player;
                playerLabel.BackColor = Color.Red;
                attackButton.Enabled = true;
                specialButton.Enabled = true;
                inventoryButton.Enabled = true;
            }
            if (choosen > player.Speed && choosen <= (ally1.Speed + player.Speed))
            {
                if (ally1 != null)
                    if (ally1.HP >= 0)
                    {
                        active = ally1;
                        ally1Label.BackColor = Color.Red;
                        attackButton.Enabled = true;
                        specialButton.Enabled = true;
                        inventoryButton.Enabled = true;
                    }
            }
            if (choosen > (player.Speed + ally1.Speed) && choosen <= (ally1.Speed + player.Speed + ally2.Speed))
            {
                if (ally2 != null)
                    if (ally2.HP >= 0)
                    {
                        active = ally2;
                        ally2Label.BackColor = Color.Red;
                        attackButton.Enabled = true;
                        specialButton.Enabled = true;
                        inventoryButton.Enabled = true;
                    }
            }
            if (choosen > (player.Speed + ally1.Speed + ally2.Speed) && choosen <= (ally1.Speed + player.Speed + ally2.Speed + enemy1.Speed))
            {
                if (enemy1 != null)
                    if (enemy1.HP >= 0)
                    {
                        active = enemy1;
                        findTarget();
                        active.attack(target);
                        displayCombatants();
                        chooseActive();

                    }
            }
            if (choosen > (player.Speed + ally1.Speed + ally2.Speed + enemy1.Speed) && choosen <= (enemy2.Speed + ally1.Speed + player.Speed + ally2.Speed + enemy1.Speed))
            {
                if (enemy2 != null)
                    if (enemy2.HP >= 0)
                    {
                        active = enemy2;
                        findTarget();
                        active.attack(target);
                        displayCombatants();
                        chooseActive();

                    }
            }
            if (choosen > (enemy2.Speed + player.Speed + ally1.Speed + ally2.Speed + enemy1.Speed) && choosen <= (enemy3.Speed + enemy2.Speed + ally1.Speed + player.Speed + ally2.Speed + enemy1.Speed))
            {
                if (enemy3 != null)
                    if (enemy3.HP >= 0)
                    {
                        active = enemy3;
                        findTarget();
                        active.attack(target);
                        displayCombatants();
                        chooseActive();
                    }
            }
        }
        
        private void inventoryButton_Click(object sender, EventArgs e)
        {
            if (inventoryListBox.SelectedIndex != -1)
            {
                if (inventoryListBox.SelectedIndex != -1)
                {
                    player.outOfCombatUse(inventoryListBox.SelectedItem.ToString());
                    displayCombatants();
                }
                
            }
        }
        public void startCombat()
        {
            navigationGroupBox.Visible = false;
            combatGroupBox.Visible = true;
            groupBox1.Visible = false;
            inventoryListBox.Items.Clear();
            chooseActive();
            displayCombatants();
            CombatWindow cw = new CombatWindow();
            cw.Show();
        }
        public void blah()
        {
            CombatWindow cw = new CombatWindow();
            cw.Show();
        }
        public void updatePosition(int xCoor, int yCoor)
        {
            if (oldXCoor == 0)
            {
                if (oldYCoor == 0)
                {
                    label00.BackColor = Color.Gray;
                }
                if (oldYCoor == 1)
                {
                    label01.BackColor = Color.Gray;
                }
                if (oldYCoor == 2)
                {
                    label02.BackColor = Color.Gray;
                }
                if (oldYCoor == 3)
                {
                    label03.BackColor = Color.Gray;
                }
                if (oldYCoor == 4)
                {
                    label04.BackColor = Color.Gray;
                }
            }
            if (oldXCoor == 1)
            {
                if (oldYCoor == 0)
                {
                    label10.BackColor = Color.Gray;
                }
                if (oldYCoor == 1)
                {
                    label11.BackColor = Color.Gray;
                }
                if (oldYCoor == 2)
                {
                    label12.BackColor = Color.Gray;
                }
                if (oldYCoor == 3)
                {
                    label13.BackColor = Color.Gray;
                }
                if (oldYCoor == 4)
                {
                    label14.BackColor = Color.Gray;
                }
            }
            if (oldXCoor == 2)
            {
                if (oldYCoor == 0)
                {
                    label20.BackColor = Color.Gray;
                }
                if (oldYCoor == 1)
                {
                    label21.BackColor = Color.Gray;
                }
                if (oldYCoor == 2)
                {
                    label22.BackColor = Color.Gray;
                }
                if (oldYCoor == 3)
                {
                    label23.BackColor = Color.Gray;
                }
                if (oldYCoor == 4)
                {
                    label24.BackColor = Color.Gray;
                }
            }
            if (oldXCoor == 3)
            {
                if (oldYCoor == 0)
                {
                    label30.BackColor = Color.Gray;
                }
                if (oldYCoor == 1)
                {
                    label31.BackColor = Color.Gray;
                }
                if (oldYCoor == 2)
                {
                    label32.BackColor = Color.Gray;
                }
                if (oldYCoor == 3)
                {
                    label33.BackColor = Color.Gray;
                }
                if (oldYCoor == 4)
                {
                    label34.BackColor = Color.Gray;
                }
            }
            if (oldXCoor == 4)
            {
                if (oldYCoor == 0)
                {
                    label40.BackColor = Color.Gray;
                }
                if (oldYCoor == 1)
                {
                    label41.BackColor = Color.Gray;
                }
                if (oldYCoor == 2)
                {
                    label42.BackColor = Color.Gray;
                }
                if (oldYCoor == 3)
                {
                    label43.BackColor = Color.Gray;
                }
                if (oldYCoor == 4)
                {
                    label44.BackColor = Color.Gray;
                }
            }
            if (xCoor == 0)
            {
                if (yCoor == 0)
                {
                    label00.BackColor = Color.Black;
                }
                if (yCoor == 1)
                {
                    label01.BackColor = Color.Black;
                }
                if (yCoor == 2)
                {
                    label02.BackColor = Color.Black;
                }
                if (yCoor == 3)
                {
                    label03.BackColor = Color.Black;
                }
                if (yCoor == 4)
                {
                    label04.BackColor = Color.Black;
                }
            }
            if (xCoor == 1)
            {
                if (yCoor == 0)
                {
                    label10.BackColor = Color.Black;
                }
                if (yCoor == 1)
                {
                    label11.BackColor = Color.Black;
                }
                if (yCoor == 2)
                {
                    label12.BackColor = Color.Black;
                }
                if (yCoor == 3)
                {
                    label13.BackColor = Color.Black;
                }
                if (yCoor == 4)
                {
                    label14.BackColor = Color.Black;
                }
            }
            if (xCoor == 2)
            {
                if (yCoor == 0)
                {
                    label20.BackColor = Color.Black;
                }
                if (yCoor == 1)
                {
                    label21.BackColor = Color.Black;
                }
                if (yCoor == 2)
                {
                    label22.BackColor = Color.Black;
                }
                if (yCoor == 3)
                {
                    label23.BackColor = Color.Black;
                }
                if (yCoor == 4)
                {
                    label24.BackColor = Color.Black;
                }
            }
            if (xCoor == 3)
            {
                if (yCoor == 0)
                {
                    label30.BackColor = Color.Black;
                }
                if (yCoor == 1)
                {
                    label31.BackColor = Color.Black;
                }
                if (yCoor == 2)
                {
                    label32.BackColor = Color.Black;
                }
                if (yCoor == 3)
                {
                    label33.BackColor = Color.Black;
                }
                if (yCoor == 4)
                {
                    label34.BackColor = Color.Black;
                }
            }
            if (xCoor == 4)
            {
                if (yCoor == 0)
                {
                    label40.BackColor = Color.Black;
                }
                if (yCoor == 1)
                {
                    label41.BackColor = Color.Black;
                }
                if (yCoor == 2)
                {
                    label42.BackColor = Color.Black;
                }
                if (yCoor == 3)
                {
                    label43.BackColor = Color.Black;
                }
                if (yCoor == 4)
                {
                    label44.BackColor = Color.Black;
                }
            }
            oldXCoor = xCoor;
            oldYCoor = yCoor;
        }
        private void findTarget()
        {
            int cycle = 0;
            int target = 0;
            target = rand1.Next(3);
            while (cycle < 2)
            {
                if (target == 0)
                {
                    if (player.HP > 0)
                    {
                        this.target = player;
                    }
                    else
                    {
                        target++;
                    }
                }
                if (target == 1)
                {
                    if (ally1 != null)
                    {
                        if (ally1.HP > 0)
                        {
                            this.target = ally1;
                        }
                        else
                        {
                            target++;
                        }
                    }
                    else
                    {
                        target++;
                    }
                }
                if (target == 2)
                {
                    if (ally2 != null)
                    {
                        if (ally2.HP > 0)
                        {
                            this.target = ally2;
                        }
                        else
                        {
                            target++;
                        }
                    }
                    else
                    {
                        target++;
                    }
                }
                cycle++;
            }
        }
        public void roomStuff()
        {
            roomListBox.Items.Clear();
            foreach (Item i in dung.getCurrentRoom(player.PcolumnLoc, player.ProwLoc).Items)
            {
                roomListBox.Items.Add(i.ItemName);
            }
        }
        public bool checkStopCombat()
        {
            bool playAlive = true;
            bool ally1Alive = true;
            bool ally2Alive = true;
            bool enemy1Alive = true;
            bool enemy2Alive = true;
            bool enemy3Alive = true;
            if(player.HP <= 0)
            {
                playAlive = false;
            }
            if(ally1 != null)
            {
                if(ally1.HP <= 0)
                {
                    ally1Alive = false;
                }
            }
            else
            {
                ally1Alive = false;
            }
            if (ally2 != null)
            {
                if (ally2.HP <= 0)
                {
                    ally2Alive = false;
                }
            }
            else
            {
                ally2Alive = false;
            }
            if (enemy1 != null)
            {
                if (enemy1.HP <= 0)
                {
                    enemy1Alive = false;
                }
            }
            else
            {
                enemy1Alive = false;
            }
            if (enemy2 != null)
            {
                if (enemy2.HP <= 0)
                {
                    enemy2Alive = false;
                }
            }
            else
            {
                enemy2Alive = false;
            }
            if (enemy3 != null)
            {
                if (enemy3.HP <= 0)
                {
                    enemy3Alive = false;
                }
            }
            else
            {
                enemy3Alive = false;
            }
            if (playAlive == false && ally1Alive == false && ally2Alive == false)
            {
                MessageBox.Show("You and your party has died Game over");
                this.Close();
            }
            if (enemy1Alive == false && enemy2Alive == false && enemy3Alive == false)
            {
                combatGroupBox.Visible = false;
                navigationGroupBox.Visible = true;
                groupBox1.Visible = true;
                if(ally1 != null)
                {
                    if(ally1.HP > 0)
                    {
                        player.Party.Add(ally1);
                    }
                }
                if (ally2 != null)
                {
                    if (ally2.HP > 0)
                    {
                        player.Party.Add(ally2);
                    }
                }
                return true;
            }
            return false;
        }

        private void inventoryListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        #region
        private void defenderButton_Click(object sender, EventArgs e)
        {
            Defender c = new Defender();
            player.Class = c;
            MessageBox.Show("You chose the Defender class. \n" + "You now have access to all armor classes, and use of swords and knives. \n" + "your special reduces the damage of a friendly. ");
            levelUpGroupBox.Visible = true;
            classGroupBox1.Visible = false;
        }

        private void fighterButton_Click(object sender, EventArgs e)
        {
            Fighter f = new Fighter();
            player.Class = f;
            MessageBox.Show("You chose the Fighter class. \n" + "You have access to light and medium armor, and use of knives, swords and Greatswords. \n" + "Your special allows to two basic attacks in one turn.");
            levelUpGroupBox.Visible = true;
            classGroupBox1.Visible = false;

        }

        private void healerButton_Click(object sender, EventArgs e)
        {
            Healer h = new Healer();
            player.Class = h;
            MessageBox.Show("You chose the healer class. \n" + "You have access to light armor, and use of knives and staves. \n" + "Your special heals an ally.");
            levelUpGroupBox.Visible = true;
            classGroupBox1.Visible = false;
        }

        private void mageButton_Click(object sender, EventArgs e)
        {
            Mage m = new Mage();
            player.Class = m;
            MessageBox.Show("You chose the mage class. \n" + "You have access to light armor, and use of knives and staves. \n" + "Your special deals double your weapon bonus and magic power. Never basic attack." );
            levelUpGroupBox.Visible = true;
            classGroupBox1.Visible = false;
        }

        private void marksmanButton_Click(object sender, EventArgs e)
        {
            Marksman m = new Marksman();
            player.Class = m;
            MessageBox.Show("You chose the Marksman class. \n" + "You have access to light and medium armor and use of guns and knives. \n" + "Your special has a 25% chance to instantly kill your target.");
            levelUpGroupBox.Visible = true;
            classGroupBox1.Visible = false;
        }
        #endregion
        #region
        private int increasesLeft = 10;
        private void healthButton_Click(object sender, EventArgs e)
        {
            player.HP += 10;
            increasesLeft--;
            if(increasesLeft <= 0)
            {
                levelUpGroupBox.Visible = false;
            }
            outputLabel.Text = player.ToString();
        }

        private void strengthButton_Click(object sender, EventArgs e)
        {
            player.Strength += 1;
            increasesLeft--;
            if (increasesLeft <= 0)
            {
                levelUpGroupBox.Visible = false;
            }
            outputLabel.Text = player.ToString();
        }

        private void magicPowerButton_Click(object sender, EventArgs e)
        {
            player.MagicPower += 1;
            increasesLeft--;
            if (increasesLeft <= 0)
            {
                levelUpGroupBox.Visible = false;
            }
            outputLabel.Text = player.ToString();
        }

        private void speedButton_Click(object sender, EventArgs e)
        {
            player.Speed += 1;
            increasesLeft--;
            if (increasesLeft <= 0)
            {
                levelUpGroupBox.Visible = false;
            }
            outputLabel.Text = player.ToString();
        }
        #endregion

        private void useButton_Click(object sender, EventArgs e)
        {
            if (outOfCombatInventorylistBox.SelectedIndex != -1)
            {
                player.outOfCombatUse(outOfCombatInventorylistBox.SelectedItem.ToString());
            }
            displayInventory();
            outputLabel.Text = player.ToString();
        }
        public void displayInventory()
        {
            outOfCombatInventorylistBox.Items.Clear();
            foreach(Item i in player.Items)
            {
                outOfCombatInventorylistBox.Items.Add(i.ItemName);
            }
        }
        public void displayCombatants()
        {
            playerLabel.Text = Player.ToString();
            ally1Label.Text = ally1.ToString();
            ally2Label.Text = ally2.ToString();
            enemy1Label.Text = enemy1.ToString();
            enemy2Label.Text = enemy2.ToString();
            enemy3Label.Text = enemy3.ToString();
        }
    }
}
