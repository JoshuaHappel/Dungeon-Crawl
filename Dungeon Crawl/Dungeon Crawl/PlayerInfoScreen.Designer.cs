namespace Dungeon_Crawl
{
    partial class PlayerInfoScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ally2Panel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.ally1Panel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.characterPanel = new System.Windows.Forms.Panel();
            this.equippedArmorLabel = new System.Windows.Forms.Label();
            this.equippedWeaponLabel = new System.Windows.Forms.Label();
            this.healthLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.inventoryListBox = new System.Windows.Forms.ListBox();
            this.useButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.ally2Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.ally1Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.characterPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Return";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ally2Panel);
            this.groupBox1.Controls.Add(this.ally1Panel);
            this.groupBox1.Controls.Add(this.characterPanel);
            this.groupBox1.Location = new System.Drawing.Point(91, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 240);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Party";
            // 
            // ally2Panel
            // 
            this.ally2Panel.Controls.Add(this.label5);
            this.ally2Panel.Controls.Add(this.label6);
            this.ally2Panel.Controls.Add(this.label7);
            this.ally2Panel.Controls.Add(this.label8);
            this.ally2Panel.Controls.Add(this.pictureBox3);
            this.ally2Panel.Location = new System.Drawing.Point(6, 151);
            this.ally2Panel.Name = "ally2Panel";
            this.ally2Panel.Size = new System.Drawing.Size(188, 63);
            this.ally2Panel.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Armor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(67, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Weapon:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(67, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Health:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(67, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "name";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Dungeon_Crawl.Properties.Resources.Soldier;
            this.pictureBox3.Location = new System.Drawing.Point(3, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 58);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // ally1Panel
            // 
            this.ally1Panel.Controls.Add(this.label1);
            this.ally1Panel.Controls.Add(this.label2);
            this.ally1Panel.Controls.Add(this.label3);
            this.ally1Panel.Controls.Add(this.label4);
            this.ally1Panel.Controls.Add(this.pictureBox2);
            this.ally1Panel.Location = new System.Drawing.Point(6, 85);
            this.ally1Panel.Name = "ally1Panel";
            this.ally1Panel.Size = new System.Drawing.Size(188, 63);
            this.ally1Panel.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Armor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Weapon:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Health:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "name";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Dungeon_Crawl.Properties.Resources.Soldier;
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 58);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // characterPanel
            // 
            this.characterPanel.Controls.Add(this.equippedArmorLabel);
            this.characterPanel.Controls.Add(this.equippedWeaponLabel);
            this.characterPanel.Controls.Add(this.healthLabel);
            this.characterPanel.Controls.Add(this.nameLabel);
            this.characterPanel.Controls.Add(this.pictureBox1);
            this.characterPanel.Location = new System.Drawing.Point(6, 19);
            this.characterPanel.Name = "characterPanel";
            this.characterPanel.Size = new System.Drawing.Size(188, 63);
            this.characterPanel.TabIndex = 0;
            // 
            // equippedArmorLabel
            // 
            this.equippedArmorLabel.AutoSize = true;
            this.equippedArmorLabel.Location = new System.Drawing.Point(67, 42);
            this.equippedArmorLabel.Name = "equippedArmorLabel";
            this.equippedArmorLabel.Size = new System.Drawing.Size(34, 13);
            this.equippedArmorLabel.TabIndex = 4;
            this.equippedArmorLabel.Text = "Armor";
            // 
            // equippedWeaponLabel
            // 
            this.equippedWeaponLabel.AutoSize = true;
            this.equippedWeaponLabel.Location = new System.Drawing.Point(67, 29);
            this.equippedWeaponLabel.Name = "equippedWeaponLabel";
            this.equippedWeaponLabel.Size = new System.Drawing.Size(51, 13);
            this.equippedWeaponLabel.TabIndex = 3;
            this.equippedWeaponLabel.Text = "Weapon:";
            // 
            // healthLabel
            // 
            this.healthLabel.AutoSize = true;
            this.healthLabel.Location = new System.Drawing.Point(67, 16);
            this.healthLabel.Name = "healthLabel";
            this.healthLabel.Size = new System.Drawing.Size(41, 13);
            this.healthLabel.TabIndex = 2;
            this.healthLabel.Text = "Health:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(67, 3);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(33, 13);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Dungeon_Crawl.Properties.Resources.Soldier;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 58);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // inventoryListBox
            // 
            this.inventoryListBox.FormattingEnabled = true;
            this.inventoryListBox.Location = new System.Drawing.Point(297, 3);
            this.inventoryListBox.Name = "inventoryListBox";
            this.inventoryListBox.Size = new System.Drawing.Size(120, 225);
            this.inventoryListBox.TabIndex = 2;
            // 
            // useButton
            // 
            this.useButton.Location = new System.Drawing.Point(10, 32);
            this.useButton.Name = "useButton";
            this.useButton.Size = new System.Drawing.Size(75, 23);
            this.useButton.TabIndex = 3;
            this.useButton.Text = "Use";
            this.useButton.UseVisualStyleBackColor = true;
            this.useButton.Click += new System.EventHandler(this.useButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(10, 91);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.useButton);
            this.panel1.Controls.Add(this.inventoryListBox);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(426, 241);
            this.panel1.TabIndex = 5;
            // 
            // PlayerInfoScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 549);
            this.Controls.Add(this.panel1);
            this.Name = "PlayerInfoScreen";
            this.Text = "PlayerInfoScreen";
            this.groupBox1.ResumeLayout(false);
            this.ally2Panel.ResumeLayout(false);
            this.ally2Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ally1Panel.ResumeLayout(false);
            this.ally1Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.characterPanel.ResumeLayout(false);
            this.characterPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel characterPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label equippedArmorLabel;
        private System.Windows.Forms.Label equippedWeaponLabel;
        private System.Windows.Forms.Label healthLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Panel ally2Panel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel ally1Panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ListBox inventoryListBox;
        private System.Windows.Forms.Button useButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
    }
}