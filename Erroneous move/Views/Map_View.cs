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
    public partial class Map_View : UserControl {
        PictureBox place; // временная переменная
        List<PictureBox> mobs = new List<PictureBox>(); // массив мобов
        Bitmap im_map;  // первоночальная картинка карты
        Bitmap im_map_temp; // временная с отрисовкой мобов
        Random rand = new Random(); // рандом
        public Map set_map { get; set; } //помещаем сюда карту которую отображаем
        public static Map_View selfref_map {get; set; } //нужно чтобы обращаться к этому экрану из всей программы
        public Map_View(Map map) {
            InitializeComponent();
            set_map = map; // сохраняем карту на экране
            selfref_map = this; 
            ResizeRedraw = true;
            loc_container.Width = map.width_map; //помещаем на картинку
            loc_container.Height = map.height_map;
            loc_container.BackgroundImage = map.texture;
            im_map = map.texture;
            im_map_temp = new Bitmap(map.texture);
            foreach (Location loc in map.get_location()) { // отривовываем локи
                place = new PictureBox();
                place.Tag = loc.name + "|" + loc.description; // сохраняем в тэг пикчербокса имя и описание чтобы потом выводить в подсказке
                place.Image = loc.icon;
                place.Width = loc_container.Width/6; // иконка имеет резиновый размер типа всегда одной пропорции с картой
                place.Height = loc_container.Height / 6;
                place.Top = loc.y_map; // координаты на карте
                place.Left = loc.x_map;
                place.SizeMode = PictureBoxSizeMode.Zoom; // мод масштабирования картинки
                place.MouseEnter += new System.EventHandler(place_MouseEnter); //эвенты отслеживания мышки для подсказки 
                place.MouseLeave += new System.EventHandler(place_MouseLeave);
                loc_container.Controls.Add(place); //добавляем на карту
            }
            loc_container.Controls.Add(info_loc);//добавляем локацию
            loc_container.Controls.Add(hero); //добавляем гг
            hero.BringToFront(); //помещаем гг поверх всех
            centering_map();//сентрируем карту

            timer1.Start(); //запускаем таймер
        }
        //получаем управление с формы по нажатию клавиш
        public void control_hero(string key) {
            if(key == "Up") {
                MainForm.selfref.gg.map_y -= 5;
                hero.Top -= 5;
            }
            if (key == "Left") {
                MainForm.selfref.gg.map_x -= 5;
                hero.Left -= 5;
            }
            if (key == "Right") {
                MainForm.selfref.gg.map_x += 5;
                hero.Left += 5;
            }
            if (key == "Down") {
                MainForm.selfref.gg.map_y += 5;
                hero.Top += 5;
            }
        }
        // обработка подсказки
        private void place_MouseEnter(object sender, EventArgs e) {
            name_loc.Text = ((PictureBox)sender).Tag.ToString().Split('|')[0];
            desc_loc.Text = ((PictureBox)sender).Tag.ToString().Split('|')[1];
            info_loc.Top = ((PictureBox)sender).Top;
            info_loc.Left = ((PictureBox)sender).Left + ((PictureBox)sender).Width;
            info_loc.Visible = true;
            info_loc.BringToFront();
        }
        //ее скрывание
        private void place_MouseLeave(object sender, EventArgs e) {
            info_loc.Visible = false;
        }
        // функция отцентровки карты
        void centering_map() {
            loc_container.Top = Height / 2 - loc_container.Height / 2;
            loc_container.Left = Width / 2 - loc_container.Width / 2;
        }
        // центруем карту и панель при изменнеие размеров формы
        private void Map_View_Resize(object sender, EventArgs e) {
            centering_map();
            contrl.Top = Height - contrl.Height;
            contrl.Left = Width - contrl.Width;
            daynight.Top = 0;
            daynight.Left = Width - daynight.Width;
            open_menu.Top = 0;
            open_menu.Left = 0;
        }
        // двигаем карту
        private void c_up_Click(object sender, EventArgs e) {
            loc_container.Top += 5;
        }

        private void c_left_Click(object sender, EventArgs e) {
            loc_container.Left += 5;
        }

        private void c_down_Click(object sender, EventArgs e) {
            loc_container.Top -= 5;
        }

        private void c_right_Click(object sender, EventArgs e) {
            loc_container.Left -= 5;
        }
        // центрируем карту кнопкой на компасе в центре
        private void c_center_Click(object sender, EventArgs e) { centering_map(); }
        // таймер
        private void timer1_Tick(object sender, EventArgs e) {
            // часы
            daynight.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            daynight.Refresh();
            // отрисвывыем мобов
            using (var g = Graphics.FromImage(im_map_temp)) {
                g.DrawImage(im_map, 0, 0);
                foreach (Game_Person gp in MainForm.selfref.mobs)
                    if (gp.is_map && rand.Next(0, 100) >= 60) { // опредеяем можно ли на карте показывать и шанс появления в 40%
                        int s_x = rand.Next(0, loc_container.Width - loc_container.Width / 9);
                        int s_y = rand.Next(0, loc_container.Height - loc_container.Height / 8);
                        int e_x = loc_container.Width / 9;
                        int e_y = loc_container.Height / 8;
                        g.DrawImage(gp.icon, new Rectangle(s_x, s_y, e_x, e_y)); // рисуем
                        check_fight(new Point(s_x, s_y), new Point(e_x, e_y), gp); //проверяем на бой но не работает хз почему
                    }
                g.Dispose(); //осовобождеаем память
            }
            loc_container.Image = im_map_temp; //показываем отрисовку мобов
            loc_container.Refresh(); //обовляем
        }
          

        private void open_menu_Click(object sender, EventArgs e)
        {
            MainForm.selfref.show_menu(1); //режим меню при работе игры
        }
        //инвентраь
        private void loc_inv_Click(object sender, EventArgs e)
        {
            MainForm.selfref.show_inv();
        }
        //зайти в локацию тут много расчетов но суть что просто определяется мол если иконка города и гг пересекаются как прямоугольники то можно зайти в эту локацию
        private void pictureBox2_Click(object sender, EventArgs e) {
            Point hero1, hero2, loc1, loc2, centerA, centerB;
            int distX, distY, sumX, sumY; //а1,а2,б1 и б2 уже даны
            hero1 = new Point(hero.Left,hero.Top);
            hero2 = new Point(hero.Left + hero.Width, hero.Top + hero.Height);
            centerA = new Point((hero2.X + hero1.X) / 2, (hero2.Y + hero1.Y) / 2);

            foreach (Location loc in set_map.get_location()) {      
                loc1 = new Point(loc.x_map, loc.y_map);
                loc2 = new Point(loc.x_map + loc_container.Width / 6, loc.y_map + loc_container.Height / 6);

                centerB = new Point((loc2.X + loc1.X) / 2, (loc2.Y + loc1.Y) / 2);
                distX = Math.Abs(centerA.X - centerB.X);
                distY = Math.Abs(centerA.Y - centerB.Y);
                sumX = ((hero2.X - hero1.X) / 2) + (loc2.X - loc1.X) / 2;
                sumY = ((hero2.Y - hero1.Y) / 2) + (loc2.Y - loc1.Y) / 2;

                if (distX <= sumX && distY <= sumY) {
                    MainForm.selfref.show_loc(loc);
                    break;
                }
                    
            }
        }
        //тоже самое что и в прошлой функции но для мобов при их респе на карте но не работает
        void check_fight(Point mob1, Point mob2, Game_Person mob) {
            Point hero1, hero2, centerA, centerB;
            int distX, distY, sumX, sumY; //а1,а2,б1 и б2 уже даны
            hero1 = new Point(hero.Left, hero.Top);
            hero2 = new Point(hero.Left + hero.Width, hero.Top + hero.Height);
            centerA = new Point((hero2.X + hero1.X) / 2, (hero2.Y + hero1.Y) / 2);
            centerB = new Point((mob2.X + mob1.X) / 2, (mob2.Y + mob1.Y) / 2);
            distX = Math.Abs(centerA.X - centerB.X);
            distY = Math.Abs(centerA.Y - centerB.Y);
            sumX = ((hero2.X - hero1.X) / 2) + (mob2.X - mob1.X) / 2;
            sumY = ((hero2.Y - hero1.Y) / 2) + (mob2.Y - mob1.Y) / 2;
            if (distX <= sumX && distY <= sumY)              
                    MainForm.selfref.show_fight(mob);
        }
    }
}
