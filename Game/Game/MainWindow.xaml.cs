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

namespace Game
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        GameController vGame = new GameController();
        public MainWindow()
        {
            InitializeComponent();
        }
        string Setclass = "";

        private void ClassWarrior_Click(object sender, RoutedEventArgs e)
        {
            ClassWarrior.IsEnabled = false;
            ClassThief.IsEnabled = true;
            ClassMage.IsEnabled = true;
            StartGame.IsEnabled = true;
            Setclass = "Warrior";
        }

        private void ClassThief_Click(object sender, RoutedEventArgs e)
        {
            ClassWarrior.IsEnabled = true;
            ClassThief.IsEnabled = false;
            ClassMage.IsEnabled = true;
            StartGame.IsEnabled = true;
            Setclass = "Thief";
        }

        private void ClassMage_Click(object sender, RoutedEventArgs e)
        {
            ClassWarrior.IsEnabled = true;
            ClassThief.IsEnabled = true;
            ClassMage.IsEnabled = false;
            StartGame.IsEnabled = true;
            Setclass = "Mage";
        }

        private void StartGame_Click(object sender, RoutedEventArgs e)
        {
            ClassWarrior.Visibility = Visibility.Collapsed;
            ClassThief.Visibility = Visibility.Collapsed;
            ClassMage.Visibility = Visibility.Collapsed;
            StartGame.Visibility = Visibility.Collapsed;
            ChoiceClass.Visibility = Visibility.Collapsed;
            Main.Content = new Battle(vGame);
            vGame.ChooseClass(Setclass);
        }
    }
}
