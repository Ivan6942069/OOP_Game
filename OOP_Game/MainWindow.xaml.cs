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

namespace OOP_Game
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        charakter charakter1;
        charakter charakter2;
        public MainWindow()
        {
            InitializeComponent();
            charakter1 = new charakter("Pert");
            charakter2 = new charakter("Pavel");
            Txt1.Text = charakter1.ToString();
            Txt2.Text = charakter2.ToString();
        }

        private void Attack_Click(object sender, RoutedEventArgs e)
        {
            charakter2.GetHit(charakter1.Damage);
            Txt2.Text = charakter2.ToString();
        }

        private void Heal_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
