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
    public partial class Fight_View : UserControl {
        public Game_Person mob { get; set; }
        Random rand = new Random();
        Person_Action temp;
        int start_mob_hp; // нужно чтобы вернуть изначальное хп мобу
        int gg_shield = 0;
        bool gg_dodge = false;

        public Fight_View() {
            InitializeComponent();
        }

        public void set_fight() {
            fight_back.Visible = false;
            fight_trade.Visible = false;
            down_bar.Visible = true;

            fight_gg_image.Image = MainForm.selfref.gg.texture;
            fight_gg_status.Text = "HP: " + MainForm.selfref.gg.hp.ToString();

            fight_mob_image.Image = mob.texture;
            fight_mob_status.Text = "HP: " + mob.hp.ToString();
            start_mob_hp = mob.hp;
            fight_info.Text = "Бой с " + mob.name + " начался\n";
        }

        private void fight_back_Click(object sender, EventArgs e)
        {
            Visible = false;
        }

        private void fight_menu_Click(object sender, EventArgs e)
        {
            MainForm.selfref.show_menu(1);
        }

        private void fight_trade_Click(object sender, EventArgs e)
        {
            MainForm.selfref.show_trade(false, mob);
        }

        private void Fight_View_Resize(object sender, EventArgs e)
        {
            fight_gg_image.Width = Math.Abs(Width / 2);
            fight_mob_image.Width = Math.Abs(Width / 2);
        }

        private void fight_atk_Click(object sender, EventArgs e) {
            mob.get_damage(MainForm.selfref.gg.get_sum_inv_atk() + 5, 0);
            if (!check_win())
            {
                fight_info.Text += "Вы использовали Обычный удар и нанесли: " + (MainForm.selfref.gg.get_sum_inv_atk() + 5).ToString() + " ед. урона.\n";
                fight_gg_status.Text = "HP: " + MainForm.selfref.gg.hp.ToString();
                fight_mob_status.Text = "HP: " + mob.hp.ToString();
                fight_info.SelectionStart = fight_info.Text.Length;
                fight_info.ScrollToCaret();
                mob_step();
            }
        }

        private void fight_atk_strong_Click(object sender, EventArgs e) {
            mob.get_damage(MainForm.selfref.gg.get_sum_inv_atk() + 10, 0);
            if (!check_win())
            {
                fight_info.Text += "Вы использовали Сильный удар и нанесли: " + (MainForm.selfref.gg.get_sum_inv_atk() + 10).ToString() + " ед. урона.\n";
                fight_gg_status.Text = "HP: " + MainForm.selfref.gg.hp.ToString();
                fight_mob_status.Text = "HP: " + mob.hp.ToString();
                fight_info.SelectionStart = fight_info.Text.Length;
                fight_info.ScrollToCaret();
                mob_step();
            }
        }

        private void fight_shield_Click(object sender, EventArgs e) {
            gg_shield = 10;
            fight_info.Text += "Вы подняли Щиты на: 10 защиты.\n";
            fight_gg_status.Text = "HP: " + MainForm.selfref.gg.hp.ToString();
            fight_mob_status.Text = "HP: " + mob.hp.ToString();
            fight_info.SelectionStart = fight_info.Text.Length;
            fight_info.ScrollToCaret();
            mob_step();
        }

        private void fight_dodge_Click(object sender, EventArgs e) {
            if (rand.Next(0, 100) >= 80) gg_dodge = true;
            mob_step();
        }

        private void fight_heal_Click(object sender, EventArgs e) {
            MainForm.selfref.gg.hp += 5;
            fight_info.Text += "Вы ипользовали Лечение на: 5 здоровья.\n";
            fight_gg_status.Text = "HP: " + MainForm.selfref.gg.hp.ToString();
            fight_mob_status.Text = "HP: " + mob.hp.ToString();
            fight_info.SelectionStart = fight_info.Text.Length;
            fight_info.ScrollToCaret();
            mob_step();
        }

        public void mob_step() {
            if (gg_dodge)
                fight_info.Text += "Противник промахнулся.\n";
            else {
                temp = mob.get_actions()[rand.Next(0, mob.get_actions().Length - 1)];
                mob.hp += temp.hp;
                MainForm.selfref.gg.get_damage(mob.get_sum_inv_atk() + temp.atk - gg_shield, 0);
                fight_info.Text += "Противник испольовал " + temp.name + " и нанес: " + (mob.get_sum_inv_atk() + temp.atk - gg_shield).ToString() + " ед. урона.\n";
            }
            fight_gg_status.Text = "HP: " + MainForm.selfref.gg.hp.ToString();
            fight_mob_status.Text = "HP: " + mob.hp.ToString();
            fight_info.SelectionStart = fight_info.Text.Length;
            fight_info.ScrollToCaret();
            check_win();
            gg_shield = 0;
            gg_dodge = false;
        }
        public bool check_win() {
            if (MainForm.selfref.gg.hp <= 0) {
                fight_info.Text += "Вы проиграли.\n";
                fight_info.SelectionStart = fight_info.Text.Length;
                fight_info.ScrollToCaret();
                MainForm.selfref.gg.hp = 100;
                mob.hp = start_mob_hp;
                fight_back.Visible = true;
                down_bar.Visible = false;
                return true;
            }
            if (mob.hp <= 0) {
                fight_info.Text += "Вы выиграли.\n";
                fight_info.SelectionStart = fight_info.Text.Length;
                fight_info.ScrollToCaret();
                MainForm.selfref.gg.hp = 100;
                mob.hp = start_mob_hp;
                fight_back.Visible = true;
                fight_trade.Visible = true;
                down_bar.Visible = false;
                return true;
            }
            return false;
        }
    }
}
