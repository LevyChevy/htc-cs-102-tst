using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MovieApplication
{
    public class Movie
    {
        public string Title { get; set; }
        //public string Title;
        public string Genre { get; set; }
        //public string Genre;
        public double ReviewScore { get; set; }
        //public double ReviewScore;

        public List<string> Actors;

        public Movie(string title, string genre, double reveiwScore)
        {
            Title = title;
            Genre = genre;
            ReviewScore = reveiwScore;
        }
        public void DisplayInformation()
        {
            MessageBox.Show($"Title:{Title} \n Genre:{Genre} \n ReveiwScore:{ReviewScore}");
        }
    }
}
