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
    public partial class Location_View : UserControl {
        Random rand = new Random(); // рандом
        public Location set_loc { get; set; } //локация установленная
        public Location_View() {
            InitializeComponent();
        }
        //настраиваем  полученную локацию и отображаем ее тут все просто если есть тороговец то показываем иконку торговца например и т.д.
        public void init_loc() {
            NameLoc.Text = set_loc.name;
            loc_image.Image = set_loc.texture;
            if (set_loc.isBattle) loc_fight.Visible = true;
            else loc_fight.Visible = false;
            if (set_loc.isTrade) loc_trade.Visible = true;
            else loc_trade.Visible = false;
            if (set_loc.isCity) loc_search.Visible = false;
            else loc_search.Visible = true;
            if (set_loc.isOpen) { // тут отображаем если локация для игрока закрыта
                loc_fight.Visible = false;
                loc_trade.Visible = false;
                loc_search.Visible = false;
                loc_image.Image = Properties.Resources.noopen;
                NameLoc.Text = "Здесь только туман";
            }
                
        }
        // закрыть экран локации
        private void loc_back_Click(object sender, EventArgs e) {
            Visible = false;
        }
        //открыть меню режим обычный
        private void loc_menu_btn_Click(object sender, EventArgs e) {
            MainForm.selfref.show_menu(1);
        }
        //перейти в режим боя с рандомным мобом из глобального массива всех мобов
        private void loc_fight_Click(object sender, EventArgs e)
        {
            MainForm.selfref.show_fight(MainForm.selfref.mobs[rand.Next(0, MainForm.selfref.mobs.Count - 1)]);
        }
        //зайти в инвентарь
        private void loc_inv_Click(object sender, EventArgs e)
        {
            MainForm.selfref.show_inv();
        }
        //зайти к торговцу торговец создается рандомно с рандомным инвентарем
        private void loc_trade_Click(object sender, EventArgs e)
        {
            Game_Person saller = new Game_Person();
            saller.name = "Торговец";
            saller.hp = 0;
            saller.atk = 0;
            saller.money = rand.Next(100,5000);
            saller.texture = Properties.Resources.citizen_test;
            saller.texture_action = Properties.Resources.citizen_test;
            saller.icon = Properties.Resources.citizen_test;
            saller.is_map = false;
            saller.isGamer = false;
            foreach (Inventory_Item it in MainForm.selfref.all_items)
                if (rand.Next(0, 100) >= 60) //тоже вероятность 40% дропа предмета у торгоша
                    saller.add_inventory_item(it);    
            MainForm.selfref.show_trade(true, saller); //первый параметр типа это если торговец второй объект торговца или моба
        }
        //поиск должен был быть тоже трэйдом в режиме лута мобов но не успел пока такая заглушка) 
        private void loc_search_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вы ничего не обнаружили."); 
        }
    }
}
