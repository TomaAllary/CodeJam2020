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

        private List<EpisodeViewer> resultsEpViews;
        private int episodeIt;
        private Point position = new Point();
        List<Episode> episodes = new List<Episode>();

        public MainForm() {
            LoadEpisodes();

            InitializeComponent();
            ourMission.setMainMenu(this);
            ourMission.setPosition();
            aboutUs.setMainMenu(this);
            aboutUs.setPosition();
        }

        private void submitBtn_Click(object sender, EventArgs e) {
            foreach(string s in textInput.Text.Split(' '))
            {
                if (!BlackListedWords.Contains(s.ToLower()))
                    Sentence.Add(new Word(s, false));
            }
            ;
        }

        private void aboutUsBtn_Click(object sender, EventArgs e)
        {
            aboutUs.setPosition();
            this.Hide();
            aboutUs.Show();
        }

        private void ourMissionBtn_Click(object sender, EventArgs e)
        {
            ourMission.setPosition();
            this.Hide();
            ourMission.Show();
        }

        public void setPosition(Form lastForm) {
            position.X = lastForm.Location.X;
            position.Y = lastForm.Location.Y;
            this.Location = position;
        }
        public void LoadEpisodes() {
            string text = System.IO.File.ReadAllText("summaries.txt");
            /*List<string> epDate = new List<string>();
            List<string[]> epWords = new List<string[]>();*/

            text = text.ToLower();
            int it = -1;
            while (text != "") {
                string line = text.Substring(0, text.IndexOf('\n'));
                if (line.Contains('#')) {
                    it++;
                    
                    var i = line.IndexOf('#');
                    string epName = line.Substring(0, i - 2);
                    string date = line.Substring(line.IndexOf('\t') + 1).TrimEnd('\r');

                    episodes.Add(new Episode(epName, date, it + 1));
                }
                else {
                    //Console.WriteLine(line);
                    string[] split = line.Split(new Char[] { ' ', '(', ')', ',', '.', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                    if (split[0] != "notes:" && split[0] != "note:" && split[0] != "note " && split[0] != "notes ") {
                        episodes[it].summary = split;
                    }
                }
                text = text.Remove(0, text.IndexOf('\n') + 1);
            }
            int a = 0; //useless
            ;

            /*
            test.Add("foo");
            test.Add("bar");
            
            epWords.Add(test);
            Console.WriteLine(epWords[0][0]); //prints "foo"
            Console.WriteLine(epWords[0][1]); // prints "bar"
            while (true) ;
            */
        }

        public void ParseInput(string text) {

        }

        public List<Episode> Search() {
            List<Episode> episodesFounds = new List<Episode>();

            //do the thing

            return episodesFounds;
        }

        public void showResults() {
            resultsEpViews = new List<EpisodeViewer>();

            foreach(Episode ep in Search()) {
                resultsEpViews.Add(ep.InitUserCtrl());
            }

            if (resultsEpViews.Count > 0) {
                resultPanel.Visible = true;
                showEpisode(resultsEpViews[0]);
                episodeIt = 0;
                label1.Text = "Yup, They d'OH it!";
                label1.BackColor = Color.Green;
            }
            else {
                resultPanel.Visible = false;

                label1.Text = "No similar episode :(";
                label1.BackColor = Color.Red;
            }
        }

        private void showEpisode(EpisodeViewer ep) {
            episodeViewer1 = ep;
        }

        private void nextBtn_Click(object sender, EventArgs e) {
            if (episodeIt < resultsEpViews.Count - 1) {
                episodeIt++;
                showEpisode(resultsEpViews[episodeIt]);
            }
        }

        private void prevBtn_Click(object sender, EventArgs e) {
            if (episodeIt > 0) {
                episodeIt--;
                showEpisode(resultsEpViews[episodeIt]);
            }
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
        
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
