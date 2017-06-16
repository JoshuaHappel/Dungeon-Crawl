namespace Dungeon_Crawl
{
    partial class CombatWindow
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.timer6 = new System.Windows.Forms.Timer(this.components);
            this.leftPictureBox1 = new System.Windows.Forms.PictureBox();
            this.leftPictureBox2 = new System.Windows.Forms.PictureBox();
            this.leftPictureBox3 = new System.Windows.Forms.PictureBox();
            this.rightPictureBox2 = new System.Windows.Forms.PictureBox();
            this.rightPictureBox3 = new System.Windows.Forms.PictureBox();
            this.rightPictureBox1 = new System.Windows.Forms.PictureBox();
            this.attackButton = new System.Windows.Forms.Button();
            this.specialButton = new System.Windows.Forms.Button();
            this.itemButton = new System.Windows.Forms.Button();
            this.fleeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.leftPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Enabled = true;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // timer5
            // 
            this.timer5.Enabled = true;
            this.timer5.Tick += new System.EventHandler(this.timer5_Tick);
            // 
            // timer6
            // 
            this.timer6.Enabled = true;
            this.timer6.Tick += new System.EventHandler(this.timer6_Tick);
            // 
            // leftPictureBox1
            // 
            this.leftPictureBox1.Image = global::Dungeon_Crawl.Properties.Resources.Soldier;
            this.leftPictureBox1.Location = new System.Drawing.Point(12, 12);
            this.leftPictureBox1.Name = "leftPictureBox1";
            this.leftPictureBox1.Size = new System.Drawing.Size(50, 58);
            this.leftPictureBox1.TabIndex = 10;
            this.leftPictureBox1.TabStop = false;
            this.leftPictureBox1.Click += new System.EventHandler(this.leftPictureBox1_Click);
            // 
            // leftPictureBox2
            // 
            this.leftPictureBox2.Image = global::Dungeon_Crawl.Properties.Resources.Soldier;
            this.leftPictureBox2.Location = new System.Drawing.Point(12, 76);
            this.leftPictureBox2.Name = "leftPictureBox2";
            this.leftPictureBox2.Size = new System.Drawing.Size(50, 58);
            this.leftPictureBox2.TabIndex = 9;
            this.leftPictureBox2.TabStop = false;
            this.leftPictureBox2.Click += new System.EventHandler(this.leftPictureBox2_Click);
            // 
            // leftPictureBox3
            // 
            this.leftPictureBox3.Image = global::Dungeon_Crawl.Properties.Resources.Soldier;
            this.leftPictureBox3.Location = new System.Drawing.Point(12, 140);
            this.leftPictureBox3.Name = "leftPictureBox3";
            this.leftPictureBox3.Size = new System.Drawing.Size(50, 58);
            this.leftPictureBox3.TabIndex = 8;
            this.leftPictureBox3.TabStop = false;
            this.leftPictureBox3.Click += new System.EventHandler(this.leftPictureBox3_Click);
            // 
            // rightPictureBox2
            // 
            this.rightPictureBox2.Image = global::Dungeon_Crawl.Properties.Resources.Soldier_flip;
            this.rightPictureBox2.Location = new System.Drawing.Point(324, 76);
            this.rightPictureBox2.Name = "rightPictureBox2";
            this.rightPictureBox2.Size = new System.Drawing.Size(50, 58);
            this.rightPictureBox2.TabIndex = 7;
            this.rightPictureBox2.TabStop = false;
            this.rightPictureBox2.Click += new System.EventHandler(this.rightPictureBox2_Click);
            // 
            // rightPictureBox3
            // 
            this.rightPictureBox3.Image = global::Dungeon_Crawl.Properties.Resources.Soldier_flip;
            this.rightPictureBox3.Location = new System.Drawing.Point(324, 140);
            this.rightPictureBox3.Name = "rightPictureBox3";
            this.rightPictureBox3.Size = new System.Drawing.Size(50, 58);
            this.rightPictureBox3.TabIndex = 6;
            this.rightPictureBox3.TabStop = false;
            this.rightPictureBox3.Click += new System.EventHandler(this.rightPictureBox3_Click);
            // 
            // rightPictureBox1
            // 
            this.rightPictureBox1.Image = global::Dungeon_Crawl.Properties.Resources.Soldier_flip;
            this.rightPictureBox1.Location = new System.Drawing.Point(324, 12);
            this.rightPictureBox1.Name = "rightPictureBox1";
            this.rightPictureBox1.Size = new System.Drawing.Size(50, 58);
            this.rightPictureBox1.TabIndex = 5;
            this.rightPictureBox1.TabStop = false;
            this.rightPictureBox1.Click += new System.EventHandler(this.rightPictureBox1_Click);
            // 
            // attackButton
            // 
            this.attackButton.Location = new System.Drawing.Point(154, 200);
            this.attackButton.Name = "attackButton";
            this.attackButton.Size = new System.Drawing.Size(75, 23);
            this.attackButton.TabIndex = 11;
            this.attackButton.Text = "Attack";
            this.attackButton.UseVisualStyleBackColor = true;
            this.attackButton.Click += new System.EventHandler(this.attackButton_Click);
            // 
            // specialButton
            // 
            this.specialButton.Location = new System.Drawing.Point(154, 229);
            this.specialButton.Name = "specialButton";
            this.specialButton.Size = new System.Drawing.Size(75, 23);
            this.specialButton.TabIndex = 12;
            this.specialButton.Text = "Special";
            this.specialButton.UseVisualStyleBackColor = true;
            this.specialButton.Click += new System.EventHandler(this.specialButton_Click);
            // 
            // itemButton
            // 
            this.itemButton.Location = new System.Drawing.Point(154, 258);
            this.itemButton.Name = "itemButton";
            this.itemButton.Size = new System.Drawing.Size(75, 23);
            this.itemButton.TabIndex = 13;
            this.itemButton.Text = "Items";
            this.itemButton.UseVisualStyleBackColor = true;
            this.itemButton.Click += new System.EventHandler(this.itemButton_Click);
            // 
            // fleeButton
            // 
            this.fleeButton.Location = new System.Drawing.Point(154, 287);
            this.fleeButton.Name = "fleeButton";
            this.fleeButton.Size = new System.Drawing.Size(75, 23);
            this.fleeButton.TabIndex = 14;
            this.fleeButton.Text = "Flee";
            this.fleeButton.UseVisualStyleBackColor = true;
            this.fleeButton.Click += new System.EventHandler(this.fleeButton_Click);
            // 
            // CombatWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 318);
            this.Controls.Add(this.fleeButton);
            this.Controls.Add(this.itemButton);
            this.Controls.Add(this.specialButton);
            this.Controls.Add(this.attackButton);
            this.Controls.Add(this.leftPictureBox1);
            this.Controls.Add(this.leftPictureBox2);
            this.Controls.Add(this.leftPictureBox3);
            this.Controls.Add(this.rightPictureBox2);
            this.Controls.Add(this.rightPictureBox3);
            this.Controls.Add(this.rightPictureBox1);
            this.Name = "CombatWindow";
            this.Text = "CombatWindow";
            ((System.ComponentModel.ISupportInitialize)(this.leftPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Timer timer5;
        private System.Windows.Forms.Timer timer6;
        private System.Windows.Forms.PictureBox rightPictureBox1;
        private System.Windows.Forms.PictureBox rightPictureBox3;
        private System.Windows.Forms.PictureBox rightPictureBox2;
        private System.Windows.Forms.PictureBox leftPictureBox3;
        private System.Windows.Forms.PictureBox leftPictureBox2;
        private System.Windows.Forms.PictureBox leftPictureBox1;
        private System.Windows.Forms.Button attackButton;
        private System.Windows.Forms.Button specialButton;
        private System.Windows.Forms.Button itemButton;
        private System.Windows.Forms.Button fleeButton;
    }
}