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
    public partial class MainMenu : UserControl {
        bool fullscr = false; //для фул скрин мода
        public int mode { get; set; } // мод для запуска 
        public MainMenu() {
            InitializeComponent();
        }
        // о программе
        private void pictureBox3_Click(object sender, EventArgs e) { MessageBox.Show("Данный проект разработан специально для конференции.","Информация"); }
        // фулскрин
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (fullscr) {
                MainForm.selfref.WindowState = FormWindowState.Normal;
                MainForm.selfref.FormBorderStyle = FormBorderStyle.Sizable;
                fullscr = false;
            } else {
                MainForm.selfref.WindowState = FormWindowState.Maximized;
                MainForm.selfref.FormBorderStyle = FormBorderStyle.None;
                fullscr = true;
            }
        }
        //скрыть экран меню
        private void pictureBox1_Click(object sender, EventArgs e) {
            if(mode == 0) MainForm.selfref.show_map_with_loc();
            Visible = false;
        }
    }
}
