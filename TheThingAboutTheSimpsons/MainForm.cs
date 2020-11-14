using System;
using System.Collections.Generic;
using System.IO;
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
        private List<Word> Sentence = new List<Word>();
        private List<string> BlackListedWords = new List<string>();
        public MainForm() {
            InitializeComponent();
        }

        private void submitBtn_Click(object sender, EventArgs e) {
            foreach(string s in textInput.Text.Split(' '))
            {
                if (!BlackListedWords.Contains(s.ToLower()))
                    Sentence.Add(new Word(s, false));
            }

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

        private void MainForm_Load(object sender, EventArgs e)
        {
            string path = Directory.GetCurrentDirectory() + "\\" +  "blackList.txt"; ;

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        BlackListedWords.Add(s);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            ;
        }
    }
}
