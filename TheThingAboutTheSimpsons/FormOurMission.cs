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
        public FormOurMission()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainMenu.Show();
        }

        public void setMainMenu(MainForm mainMenu)
        {
            this.mainMenu = mainMenu;
        }
    }
}
