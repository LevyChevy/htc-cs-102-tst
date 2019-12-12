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
        string Username;
        string Password;
        string UNInput;
        string PWInput;

        public MainWindow()
        {
            InitializeComponent();
        }
       
        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Regester_Click(object sender, RoutedEventArgs e)
        {
            Username = usernamebox.Text;
            Password = passwordbox.Text;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            UNInput = usernamebox.Text;
            PWInput = passwordbox.Text;
            if(UNInput == Username)
            {
                if(PWInput == Password)
                {
                    Response.Text = "Password Correct";
                }
                else
                {
                    Response.Text = "Password Incorrect";
                }
            }else
            {
                Response.Text = "Password Incorrect";
            }
        }
    }
}
