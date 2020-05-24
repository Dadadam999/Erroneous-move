using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erroneous_move {
    [Serializable]
    public class Map {
        //func
        // класс сразу с параметрами
        public Map(string F_name, string F_description, int F_width_map, int F_height_map) {
            name = F_name;
            description = F_description;
            width_map = F_width_map;
            height_map = F_height_map;
        }
        // класс без параметров
        public Map() { }
        //prop
        public string name { get; set; }
        public string description { get; set; }
        public Bitmap texture { get; set; } // картинка карты
        public int width_map { get; set; } // размеры карты
        public int height_map { get; set; }
        //mass
        List<Location> loc_mass = new List<Location>(); //  массив локаций на карте и все функции к нему
        public void add_location(Location location) { loc_mass.Add(location); }
        public void add_range_location(Location[] location) { loc_mass.AddRange(location); }
        public void remove_location(Location location) { loc_mass.Remove(location); }
        public void clear_location() { loc_mass.Clear(); }
        public Location[] get_location() { return loc_mass.ToArray(); }
    }
}
