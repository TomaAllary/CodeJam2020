using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheThingAboutTheSimpsons {
    public class Episode {
        public string Title { get; set; }
        public int Season { get; set; }
        public int EpisodeNb { get; set; }
        public string Date { get; set; }
        public string[] summary;

        public Episode (string title, string date, int episodeNb) {
            Title = title;
            Date = date;
            EpisodeNb = episodeNb;
        }

        public EpisodeViewer InitUserCtrl() {
            EpisodeViewer episodeViewer = new EpisodeViewer();

            episodeViewer.Title.Text = Title;
            episodeViewer.seasonNbLb.Text = EpisodeNb.ToString();
            episodeViewer.seasonNbLb.Text = Season.ToString();

            if (Date != null)
                episodeViewer.dateLb.Text = Date;
            else
                episodeViewer.dateLb.Text = "";

            if (summary != null) {
                string text = "";
                foreach(var x in summary) {
                    text += " " + x;
                }
                episodeViewer.summaryLb.Text = text;
            }
            else
                episodeViewer.summaryLb.Text = "";

            return episodeViewer;
        }
    }
}
