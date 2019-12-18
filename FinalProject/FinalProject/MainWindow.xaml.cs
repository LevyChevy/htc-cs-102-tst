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
        private const string R1 = "Saved";
        private const string R2 = "Password Incorrect";
        private const string R3 = "Login Sucessful";
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
            OutputText.Text = R1;
            passwordbox.Text = "";
            usernamebox.Text = "";
        }

        private void OutputText_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            UNInput = usernamebox.Text;
            PWInput = passwordbox.Text;
            if((UNInput == Username) && (PWInput == Password))
            {

                OutputText.Text = R3;
            }
            else
            {
                OutputText.Text = R2;
                passwordbox.Text = "";
                usernamebox.Text = "";
            }
         }
    }
}
