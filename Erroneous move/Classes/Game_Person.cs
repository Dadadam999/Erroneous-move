using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erroneous_move {
    [Serializable]
    public class Game_Person {
        //поля для просчета данных в классе 
        private int culc = 0; // не используется
        private int culc_atk = 0; // считать атаку 
        private int culc_hp = 0; // считать хп 
        //func
        //  функция чтобы можно было создавать класс сразу со всеми параметрами
        public Game_Person(string F_name, int F_hp, int F_atk, int F_money, string location, Inventory_Item[] inv) {
            name = F_name;
            hp = F_hp;
            atk = F_atk;
            money = F_money;
            current_location = location;
            inv_mass.AddRange(inv);
        }
        // функция для обычного создания класса
        public Game_Person() { }
        // функуия получения урона персонажем
        public void get_damage(int F_atk ,int F_money) {
            culc_hp = 0;
            if (inv_mass.Count > 0)
              foreach (Inventory_Item it in inv_mass)
                if(it.isDress)
                        culc_hp += it.hp;
            if (F_atk > 0)
                hp = culc_hp + hp - F_atk;
        }
        // функция которая возвращает атаку персонажа с учетом инвентаря
        public int get_sum_inv_atk() {
            culc_atk = 0;
            if (inv_mass.Count > 0)
                foreach (Inventory_Item it in inv_mass)
                    if (it.isDress) 
                        culc_atk += it.atk;
            if ((culc_atk + atk) < 0) return 0;
            else return culc_atk + atk;
        }
        //prop
        public string name { get; set; }
        public int hp { get; set; }
        public int atk { get; set; }
        public int money { get; set; }
        public string current_location { get; set; } // текущая локация, пока не используется нужно будет для сохранения
        public Bitmap texture { get; set; } // большая картинка 
        public Bitmap texture_action { get; set; } //  картинка анимации персонажа, пока не реализовано
        public Bitmap icon { get; set; } // картинка котороя отображается на карте  
        public int map_x { get; set; } // положение на карте
        public int map_y { get; set; }
        public bool is_map { get; set; } // отоброжать на карте
        public bool isGamer { get; set; } //игрок или нет
        //mass
        public List<Inventory_Item> inv_mass = new List<Inventory_Item>(); // массив и его функции инвентаря персонажа
        public void add_inventory_item(Inventory_Item item) { inv_mass.Add(item); }
        public void add_range_inventory_item(Inventory_Item[] item) { inv_mass.AddRange(item); }
        public void remove_inventory_item(Inventory_Item item) { inv_mass.Remove(item); }
        public void clear_inventory_item(Inventory_Item item) { inv_mass.Clear(); }
        public Inventory_Item[] get_inventory_item() { return inv_mass.ToArray(); }
       
        List<Person_Action> action_mass = new List<Person_Action>(); //  массив действий персонажа
        public void add_action(Person_Action action) { action_mass.Add(action); }
        public void add_range_action(Person_Action[] action) { action_mass.AddRange(action); }
        public void remove_action(Person_Action action) { action_mass.Remove(action); }
        public void clear_action(Person_Action action) { action_mass.Clear(); }
        public Person_Action[] get_actions() { return action_mass.ToArray(); }
    }
}
