using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheThingAboutTheSimpsons {
    public class Episode {

        static int[,] tableSeasons = new int[,] { {1, 0}, { 2, 13}, { 3, 35}, { 4, 59}, { 5, 81}, { 6, 103}, { 7, 128}, { 8, 153}, { 9, 178}, { 10, 203},
            { 11, 226}, { 12, 249}, { 13, 270}, { 14, 292}, { 15, 314}, { 16, 337}, { 17, 358}, { 18, 380}, { 19, 402}, { 20, 422}, { 21, 443}, { 22, 466}, { 23, 488}, { 24, 510}, { 25, 532}, { 26, 554}, { 27, 576}, { 28, 598}, { 29, 620}, { 30, 641}, { 31, 664}, { 32, 686}};
        public string Title { get; set; }
        public double Score { get; set; }
        public int Season { get; set; }
        public int EpisodeNb { get; set; }
        public string Date { get; set; }
        public string[] summary;

        public Episode (string title, string date, int episodeNb) {
            Title = title;
            Date = date;
            EpisodeNb = episodeNb;
            for (int i = 0; i < 31; i++)
            {
                if (episodeNb >= tableSeasons[i, 1] && episodeNb < tableSeasons[i+1, 1])
                    Season = tableSeasons[i, 0];
            }
            if (episodeNb >= 686)
                Season = 32;

            Score = 0;
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
