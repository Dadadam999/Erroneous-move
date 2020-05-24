namespace Erroneous_move
{
    partial class Location_View
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
            this.loc_image = new System.Windows.Forms.PictureBox();
            this.loc_menu = new System.Windows.Forms.Panel();
            this.NameLoc = new System.Windows.Forms.Label();
            this.loc_trade = new System.Windows.Forms.PictureBox();
            this.loc_search = new System.Windows.Forms.PictureBox();
            this.loc_fight = new System.Windows.Forms.PictureBox();
            this.loc_inv = new System.Windows.Forms.PictureBox();
            this.loc_menu_btn = new System.Windows.Forms.PictureBox();
            this.loc_back = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.loc_image)).BeginInit();
            this.loc_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loc_trade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loc_search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loc_fight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loc_inv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loc_menu_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loc_back)).BeginInit();
            this.SuspendLayout();
            // 
            // loc_image
            // 
            this.loc_image.BackgroundImage = global::Erroneous_move.Properties.Resources.map_test;
            this.loc_image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loc_image.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loc_image.Location = new System.Drawing.Point(0, 0);
            this.loc_image.Name = "loc_image";
            this.loc_image.Size = new System.Drawing.Size(871, 443);
            this.loc_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loc_image.TabIndex = 3;
            this.loc_image.TabStop = false;
            // 
            // loc_menu
            // 
            this.loc_menu.BackColor = System.Drawing.Color.Transparent;
            this.loc_menu.BackgroundImage = global::Erroneous_move.Properties.Resources.back_bar;
            this.loc_menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loc_menu.Controls.Add(this.NameLoc);
            this.loc_menu.Controls.Add(this.loc_trade);
            this.loc_menu.Controls.Add(this.loc_search);
            this.loc_menu.Controls.Add(this.loc_fight);
            this.loc_menu.Controls.Add(this.loc_inv);
            this.loc_menu.Controls.Add(this.loc_menu_btn);
            this.loc_menu.Controls.Add(this.loc_back);
            this.loc_menu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.loc_menu.Location = new System.Drawing.Point(0, 443);
            this.loc_menu.Name = "loc_menu";
            this.loc_menu.Size = new System.Drawing.Size(871, 60);
            this.loc_menu.TabIndex = 2;
            // 
            // NameLoc
            // 
            this.NameLoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NameLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLoc.Location = new System.Drawing.Point(360, 0);
            this.NameLoc.Name = "NameLoc";
            this.NameLoc.Size = new System.Drawing.Size(511, 60);
            this.NameLoc.TabIndex = 8;
            this.NameLoc.Text = "Назвение\r\nЛокации";
            this.NameLoc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loc_trade
            // 
            this.loc_trade.Dock = System.Windows.Forms.DockStyle.Left;
            this.loc_trade.Image = global::Erroneous_move.Properties.Resources.money;
            this.loc_trade.Location = new System.Drawing.Point(300, 0);
            this.loc_trade.Name = "loc_trade";
            this.loc_trade.Size = new System.Drawing.Size(60, 60);
            this.loc_trade.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.loc_trade.TabIndex = 7;
            this.loc_trade.TabStop = false;
            this.loc_trade.Click += new System.EventHandler(this.loc_trade_Click);
            // 
            // loc_search
            // 
            this.loc_search.Dock = System.Windows.Forms.DockStyle.Left;
            this.loc_search.Image = global::Erroneous_move.Properties.Resources.search_test;
            this.loc_search.Location = new System.Drawing.Point(240, 0);
            this.loc_search.Name = "loc_search";
            this.loc_search.Size = new System.Drawing.Size(60, 60);
            this.loc_search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.loc_search.TabIndex = 6;
            this.loc_search.TabStop = false;
            this.loc_search.Click += new System.EventHandler(this.loc_search_Click);
            // 
            // loc_fight
            // 
            this.loc_fight.Dock = System.Windows.Forms.DockStyle.Left;
            this.loc_fight.Image = global::Erroneous_move.Properties.Resources.batle_test;
            this.loc_fight.Location = new System.Drawing.Point(180, 0);
            this.loc_fight.Name = "loc_fight";
            this.loc_fight.Size = new System.Drawing.Size(60, 60);
            this.loc_fight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.loc_fight.TabIndex = 5;
            this.loc_fight.TabStop = false;
            this.loc_fight.Click += new System.EventHandler(this.loc_fight_Click);
            // 
            // loc_inv
            // 
            this.loc_inv.Dock = System.Windows.Forms.DockStyle.Left;
            this.loc_inv.Image = global::Erroneous_move.Properties.Resources.backpak_test;
            this.loc_inv.Location = new System.Drawing.Point(120, 0);
            this.loc_inv.Name = "loc_inv";
            this.loc_inv.Size = new System.Drawing.Size(60, 60);
            this.loc_inv.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.loc_inv.TabIndex = 4;
            this.loc_inv.TabStop = false;
            this.loc_inv.Click += new System.EventHandler(this.loc_inv_Click);
            // 
            // loc_menu_btn
            // 
            this.loc_menu_btn.Dock = System.Windows.Forms.DockStyle.Left;
            this.loc_menu_btn.Image = global::Erroneous_move.Properties.Resources.menu_icon_test;
            this.loc_menu_btn.Location = new System.Drawing.Point(60, 0);
            this.loc_menu_btn.Name = "loc_menu_btn";
            this.loc_menu_btn.Size = new System.Drawing.Size(60, 60);
            this.loc_menu_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.loc_menu_btn.TabIndex = 3;
            this.loc_menu_btn.TabStop = false;
            this.loc_menu_btn.Click += new System.EventHandler(this.loc_menu_btn_Click);
            // 
            // loc_back
            // 
            this.loc_back.Dock = System.Windows.Forms.DockStyle.Left;
            this.loc_back.Image = global::Erroneous_move.Properties.Resources.step_back_test;
            this.loc_back.Location = new System.Drawing.Point(0, 0);
            this.loc_back.Name = "loc_back";
            this.loc_back.Size = new System.Drawing.Size(60, 60);
            this.loc_back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.loc_back.TabIndex = 2;
            this.loc_back.TabStop = false;
            this.loc_back.Click += new System.EventHandler(this.loc_back_Click);
            // 
            // Location_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.loc_image);
            this.Controls.Add(this.loc_menu);
            this.Name = "Location_View";
            this.Size = new System.Drawing.Size(871, 503);
            ((System.ComponentModel.ISupportInitialize)(this.loc_image)).EndInit();
            this.loc_menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.loc_trade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loc_search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loc_fight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loc_inv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loc_menu_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loc_back)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel loc_menu;
        private System.Windows.Forms.PictureBox loc_menu_btn;
        private System.Windows.Forms.PictureBox loc_back;
        private System.Windows.Forms.PictureBox loc_inv;
        private System.Windows.Forms.PictureBox loc_search;
        private System.Windows.Forms.PictureBox loc_fight;
        private System.Windows.Forms.PictureBox loc_trade;
        private System.Windows.Forms.PictureBox loc_image;
        private System.Windows.Forms.Label NameLoc;
    }
}
