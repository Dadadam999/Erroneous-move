using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erroneous_move {
    [Serializable]
    public class Inventory_Item {
        //func
        // функция для создания класса с параметрами
        public Inventory_Item(string F_name, string F_description, int F_hp, int F_atk, int F_money, Bitmap v_icon, string v_type, bool v_isDress) {
            name = F_name;
            description = F_description;
            hp = F_hp;
            atk = F_atk;
            money = F_money;
            icon = v_icon;
            type = v_type;
            isDress = v_isDress;
        }
        //  обычная функция создания но параметр одет ли предмет на персонаже всегда по умолчанию нет
        public Inventory_Item() {
            isDress = false;
        }
        //prop
        public string name { get; set; }
        public string description { get; set; }
        public bool isDress { get; set; } // одет ли на персонаже предмет
        public int hp { get; set; }
        public int atk { get; set; }
        public int money { get; set; } //  стоимость
        public Bitmap icon { get; set; } 
        public string type { get; set; } // booth, armor, helmet, weapon1, weapon2, extra, horse
        // в зависимости от типа определяется куда одевать
    }
}
