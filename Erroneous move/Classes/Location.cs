using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erroneous_move {
    [Serializable]
    public class Location {
        //func
        // функция с параметрами
        public Location(string F_name, string F_description, bool F_isBattle, bool F_isTrade, bool F_isCity, bool F_isOpen, int F_x_map, int F_y_map) {
            name = F_name;
            description = F_description;
            isBattle = F_isBattle;
            isTrade = F_isTrade;
            isCity = F_isCity;
            isOpen = F_isOpen;
            x_map = F_x_map;
            y_map = F_y_map;
        }
        // функция без параметров но некоторые свойства поставленны по умолчанию нет
        public Location() {
            isBattle = false;
            isTrade = false;
            isCity = false;
            isOpen = false;
        }
        //prop
        public string name { get; set; }
        public string description { get; set; }
        public bool isBattle { get; set; } // есть бой?
        public bool isTrade { get; set; } // есть торговец?
        public bool isCity { get; set; } // локация город?
        public bool isOpen { get; set; } //  доступна игроку иначе туман
        public Bitmap texture { get; set; } // картинка локации 
        public Bitmap icon { get; set; } // иконка локации на карте
        public int x_map { get; set; } // положение на карте
        public int y_map { get; set; }
    }
}