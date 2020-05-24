namespace Erroneous_move
{
    partial class Map_View
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contrl = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.c_left = new System.Windows.Forms.PictureBox();
            this.c_down = new System.Windows.Forms.PictureBox();
            this.c_up = new System.Windows.Forms.PictureBox();
            this.c_right = new System.Windows.Forms.PictureBox();
            this.info_loc = new System.Windows.Forms.Panel();
            this.desc_loc = new System.Windows.Forms.Label();
            this.name_loc = new System.Windows.Forms.Label();
            this.loc_container = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.daynight = new System.Windows.Forms.PictureBox();
            this.open_menu = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.In_loc = new System.Windows.Forms.PictureBox();
            this.loc_inv = new System.Windows.Forms.PictureBox();
            this.hero = new System.Windows.Forms.PictureBox();
            this.contrl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_left)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_down)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_up)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_right)).BeginInit();
            this.info_loc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loc_container)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.daynight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.open_menu)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.In_loc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loc_inv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hero)).BeginInit();
            this.SuspendLayout();
            // 
            // contrl
            // 
            this.contrl.BackColor = System.Drawing.Color.Transparent;
            this.contrl.BackgroundImage = global::Erroneous_move.Properties.Resources.kompas_test;
            this.contrl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.contrl.Controls.Add(this.pictureBox1);
            this.contrl.Controls.Add(this.c_left);
            this.contrl.Controls.Add(this.c_down);
            this.contrl.Controls.Add(this.c_up);
            this.contrl.Controls.Add(this.c_right);
            this.contrl.Dock = System.Windows.Forms.DockStyle.Right;
            this.contrl.Location = new System.Drawing.Point(744, 0);
            this.contrl.Name = "contrl";
            this.contrl.Size = new System.Drawing.Size(85, 85);
            this.contrl.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Erroneous_move.Properties.Resources.but_c_test;
            this.pictureBox1.Location = new System.Drawing.Point(30, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.c_center_Click);
            // 
            // c_left
            // 
            this.c_left.Image = global::Erroneous_move.Properties.Resources.strelka4_test;
            this.c_left.Location = new System.Drawing.Point(0, 30);
            this.c_left.Name = "c_left";
            this.c_left.Size = new System.Drawing.Size(25, 25);
            this.c_left.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.c_left.TabIndex = 3;
            this.c_left.TabStop = false;
            this.c_left.Click += new System.EventHandler(this.c_left_Click);
            // 
            // c_down
            // 
            this.c_down.Image = global::Erroneous_move.Properties.Resources.strelka3_test;
            this.c_down.Location = new System.Drawing.Point(30, 60);
            this.c_down.Name = "c_down";
            this.c_down.Size = new System.Drawing.Size(25, 25);
            this.c_down.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.c_down.TabIndex = 2;
            this.c_down.TabStop = false;
            this.c_down.Click += new System.EventHandler(this.c_down_Click);
            // 
            // c_up
            // 
            this.c_up.Image = global::Erroneous_move.Properties.Resources.strelka1_test;
            this.c_up.Location = new System.Drawing.Point(30, 0);
            this.c_up.Name = "c_up";
            this.c_up.Size = new System.Drawing.Size(25, 25);
            this.c_up.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.c_up.TabIndex = 1;
            this.c_up.TabStop = false;
            this.c_up.Click += new System.EventHandler(this.c_up_Click);
            // 
            // c_right
            // 
            this.c_right.Image = global::Erroneous_move.Properties.Resources.strelka2_test;
            this.c_right.Location = new System.Drawing.Point(60, 30);
            this.c_right.Name = "c_right";
            this.c_right.Size = new System.Drawing.Size(25, 25);
            this.c_right.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.c_right.TabIndex = 0;
            this.c_right.TabStop = false;
            this.c_right.Click += new System.EventHandler(this.c_right_Click);
            // 
            // info_loc
            // 
            this.info_loc.BackColor = System.Drawing.Color.Transparent;
            this.info_loc.BackgroundImage = global::Erroneous_move.Properties.Resources.about_map_test;
            this.info_loc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.info_loc.Controls.Add(this.desc_loc);
            this.info_loc.Controls.Add(this.name_loc);
            this.info_loc.Location = new System.Drawing.Point(547, 148);
            this.info_loc.Name = "info_loc";
            this.info_loc.Size = new System.Drawing.Size(136, 155);
            this.info_loc.TabIndex = 2;
            this.info_loc.Visible = false;
            // 
            // desc_loc
            // 
            this.desc_loc.Location = new System.Drawing.Point(3, 57);
            this.desc_loc.Name = "desc_loc";
            this.desc_loc.Size = new System.Drawing.Size(130, 98);
            this.desc_loc.TabIndex = 1;
            this.desc_loc.Text = "???";
            // 
            // name_loc
            // 
            this.name_loc.AutoSize = true;
            this.name_loc.Location = new System.Drawing.Point(5, 29);
            this.name_loc.Name = "name_loc";
            this.name_loc.Size = new System.Drawing.Size(25, 13);
            this.name_loc.TabIndex = 0;
            this.name_loc.Text = "???";
            // 
            // loc_container
            // 
            this.loc_container.BackColor = System.Drawing.Color.Transparent;
            this.loc_container.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loc_container.Location = new System.Drawing.Point(103, 27);
            this.loc_container.Name = "loc_container";
            this.loc_container.Size = new System.Drawing.Size(398, 384);
            this.loc_container.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loc_container.TabIndex = 3;
            this.loc_container.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // daynight
            // 
            this.daynight.BackColor = System.Drawing.Color.Transparent;
            this.daynight.Dock = System.Windows.Forms.DockStyle.Left;
            this.daynight.Image = global::Erroneous_move.Properties.Resources.daynight2_test;
            this.daynight.Location = new System.Drawing.Point(0, 0);
            this.daynight.Name = "daynight";
            this.daynight.Size = new System.Drawing.Size(85, 85);
            this.daynight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.daynight.TabIndex = 4;
            this.daynight.TabStop = false;
            // 
            // open_menu
            // 
            this.open_menu.BackColor = System.Drawing.Color.Transparent;
            this.open_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.open_menu.Image = global::Erroneous_move.Properties.Resources.menu_icon_test;
            this.open_menu.Location = new System.Drawing.Point(0, 0);
            this.open_menu.Name = "open_menu";
            this.open_menu.Size = new System.Drawing.Size(60, 60);
            this.open_menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.open_menu.TabIndex = 5;
            this.open_menu.TabStop = false;
            this.open_menu.Click += new System.EventHandler(this.open_menu_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Erroneous_move.Properties.Resources.back_bar;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.daynight);
            this.panel1.Controls.Add(this.contrl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 416);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(829, 85);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(85, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(659, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Управление: A - влево, W - вверх, D - вправо, S - вниз";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.In_loc);
            this.panel2.Controls.Add(this.loc_inv);
            this.panel2.Controls.Add(this.open_menu);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(85, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(659, 60);
            this.panel2.TabIndex = 7;
            // 
            // In_loc
            // 
            this.In_loc.Dock = System.Windows.Forms.DockStyle.Left;
            this.In_loc.Image = global::Erroneous_move.Properties.Resources.Door;
            this.In_loc.Location = new System.Drawing.Point(120, 0);
            this.In_loc.Name = "In_loc";
            this.In_loc.Size = new System.Drawing.Size(60, 60);
            this.In_loc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.In_loc.TabIndex = 7;
            this.In_loc.TabStop = false;
            this.In_loc.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // loc_inv
            // 
            this.loc_inv.Dock = System.Windows.Forms.DockStyle.Left;
            this.loc_inv.Image = global::Erroneous_move.Properties.Resources.backpak_test;
            this.loc_inv.Location = new System.Drawing.Point(60, 0);
            this.loc_inv.Name = "loc_inv";
            this.loc_inv.Size = new System.Drawing.Size(60, 60);
            this.loc_inv.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.loc_inv.TabIndex = 6;
            this.loc_inv.TabStop = false;
            this.loc_inv.Click += new System.EventHandler(this.loc_inv_Click);
            // 
            // hero
            // 
            this.hero.BackColor = System.Drawing.Color.Transparent;
            this.hero.Image = global::Erroneous_move.Properties.Resources.gg;
            this.hero.Location = new System.Drawing.Point(709, 75);
            this.hero.Name = "hero";
            this.hero.Size = new System.Drawing.Size(46, 70);
            this.hero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hero.TabIndex = 7;
            this.hero.TabStop = false;
            // 
            // Map_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Erroneous_move.Properties.Resources.map_test;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.hero);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.info_loc);
            this.Controls.Add(this.loc_container);
            this.DoubleBuffered = true;
            this.Name = "Map_View";
            this.Size = new System.Drawing.Size(829, 501);
            this.Resize += new System.EventHandler(this.Map_View_Resize);
            this.contrl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_left)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_down)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_up)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_right)).EndInit();
            this.info_loc.ResumeLayout(false);
            this.info_loc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loc_container)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.daynight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.open_menu)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.In_loc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loc_inv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hero)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel contrl;
        private System.Windows.Forms.PictureBox c_left;
        private System.Windows.Forms.PictureBox c_down;
        private System.Windows.Forms.PictureBox c_up;
        private System.Windows.Forms.PictureBox c_right;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel info_loc;
        private System.Windows.Forms.Label desc_loc;
        private System.Windows.Forms.Label name_loc;
        private System.Windows.Forms.PictureBox loc_container;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox daynight;
        private System.Windows.Forms.PictureBox open_menu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox loc_inv;
        private System.Windows.Forms.PictureBox hero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox In_loc;
    }
}
