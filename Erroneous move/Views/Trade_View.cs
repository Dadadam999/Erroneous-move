using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Erroneous_move
{
    public partial class Trade_View : UserControl
    {
        Random rand = new Random(); // рандом
        public bool isSaller { get; set; } //свойтство торговец или лутать
        public Game_Person mob { get; set; } //моб с которым трэйдится
        public Trade_View()
        {
            InitializeComponent();
        }
        //настраиваем трэйд
        public void set_trade() { 
            trade_money_gg.Text = MainForm.selfref.gg.money.ToString(); //присваиваем игроку деньги
            foreach (PictureBox p in trade_gg_container.Controls) { //обнуляем отрисовку итемов игрока и моба
                p.Tag = "";
                p.Image = Properties.Resources.empty;
            }
            foreach (PictureBox p in trade_mob_container.Controls) {
                p.Tag = "";
                p.Image = Properties.Resources.empty;
            }
            //помещаем в инвентарь итемы игрока
            int k_it = 0;
            foreach (Inventory_Item it in MainForm.selfref.gg.get_inventory_item()) { //перебираем итемы и добавляем их в ячейки
                ((PictureBox)trade_gg_container.Controls[k_it]).Image = it.icon;
                ((PictureBox)trade_gg_container.Controls[k_it]).Tag = it.name; // сохраянем имя предмета в тег
                k_it++;
            }
            //помещаем в инвентарь итемы мода
            k_it = 0;
            if (!isSaller)
            {
                trade_money_mob.Text = ""; //если не торговец то значит лут и нет денег у моба
                foreach (Inventory_Item it in mob.get_inventory_item()) //перебираем итемы и добавляем их в ячейки
                {
                    ((PictureBox)trade_mob_container.Controls[k_it]).Image = it.icon;
                    ((PictureBox)trade_mob_container.Controls[k_it]).Tag = it.name; // сохраянем имя предмета в тег
                    k_it++;
                }
            }
            else
            {
                trade_money_mob.Text = mob.money.ToString(); // выводим деньги моба
                foreach (Inventory_Item it in mob.get_inventory_item()) // добавляем в ячейки итемы моба
                {
                    ((PictureBox)trade_mob_container.Controls[k_it]).Image = it.icon;
                    ((PictureBox)trade_mob_container.Controls[k_it]).Tag = it.name;
                    k_it++;
                }
            }


        }
        //единая функция нажатия на ячейки игрока
        private void gg_el_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (isSaller)
                {
                    if (mob.money >= MainForm.selfref.all_items.Find(item => item.name == ((PictureBox)sender).Tag.ToString()).money)
                    {
                        // убавляем деньги у моба и прибаляем к игроку
                        mob.money -= MainForm.selfref.all_items.Find(item => item.name == ((PictureBox)sender).Tag.ToString()).money;
                        MainForm.selfref.gg.money += MainForm.selfref.all_items.Find(item => item.name == ((PictureBox)sender).Tag.ToString()).money;
                        // удаляем предмет у моба и прибавляем к игроку
                        MainForm.selfref.gg.remove_inventory_item(MainForm.selfref.all_items.Find(item => item.name == ((PictureBox)sender).Tag.ToString()));
                        mob.add_inventory_item(MainForm.selfref.all_items.Find(item => item.name == ((PictureBox)sender).Tag.ToString()));
                        // очищаем ячейку
                        ((PictureBox)sender).Tag = ""; 
                        ((PictureBox)sender).Image = Properties.Resources.empty;
                        // обновляем данные
                        set_trade();
                    }
                }
                else {
                    // тоже самое только без бабла
                    MainForm.selfref.gg.remove_inventory_item(MainForm.selfref.all_items.Find(item => item.name == ((PictureBox)sender).Tag.ToString()));
                    mob.add_inventory_item(MainForm.selfref.all_items.Find(item => item.name == ((PictureBox)sender).Tag.ToString()));
                    ((PictureBox)sender).Tag = "";
                    ((PictureBox)sender).Image = Properties.Resources.empty;
                    set_trade();
                }
                 
            }
            catch (System.NullReferenceException) { }
        }
        // единая функция для ячеек моба все тоже самое что и с игроком только в обратную сторону 
        private void mob_el_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (isSaller)
                {
                    if (MainForm.selfref.gg.money >= MainForm.selfref.all_items.Find(item => item.name == ((PictureBox)sender).Tag.ToString()).money && !MainForm.selfref.gg.inv_mass.Contains(MainForm.selfref.all_items.Find(item => item.name == ((PictureBox)sender).Tag.ToString())))
                    {

                        MainForm.selfref.gg.money -= MainForm.selfref.all_items.Find(item => item.name == ((PictureBox)sender).Tag.ToString()).money;
                        mob.money += MainForm.selfref.all_items.Find(item => item.name == ((PictureBox)sender).Tag.ToString()).money;

                        mob.remove_inventory_item(MainForm.selfref.all_items.Find(item => item.name == ((PictureBox)sender).Tag.ToString()));
                        MainForm.selfref.gg.add_inventory_item(MainForm.selfref.all_items.Find(item => item.name == ((PictureBox)sender).Tag.ToString()));
                        ((PictureBox)sender).Tag = "";
                        ((PictureBox)sender).Image = Properties.Resources.empty;
                        set_trade();
                    }
                }
                else
                {
                    if (!MainForm.selfref.gg.inv_mass.Contains(MainForm.selfref.all_items.Find(item => item.name == ((PictureBox)sender).Tag.ToString())))
                    {
                        mob.remove_inventory_item(MainForm.selfref.all_items.Find(item => item.name == ((PictureBox)sender).Tag.ToString()));
                        MainForm.selfref.gg.add_inventory_item(MainForm.selfref.all_items.Find(item => item.name == ((PictureBox)sender).Tag.ToString()));
                        ((PictureBox)sender).Tag = "";
                        ((PictureBox)sender).Image = Properties.Resources.empty;
                        set_trade();
                    }
                }
            }
            catch (System.NullReferenceException) { }
        }
        // назад
        private void inv_back_Click(object sender, EventArgs e)
        {
            Visible = false;
        }
        // меню
        private void inv_menu_btn_Click(object sender, EventArgs e)
        {
            MainForm.selfref.show_menu(1);
        }
    }
}
