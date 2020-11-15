using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheThingAboutTheSimpsons {
    public class Episode {

        static int[,] tableSeasons = new int[,] { {1, 1}, { 2, 14}, { 3, 36}, { 4, 60}, { 5, 82}, { 6, 104}, { 7, 129}, { 8, 154}, { 9, 179}, { 10, 204},
            { 11, 227}, { 12, 249}, { 13, 270}, { 14, 292}, { 15, 314}, { 16, 336}, { 17, 357}, { 18, 379}, { 19, 401}, { 20, 421}, { 21, 442}, { 22, 465}, { 23, 487}, { 24, 509}, { 25, 531}, { 26, 553}, { 27, 575}, { 28, 597}, { 29, 619}, { 30, 640}, { 31, 663}, { 32, 685}};
        public string Title { get; set; }
        public double Score { get; set; }
        public int Season { get; set; }
        public int EpisodeNb { get; set; }
        public int NumberInSeason { get; set; }
        public string Date { get; set; }
        public string[] summary;

        public Episode (string title, string date, int episodeNb) {
            Title = title;
            Date = date;
            EpisodeNb = episodeNb;
            for (int i = 0; i < 31; i++)
            {
                if (episodeNb >= tableSeasons[i, 1] && episodeNb < tableSeasons[i + 1, 1])
                {
                    Season = tableSeasons[i, 0];
                    NumberInSeason = (episodeNb + 1 - tableSeasons[i, 1]);
                }
            }
            if (episodeNb >= 685)
            {
                Season = 32;
                NumberInSeason = episodeNb + 1 - 685;
            }

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
