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

namespace InterfacesIntro
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public ObservableCollection<IWalker> Animals;

        public MainWindow()
        {
            InitializeComponent();
            Animals = new ObservableCollection<IWalker>();

            // make siome aminals
            Frog frog = new Frog(4,"Bart",true, 5.2, 4);
            Dog dog = new Dog("Labradoodle", 35, "Pax", 10.1, 4);
            Duck duck = new Duck(4, "Moo", 7.7, 2);
            StarwarsRobot C3P0 = new StarwarsRobot(9, 8.8, 2);

            Animals.Add(frog);
            Animals.Add(dog);
            Animals.Add(duck);
            Animals.Add(C3PO);

            lvAnimals.ItemsSource = Animals;
        }

        private void SayName_Button_Click(object sender, RoutedEventArgs e)
        {
            foreach (Animal a in Animals)
            {
                a.SayName();
            }
        }

		private void LvAnimals_MouseDoubleClick(object sender, MouseButtonEventArgs e)
		{
            IWalker selectedAnimal = lvAnimals.SelectedItem as IWalker;
			if (selectedAnimal != null)
			{
				selectedAnimal.walk();
			}
		}
	}
}
