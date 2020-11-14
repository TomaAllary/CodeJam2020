using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheThingAboutTheSimpsons
{
    public partial class FormOurMission : Form
    {
        private MainForm mainMenu;
        private Point position = new Point();
        public FormOurMission()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainMenu.Show();
        }

        public void setPosition() {
            position.X = mainMenu.Location.X;
            position.Y = mainMenu.Location.Y;
            this.Location = new Point(position.X,position.Y);
        }

        public void setMainMenu(MainForm mainMenu)
        {
            this.mainMenu = mainMenu;
        }
    }
}
