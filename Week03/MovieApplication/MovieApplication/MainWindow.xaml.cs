using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MovieApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void textBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void submitMovieButton_Click(object sender, RoutedEventArgs e)
        {
            Movie submittedMovie = new Movie(TitleTextbox.Text, GenreTextBox.Text, Double.Parse(ReviewScoreTextBox.Text));

            //submittedMovie.Title = TitleTextbBox.Text;
            //submittedMovie.Genre = GenreTextBox.Text;
            // submittedMovie.ReviewScore = Convert.ToDouble(ReviewScoreTextBox.Text);
            //submittedMovie.ReviewScore = Double.Parse(ReviewScoreTextBox.Text);

            submittedMovie.DisplayInformation();
        }
    }
}
