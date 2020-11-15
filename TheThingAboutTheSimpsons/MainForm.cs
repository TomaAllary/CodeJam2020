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
        private int lastProgress = 0;

        private List<Episode> episodesFounds;
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
            //Clear last search
            episodesFounds = null;
            Sentence.Clear();
            lastProgress = 0;

            foreach(string s in textInput.Text.Split(' '))
            {
                if (!BlackListedWords.Contains(s.ToLower())) {
                    Word word = new Word(s, false);
                    Sentence.Add(word);
                }
            }

            backgroundWorker1.RunWorkerAsync();
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
        public void showResults() {
            

            if (episodesFounds.Count > 0) {
                resultPanel.Visible = true;
                showEpisode(episodesFounds[0]);
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

        private void showEpisode(Episode ep) {
            episodeViewer1.Title.Text = ep.Title;
            episodeViewer1.episodeNbLb.Text = "Episode #" + ep.EpisodeNb.ToString();
            episodeViewer1.seasonNbLb.Text = "Season #" + ep.Season.ToString();
            episodeViewer1.dateLb.Text = ep.Date;
            episodeViewer1.summaryLb.Text = "";
            foreach(string x in ep.summary) {
                episodeViewer1.summaryLb.Text += " " + x;
            }         
            MessageBox.Show(ep.ToString());
            ;
        }

        private void nextBtn_Click(object sender, EventArgs e) {
            if (episodeIt < episodesFounds.Count - 1) {
                episodeIt++;
                showEpisode(episodesFounds[episodeIt]);
            }
        }

        private void prevBtn_Click(object sender, EventArgs e) {
            if (episodeIt > 0) {
                episodeIt--;
                showEpisode(episodesFounds[episodeIt]);
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

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e) {
            BackgroundWorker worker = sender as BackgroundWorker;
            worker.WorkerReportsProgress = true;

            episodesFounds = new List<Episode>();

            //do the thing
            int epNb = 0;
            foreach (Episode ep in episodes) {
                List<int> positionList = new List<int>();

                int progress = (int)(((double)epNb / (double)episodes.Count) * 100.0);
                if (lastProgress < progress) {
                    worker.ReportProgress(progress);
                    lastProgress = progress;
                }

                foreach (Word w in Sentence) { 
                    for (int i = 0; i < ep.summary.Length; i++) {
                        string resumeW = ep.summary[i];
                        //compare the input word with the resume words
                        if (w.word == resumeW) {
                            if (!positionList.Contains(i)) {
                                ep.Score += w.Score;
                                positionList.Add(i);
                            }
                        }
                    }
                    foreach (Word syn in w.listSynonyms) {
                        //compare the input word synonyms with the resume words
                        for (int i = 0; i < ep.summary.Length; i++) {
                            string resumeW = ep.summary[i];
                            if (syn.word == resumeW) {
                                if (!positionList.Contains(i)) {
                                    ep.Score += syn.Score;
                                    positionList.Add(i);
                                }

                            }
                        }
                    }
                }

                double avgDist = sumDistance(0, positionList);

                //ep.Score *= (1.0 / avgDist);

                //Seuil
                if (ep.Score > 3) {
                    ep.wordsChosen = positionList;
                    episodesFounds.Add(ep);
                }
                epNb++;

            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e) {
           if (progressBar1.Visible != true)
                progressBar1.Visible = true;
           progressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
            showResults();
            progressBar1.Value = 0;
            progressBar1.Visible = false;
        }

        private double sumDistance(int pos, List<int> positions) {
            if (positions.Count != 0) {
                double sum = 0;

                if (pos == positions.Count - 1)
                    return sum;

                for (int i = pos + 1; i < positions.Count; i++) {
                    sum += Math.Abs((double)positions[i] - (double)positions[pos]);
                }

                double nextSum = sumDistance(pos + 1, positions);
                if (nextSum == 0.0)
                    return sum;

                return (sum + nextSum) / 2.0;
            }
            return 1.0;
            
        }
    }
}
