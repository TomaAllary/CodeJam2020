using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheThingAboutTheSimpsons {
    public partial class MainForm : Form {
        private FormAboutUs aboutUs = new FormAboutUs();
        private FormOurMission ourMission = new FormOurMission();
        public MainForm() {
            InitializeComponent();
        }

        private void submitBtn_Click(object sender, EventArgs e) {
            
        }

        private void aboutUsBtn_Click(object sender, EventArgs e)
        {
            aboutUs.setMainMenu(this);
            this.Hide();
            aboutUs.Show();
        }

        private void ourMissionBtn_Click(object sender, EventArgs e)
        {
            ourMission.setMainMenu(this);
            this.Hide();
            ourMission.Show();
        }

        public void LoadEpisodes() {

        }

        public void ParseInput(string text) {

        }

        public void showResults() {

        }
    }
}
