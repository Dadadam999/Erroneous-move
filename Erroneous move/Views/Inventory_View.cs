using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Erroneous_move {
    public partial class Inventory_View : UserControl {
        public Inventory_View() {
            InitializeComponent();
        }
        public void refrash_inv() { // booth, armor, helmet, weapon1, weapon2, extra, horse
            money.Text = MainForm.selfref.gg.money.ToString();
            int k_it = 0;
            foreach (Inventory_Item it in MainForm.selfref.gg.get_inventory_item())
                if (it.isDress) {
                    if(it.type == "booth") {
                        inv_booth.Image = it.icon;
                        inv_booth.Tag = it.name;
                    }
                    if (it.type == "armor") {
                        inv_armor.Image = it.icon;
                        inv_armor.Tag = it.name;
                    }
                    if (it.type == "helmet") {
                        inv_helmet.Image = it.icon;
                        inv_helmet.Tag = it.name;
                    }
                    if (it.type == "weapon1") {
                        inv_weapon1.Image = it.icon;
                        inv_weapon1.Tag = it.name;
                    }
                    if (it.type == "weapon2") {
                        inv_weapon2.Image = it.icon;
                        inv_weapon2.Tag = it.name;
                    }
                    if (it.type == "extra") {
                        inv_extra.Image = it.icon;
                        inv_extra.Tag = it.name;
                    }
                    if (it.type == "horse") {
                        inv_horse.Image = it.icon;
                        inv_horse.Tag = it.name;
                    }
                    ((PictureBox)inv_container.Controls[k_it]).Image = it.icon;
                    ((PictureBox)inv_container.Controls[k_it]).Tag = it.name;
                    k_it++;
                }
                else {
                    ((PictureBox)inv_container.Controls[k_it]).Image = it.icon;
                    ((PictureBox)inv_container.Controls[k_it]).Tag = it.name;
                    k_it++;
                }
        }
        private void inv_horse_Click(object sender, EventArgs e)
        {
            MainForm.selfref.gg.inv_mass.Find(item => item.name == ((PictureBox)sender).Tag.ToString()).isDress = false;
            inv_horse.Image = Properties.Resources.empty;
            inv_horse.Tag = "";
         }

        private void inv_extra_Click(object sender, EventArgs e)
        {
            MainForm.selfref.gg.inv_mass.Find(item => item.name == ((PictureBox)sender).Tag.ToString()).isDress = false;
            inv_extra.Image = Properties.Resources.empty;
            inv_extra.Tag = "";
        }

        private void inv_weapon1_Click(object sender, EventArgs e)
        {
            MainForm.selfref.gg.inv_mass.Find(item => item.name == ((PictureBox)sender).Tag.ToString()).isDress = false;
            inv_weapon1.Image = Properties.Resources.empty;
            inv_weapon1.Tag = "";
        }

        private void inv_weapon2_Click(object sender, EventArgs e)
        {
            MainForm.selfref.gg.inv_mass.Find(item => item.name == ((PictureBox)sender).Tag.ToString()).isDress = false;
            inv_weapon2.Image = Properties.Resources.empty;
            inv_weapon2.Tag = "";
        }

        private void inv_booth_Click(object sender, EventArgs e)
        {
            MainForm.selfref.gg.inv_mass.Find(item => item.name == ((PictureBox)sender).Tag.ToString()).isDress = false;
            inv_booth.Image = Properties.Resources.empty;
            inv_booth.Tag = "";
        }

        private void inv_helmet_Click(object sender, EventArgs e)
        {
            MainForm.selfref.gg.inv_mass.Find(item => item.name == ((PictureBox)sender).Tag.ToString()).isDress = false;
            inv_helmet.Image = Properties.Resources.empty;
            inv_helmet.Tag = "";
        }

        private void inv_armor_Click(object sender, EventArgs e)
        {
            MainForm.selfref.gg.inv_mass.Find(item => item.name == ((PictureBox)sender).Tag.ToString()).isDress = false;
            inv_armor.Image = Properties.Resources.empty;
            inv_armor.Tag = "";
        }

        private void inv_el_btn_Click(object sender, EventArgs e) {
            try
            {
                if (MainForm.selfref.gg.inv_mass.Find(item => item.name == ((PictureBox)sender).Tag.ToString()).type == "booth")
                {
                    inv_booth.Image = MainForm.selfref.gg.inv_mass.Find(item => item.name == ((PictureBox)sender).Tag.ToString()).icon;
                    inv_booth.Tag = MainForm.selfref.gg.inv_mass.Find(item => item.name == ((PictureBox)sender).Tag.ToString()).name;
                    MainForm.selfref.gg.inv_mass.Find(item => item.name == ((PictureBox)sender).Tag.ToString()).isDress = true;
                }
                if (MainForm.selfref.gg.inv_mass.Find(item => item.name == ((PictureBox)sender).Tag.ToString()).type == "armor")
                {
                    inv_armor.Image = MainForm.selfref.gg.inv_mass.Find(item => item.name == ((PictureBox)sender).Tag.ToString()).icon;
                    inv_armor.Tag = MainForm.selfref.gg.inv_mass.Find(item => item.name == ((PictureBox)sender).Tag.ToString()).name;
                    MainForm.selfref.gg.inv_mass.Find(item => item.name == ((PictureBox)sender).Tag.ToString()).isDress = true;
                }
                if (MainForm.selfref.gg.inv_mass.Find(item => item.name == ((PictureBox)sender).Tag.ToString()).type == "helmet")
                {
                    inv_helmet.Image = MainForm.selfref.gg.inv_mass.Find(item => item.name == ((PictureBox)sender).Tag.ToString()).icon;
                    inv_helmet.Tag = MainForm.selfref.gg.inv_mass.Find(item => item.name == ((PictureBox)sender).Tag.ToString()).name;
                    MainForm.selfref.gg.inv_mass.Find(item => item.name == ((PictureBox)sender).Tag.ToString()).isDress = true;
                }
                if (MainForm.selfref.gg.inv_mass.Find(item => item.name == ((PictureBox)sender).Tag.ToString()).type == "weapon1")
                {
                    inv_weapon1.Image = MainForm.selfref.gg.inv_mass.Find(item => item.name == ((PictureBox)sender).Tag.ToString()).icon;
                    inv_weapon1.Tag = MainForm.selfref.gg.inv_mass.Find(item => item.name == ((PictureBox)sender).Tag.ToString()).name;
                    MainForm.selfref.gg.inv_mass.Find(item => item.name == ((PictureBox)sender).Tag.ToString()).isDress = true;
                }
                if (MainForm.selfref.gg.inv_mass.Find(item => item.name == ((PictureBox)sender).Tag.ToString()).type == "weapon2")
                {
                    inv_weapon2.Image = MainForm.selfref.gg.inv_mass.Find(item => item.name == ((PictureBox)sender).Tag.ToString()).icon;
                    inv_weapon2.Tag = MainForm.selfref.gg.inv_mass.Find(item => item.name == ((PictureBox)sender).Tag.ToString()).name;
                    MainForm.selfref.gg.inv_mass.Find(item => item.name == ((PictureBox)sender).Tag.ToString()).isDress = true;
                }
                if (MainForm.selfref.gg.inv_mass.Find(item => item.name == ((PictureBox)sender).Tag.ToString()).type == "extra")
                {
                    inv_extra.Image = MainForm.selfref.gg.inv_mass.Find(item => item.name == ((PictureBox)sender).Tag.ToString()).icon;
                    inv_extra.Tag = MainForm.selfref.gg.inv_mass.Find(item => item.name == ((PictureBox)sender).Tag.ToString()).name;
                    MainForm.selfref.gg.inv_mass.Find(item => item.name == ((PictureBox)sender).Tag.ToString()).isDress = true;
                }
                if (MainForm.selfref.gg.inv_mass.Find(item => item.name == ((PictureBox)sender).Tag.ToString()).type == "horse")
                {
                    inv_horse.Image = MainForm.selfref.gg.inv_mass.Find(item => item.name == ((PictureBox)sender).Tag.ToString()).icon;
                    inv_horse.Tag = MainForm.selfref.gg.inv_mass.Find(item => item.name == ((PictureBox)sender).Tag.ToString()).name;
                    MainForm.selfref.gg.inv_mass.Find(item => item.name == ((PictureBox)sender).Tag.ToString()).isDress = true;
                }
            }
            catch (System.NullReferenceException) { }
        }

        private void inv_back_Click(object sender, EventArgs e)
        {
            Visible = false;
        }

        private void inv_menu_btn_Click(object sender, EventArgs e)
        {
            MainForm.selfref.show_menu(1);
        }
    }
}
