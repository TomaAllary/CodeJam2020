using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheThingAboutTheSimpsons {
    class Episode {
        public string Title { get; set; }
        public int Season { get; set; }
        public int EpisodeNb { get; set; }
        public DateTime Date { get; set; }
        public string Summary { get; private set; }

        public Episode (string title, int season, int episodeNb) {
            Title = title;
            Season = season;
            EpisodeNb = episodeNb;
        }

        public EpisodeViewer InitUserCtrl() {
            EpisodeViewer episodeViewer = new EpisodeViewer();

            episodeViewer.Title.Text = Title;
            episodeViewer.seasonNbLb.Text = EpisodeNb.ToString();
            episodeViewer.seasonNbLb.Text = Season.ToString();

            if (Date != null)
                episodeViewer.dateLb.Text = Date.ToString("dddd, dd MMMM yyyy");
            else
                episodeViewer.dateLb.Text = "";

            if (Summary != null)
                episodeViewer.summaryLb.Text = Summary;
            else
                episodeViewer.summaryLb.Text = "";

            return episodeViewer;
        }
    }
}
