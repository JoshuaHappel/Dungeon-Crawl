using System;
using System.Drawing;
using System.Windows.Forms;
using DungeonCrawl.UnitClasses;
using System.Linq;
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
        private Dungeon dung;
        private Player play;
        private int oldXCoor = 0, oldYCoor = 0;
        private Random rand1 = new Random((int)DateTime.Now.Ticks & 0x0000FFFF);
        private Label[,] map = new Label[5, 5];
        
        public Form1()
        {
            InitializeComponent();
            populateMapArray();
            dung = new Dungeon();
            play = new Player();
            map[play.XCoor, play.YCoor].BackColor = Color.Black;
            
        }
        private void populateMapArray()
        {
            map[0, 0] = label00;
            map[1, 0] = label10;
            map[2, 0] = label20;
            map[3, 0] = label30;
            map[4, 0] = label40;

            map[0, 1] = label01;
            map[1, 1] = label11;
            map[2, 1] = label21;
            map[3, 1] = label31;
            map[4, 1] = label41;

            map[0, 2] = label02;
            map[1, 2] = label12;
            map[2, 2] = label22;
            map[3, 2] = label32;
            map[4, 2] = label42;

            map[0, 3] = label03;
            map[1, 3] = label13;
            map[2, 3] = label23;
            map[3, 3] = label33;
            map[4, 3] = label43;

            map[0, 4] = label04;
            map[1, 4] = label14;
            map[2, 4] = label24;
            map[3, 4] = label34;
            map[4, 4] = label44;
        }

        private void northButton1_Click(object sender, EventArgs e)
        {
            map[play.XCoor, play.YCoor].BackColor = Color.DarkSlateGray;
            play.go((int)Directions.NORTH, dung);
            map[play.XCoor, play.YCoor].BackColor = Color.Black;
            showRoomInventory();
        }

        private void westButton3_Click(object sender, EventArgs e)
        {
            map[play.XCoor, play.YCoor].BackColor = Color.DarkSlateGray;
            play.go((int)Directions.WEST, dung);
            map[play.XCoor, play.YCoor].BackColor = Color.Black;
            showRoomInventory();
        }

        private void southButton2_Click(object sender, EventArgs e)
        {
            map[play.XCoor, play.YCoor].BackColor = Color.DarkSlateGray;
            play.go((int)Directions.SOUTH, dung);
            map[play.XCoor, play.YCoor].BackColor = Color.Black;
            showRoomInventory();
        }

        private void eastButton4_Click(object sender, EventArgs e)
        {
            map[play.XCoor, play.YCoor].BackColor = Color.DarkSlateGray;
            play.go((int)Directions.EAST, dung);
            map[play.XCoor, play.YCoor].BackColor = Color.Black;
            showRoomInventory();
        }
        private void Interact_Click(object sender, EventArgs e)
        {
            play.pickUpItem(dung.getCurrentRoom(play).Items.ElementAt(roomListBox.SelectedIndex));
            dung.getCurrentRoom(play).Items.Remove(dung.getCurrentRoom(play).Items.ElementAt(roomListBox.SelectedIndex));
            showRoomInventory();
        }
        public void showRoomInventory()
        {
            roomListBox.Items.Clear();
            foreach (Item i in dung.getCurrentRoom(play).Items)
            {
                roomListBox.Items.Add(i.ItemName);
            }
        }
        
  
        
        
    }
}
