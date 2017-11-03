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
using System.Windows.Shapes;
using Mega_Card_Game_2000;
namespace Mega_Card_Game_2000
{
    /// <summary>
    /// Interaction logic for ChooseClass.xaml
    /// </summary>
    public partial class ChooseClass : Window
    {
        public ChooseClass()
        {
            InitializeComponent();
        }

        private void Warrior_Click(object sender, RoutedEventArgs e)
        {
            GameController game = new GameController();
            BattleScreen battle = new BattleScreen();
            App.Current.MainWindow = battle;

            game.ChooseClass(w);

            this.Close();
            battle.Show();
        }

        private void Thief_Click(object sender, RoutedEventArgs e)
        {
            GameController game = new GameController();
            BattleScreen battle = new BattleScreen();
            App.Current.MainWindow = battle;

            game.ChooseClass(t);

            this.Close();
            battle.Show();
        }

        private void Mage_Click(object sender, RoutedEventArgs e)
        {
            GameController game = new GameController();
            BattleScreen battle = new BattleScreen();
            App.Current.MainWindow = battle;

            game.ChooseClass(m);

            this.Close();
            battle.Show();
        }
    }
}
