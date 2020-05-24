using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Erroneous_move {
    public partial class MainForm : Form {
        public static MainForm selfref {get; set; } // нужно чтобы через это свойство обращаться к главной форме и всем ее свойствам и функциям из любой части программы
        public Fight_View fight_v; // создаем объект экрана боя
        public Inventory_View inv_v; // создаем объект экрана инвенторя
        public Location_View loc_v; // создаем объект экрана локаций
        public MainMenu menu_v; // создаем объект экран меню
        public Trade_View trade_v; // создаем объект экрана трэйда
        public Map_View map_v; // создаем объект экран карты
        public Map global_map; // гломбальная переменная карты
        Location loc; // временная переменная для создания локаций 
        Game_Person gp; // временная переменная для создания персонажей
        Inventory_Item it; // временная переменная для создания предметов инвентаря
        public List<Location> locactions = new List<Location>(); // глобальный массив всех локаций
        public List<Game_Person> mobs = new List<Game_Person>(); // глобальны массив всех мобов
        public List<Inventory_Item> all_items = new List<Inventory_Item>(); // глобальны массив всех предметов инвентаря
        public Game_Person gg { get; set; } //глобальное свойтсво главного героя 
        public MainForm() {
            InitializeComponent();
            selfref = this; // помещаем форму в в свойство этой же формы короче сложна не важно
            ResizeRedraw = true; // нужно чтобы не так отрисовка лагала
            init_mobs(); //функции инициализации всякого
            init_locations();
            init_map();
            init_items();
            init_gg_new_game();
            //размещаем на форме все экраны но показываем только меню
            fight_v = new Fight_View();
            fight_v.Dock = DockStyle.Fill;
            Controls.Add(fight_v);
            inv_v = new Inventory_View();
            inv_v.Dock = DockStyle.Fill;
            Controls.Add(inv_v);
            loc_v = new Location_View();
            loc_v.Dock = DockStyle.Fill;
            Controls.Add(loc_v);
            menu_v = new MainMenu();
            menu_v.Dock = DockStyle.Fill;
            Controls.Add(menu_v);
            trade_v = new Trade_View();
            trade_v.Dock = DockStyle.Fill;
            Controls.Add(trade_v);
            map_v = new Map_View(global_map);
            map_v.Dock = DockStyle.Fill;
            Controls.Add(map_v);
        }

        private void MainForm_Load(object sender, EventArgs e) {
            show_menu(0); // показываем меню вначале игры 0 - режим меню начала игры
        }
        #region вывод юзер контролов 
        public void show_menu(int mode) { //0 - start game
            menu_v.mode = mode;
            menu_v.Visible = true;
            menu_v.BringToFront();
        }

        public void show_fight(Game_Person mob) // передаем в экран моба которого нужно
        {
            fight_v.mob = mob;
            fight_v.set_fight();
            fight_v.Visible = true;
            fight_v.BringToFront();
        }

        public void show_inv() //показать инентарь
        {
            inv_v.refrash_inv();
            inv_v.Visible = true;
            inv_v.BringToFront();
        }

        public void show_loc(Location loc) //показать локу и передать локу 
        {
            loc_v.set_loc = loc;
            loc_v.init_loc();
            loc_v.Visible = true;
            loc_v.BringToFront();
        }

        public void show_trade(bool saller, Game_Person mob) // тут короче типа торговец ли моб и передаем моба
        {
            trade_v.isSaller = saller;
            trade_v.mob = mob;
            trade_v.set_trade();
            trade_v.Visible = true;
            trade_v.BringToFront();
        }

        public void show_map_with_loc() { // показать карту с локами
            map_v.Visible = true;
            map_v.BringToFront();
        }
        #endregion
        //настраиваем гг
        public void init_gg_new_game() {
            gg = new Game_Person();
            gg.name = "игрок";
            gg.hp = 100;
            gg.atk = 10;
            gg.money = 500;
            gg.texture = Properties.Resources.citizen_test;
            gg.texture_action = Properties.Resources.citizen_test;
            gg.icon = Properties.Resources.citizen_test;
            gg.is_map = true;
            gg.isGamer = true;
            gg.map_x = 200;
            gg.map_y = 200;
            //кидаем в инвентарь одежду
            gg.add_inventory_item(all_items.Find(item => item.name == "Топор"));
            gg.add_inventory_item(all_items.Find(item => item.name == "Обычная одежда"));
            gg.add_inventory_item(all_items.Find(item => item.name == "Обычная лошадь"));
            //одеваем вещи на персонажа
            gg.inv_mass.Find(item => item.name == "Топор").isDress = true;
            gg.inv_mass.Find(item => item.name == "Обычная одежда").isDress = true;
            gg.inv_mass.Find(item => item.name == "Обычная лошадь").isDress = true;
        }

        // арбалетчик елитный рыцарь призрак гонец молот наездник пеший рыцарь щитовик алебарда викинг деревенщина волк призрак 2
        //настраиваем мобов
        public void init_mobs() {
            gp = new Game_Person();
            gp.name = "лучник";
            gp.hp = 120;
            gp.atk = 30;
            gp.texture = Properties.Resources.archer_test;
            gp.texture_action = Properties.Resources.archer_test;
            gp.icon = Properties.Resources.archer_test;
            gp.is_map = true;
            gp.isGamer = false;
            //добавляем так возможности мобов ну там удары хилы и прочее
            gp.add_action(new Person_Action("Выстрел стрелой","",0,10,0));
            gp.add_action(new Person_Action("Выстрел двумя стрелами", "", 0, 20, 0));
            gp.add_action(new Person_Action("Лечение", "", 10, 0, 0));
            mobs.Add(gp);

            gp = new Game_Person();
            gp.name = "топорщик";
            gp.hp = 150;
            gp.atk = 40;
            gp.texture = Properties.Resources.axe_test;
            gp.texture_action = Properties.Resources.axe_test;
            gp.icon = Properties.Resources.axe_test;
            gp.is_map = true;
            gp.isGamer = false;
            gp.add_action(new Person_Action("Удар", "", 0, 10, 0));
            gp.add_action(new Person_Action("Сильный удар", "", 0, 20, 0));
            gp.add_action(new Person_Action("Лечение", "", 10, 0, 0));
            mobs.Add(gp);

            gp = new Game_Person();
            gp.name = "медведь";
            gp.hp = 200;
            gp.atk = 60;
            gp.texture = Properties.Resources.bear_еуые;
            gp.texture_action = Properties.Resources.bear_еуые;
            gp.icon = Properties.Resources.bear_еуые;
            gp.is_map = true;
            gp.isGamer = false;
            gp.add_action(new Person_Action("Удар", "", 0, 10, 0));
            mobs.Add(gp);
            // хз почему но этот чувак не появляется в бою =Д
            gp = new Game_Person();
            gp.name = "гражданин";
            gp.hp = 100;
            gp.atk = 10;
            gp.texture = Properties.Resources.citizen_test;
            gp.texture_action = Properties.Resources.citizen_test;
            gp.icon = Properties.Resources.citizen_test;
            gp.is_map = true;
            gp.isGamer = false;
            gp.add_action(new Person_Action("Удар", "", 0, 10, 0));
            gp.add_action(new Person_Action("Лечение", "", 10, 0, 0));
            mobs.Add(gp);
        }
        // настраиваем локации
        public void init_locations() {
            loc = new Location();
            loc.name = "Город 1";
            loc.description = "Первый город";
            loc.icon = Properties.Resources.Castle_test;
            loc.texture = Properties.Resources.castle_back_test;
            loc.isCity = true;
            loc.x_map = 500;
            loc.y_map = 500;
            locactions.Add(loc);

            loc = new Location();
            loc.name = "Город 2";
            loc.description = "Воторой город";
            loc.icon = Properties.Resources.Castle_test;
            loc.texture = Properties.Resources.castle_back_test2;
            loc.isCity = true;
            loc.x_map = 200;
            loc.y_map = 400;
            locactions.Add(loc);

            loc = new Location();
            loc.name = "Город 3";
            loc.description = "Третий город";
            loc.icon = Properties.Resources.Castle_test;
            loc.texture = Properties.Resources.castle_back_test3;
            loc.isCity = true;
            loc.isTrade = true;
            loc.x_map = 600;
            loc.y_map = 300;
            locactions.Add(loc);

            loc = new Location();
            loc.name = "Руины";
            loc.description = "???";
            loc.icon = Properties.Resources.ruine_test;
            loc.texture = Properties.Resources.ruine_test1;
            loc.isCity = false;
            loc.isBattle = true;
            loc.x_map = 300;
            loc.y_map = 500;
            locactions.Add(loc);
        }
        //настраиваем карту
        public void init_map() {
            global_map = new Map();
            global_map.name = "Мир";
            global_map.description = "главный мир";
            global_map.width_map = 800;
            global_map.height_map = 600;
            global_map.texture = Properties.Resources.map2;
            global_map.add_range_location(locactions.ToArray());
        }

        //сюда делать итемы
        public void init_items() {
            it = new Inventory_Item();
            it.name = "Топор";
            it.description = "Обычный топор. Который обычно используют викинги";
            it.icon = Properties.Resources.axe;
            it.atk = 40;
            it.hp = 0;
            it.money = 50;
            it.type = "weapon1"; // это прямо важно ппц типа тип указывай правильно иначе не оденешь
            all_items.Add(it);

            it = new Inventory_Item();
            it.name = "Обычная одежда";
            it.description = "Такую одежду обычно носят горожане и крестьене.";
            it.icon = Properties.Resources.sitizen_armor;
            it.atk = 0;
            it.hp = 10;
            it.money = 10;
            it.type = "armor";
            all_items.Add(it);

            it = new Inventory_Item();
            it.name = "Обычная лошадь";
            it.description = "Обычная прирученная лошадь.";
            it.icon = Properties.Resources.horse;
            it.atk = 50;
            it.hp = 40;
            it.money = 1050;
            it.type = "horse";
            all_items.Add(it);

        }
        // определяем нажатие клавиш
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W) map_v.control_hero("Up");
            if (e.KeyCode == Keys.A) map_v.control_hero("Left");
            if (e.KeyCode == Keys.D) map_v.control_hero("Right");
            if (e.KeyCode == Keys.S) map_v.control_hero("Down");
        }
    }
}
