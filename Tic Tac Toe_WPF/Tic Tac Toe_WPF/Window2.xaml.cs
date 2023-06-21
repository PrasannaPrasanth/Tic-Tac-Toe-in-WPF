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

namespace Tic_Tac_Toe_WPF
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public static int id1 = 0;
        public static string name1 = "";
        public static int id2= 0;
        public static string name2 = "";


        public Window2()
        {
                        InitializeComponent();
            // main.NavigationService.Navigate(new loginorsignin());

                        if (Window1.count == 1)
                        {
                            idlabel.Content = Window1.id;
                            namelabel.Content = Window1.pname;

                        }
                        else
                        {
                            idlabel.Content = Window1.id;
                            namelabel.Content = Window1.pname;
                            idlabel2.Content = Window1.id2;
                            namelabel2.Content = Window1.pname2;
                            id1 = Window1.id;
                            name1 = Window1.pname;
                            id2 = Window1.id2;
                            name2 = Window1.pname2;
                        }
            
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //main.Visibility = Visibility.Visible;
            Player2profile.Visibility = Visibility.Visible;
            Window1 w = new Window1();
            w.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MainWindow m = new MainWindow();
            m.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
           // main.NavigationService.Navigate(new player2login());
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
           
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            MainWindow a = new MainWindow(); 
            a.Show();
    
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            Leaderboard l = new Leaderboard(); l.Show();
        }
    }
}
