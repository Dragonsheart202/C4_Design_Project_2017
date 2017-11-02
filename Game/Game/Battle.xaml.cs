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
    /// Interaction logic for Battle.xaml
    /// </summary>
    public partial class Battle : Page
    {
        GameController vGame;
        public Battle(GameController pGame)
        {
            InitializeComponent();
            vGame = pGame;
        }

        private void On_Load(object sender, RoutedEventArgs e)
        {
            ProgressPlayer.Maximum = vGame.player.maxHealthPoints;
            ProgressPlayer.Value = vGame.player.currentHealthPoints;
            ProgressNPC.Maximum = vGame.enemy.maxHealthPoints;
            ProgressNPC.Value = vGame.enemy.currentHealthPoints;
        }

        private void NormalAttack_Click(object sender, RoutedEventArgs e)
        {
            string attackType = "normal";
            vGame.AttackNPC(attackType);

            ProgressPlayer.Value = vGame.player.currentHealthPoints;
            ProgressNPC.Value = vGame.enemy.currentHealthPoints;

        }

        private void SpecialAttack_Click(object sender, RoutedEventArgs e)
        {
            string attackType = "special";
            vGame.AttackNPC(attackType);

            ProgressPlayer.Value = vGame.player.currentHealthPoints;
            ProgressNPC.Value = vGame.enemy.currentHealthPoints;
        }

    }
}
