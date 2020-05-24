using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erroneous_move {
    [Serializable]
    public class Person_Action {
        //func
        // создание класса с параметрами
        public Person_Action(string F_name, string F_description, int F_hp, int F_atk, int F_money) {
            name = F_name;
            description = F_description;
            hp = F_hp;
            atk = F_atk;
            money = F_money;
        }
        // без параметров
        public Person_Action() { }
        //prop
        public string name { get; set; }
        public string description { get; set; }
        public int hp { get; set; }
        public int atk { get; set; }
        public int money { get; set; } // по идее цена но не раеализовано
        public Bitmap icon { get; set; } // иконка пока не используется нигде
    }
}
