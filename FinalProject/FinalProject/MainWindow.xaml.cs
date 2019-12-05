using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace FinalProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Login> UsersInfo;

        public MainWindow()
        {
            InitializeComponent();
        }
        //button clicky boi
        private void buttonlogin_Click(object sender, EventArgs e)
        {
            
        }
        //username box 
        private void UsernameBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        public void StoreData()
        {

        }

    }
}
