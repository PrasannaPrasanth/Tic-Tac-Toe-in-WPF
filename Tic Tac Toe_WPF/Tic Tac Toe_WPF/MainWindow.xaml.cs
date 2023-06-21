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
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Data;

namespace Tic_Tac_Toe_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       // static List<Players> player_list = new List<Players>();
        int click = 0;
        string clicked = "";
        
        public MainWindow()
        {
            InitializeComponent();
            //Window2 w = new Window2();
            idlabel1.Content = Window2.id1;
            namelabel1.Content = Window2.name1;
            idlabel2.Content = Window2.id2;
            namelabel2.Content = Window2.name2;
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            click++;

            if (click % 2 != 0)
            {
                B1.Content = "X";
                clicked = "true";
                B1.IsEnabled = false;
                winstate();
                leaderboard();
              //  textromove();
                
               
            }
            else
            {
                B1.Content = "O";
                clicked = "true";
                B1.IsEnabled = false;
                winstate();
                leaderboard();
            //    textromove();
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            click++;
            if (click % 2 != 0)
            {
                B2.Content = "X";
                B2.IsEnabled = false;
                winstate();
                leaderboard();
                //textromove();
            }
            else
            {
                B2.Content = "O";
                B2.IsEnabled = false;
                winstate();
                leaderboard();
                //textromove();
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            click++;
            if (click % 2 != 0)
            {
                B3.Content = "X";
                B3.IsEnabled = false;
                winstate();
                leaderboard();
                //textromove();
            }
            else
            {
                B3.Content = "O";
                B3.IsEnabled = false;
                winstate();
                leaderboard();
                //textromove();
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            click++;
            if (click % 2 != 0)
            {
                B4.Content = "X";
                B4.IsEnabled = false;
                winstate();
                leaderboard();
            //    textromove();
            }
            else
            {
                B4.Content = "O";
                B4.IsEnabled = false;
                winstate();
                leaderboard();
               // textromove();
            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            click++;
            if (click % 2 != 0)
            {
                B5.Content = "X";
                B5.IsEnabled = false;
                winstate();
                leaderboard();
            //    textromove();
            }
            else
            {
                B5.Content = "O";
                B5.IsEnabled = false;
                winstate();
                leaderboard();
              //  textromove();
            }
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            click++;
            if (click % 2 != 0)
            {
                B6.Content = "X";
                B6.IsEnabled = false;
                winstate();
                leaderboard();
                //textromove();
            }
            else
            {
                B6.Content = "O";
                B6.IsEnabled = false;
                winstate();
                leaderboard();
                //textromove();
            }
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            click++;
            if (click % 2 != 0)
            {
                B7.Content = "X";
                B7.IsEnabled = false;
                winstate();
                leaderboard();
                //textromove();
            }
            else
            {
                B7.Content = "O";
                B7.IsEnabled = false;
                winstate();
                leaderboard();
                //textromove();
            }
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            click++;
            if (click % 2 != 0)
            {
                B8.Content = "X";
                B8.IsEnabled = false;
                winstate();
                leaderboard();
                //textromove();
            }
            else
            {
                B8.Content = "O";
                B8.IsEnabled = false;
                winstate();
                leaderboard();
                //textromove();
            }
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            click++;
            if (click % 2 != 0)
            {
                B9.Content = "X";
                B9.IsEnabled = false;
                winstate();
                leaderboard();
               // textromove();
            }
            else
            {
                B9.Content = "O";
                B9.IsEnabled = false;
                winstate();
                leaderboard();
             //   textromove();
            }
        }
        private  void winstate()
        {
            if (B1.Content==("X")&& B2.Content=="X" && B3.Content=="X")
            {
                B1.IsEnabled = true; B2.IsEnabled = true; B3.IsEnabled = true;
                B1.Background = Brushes.Green; B2.Background = Brushes.Green; B3.Background = Brushes.Green;
                MessageBox.Show(B1.Content + "  win");
                win.Text = "X";
                BigButton.IsEnabled = false;
            }
            if (B1.Content == ("O") && B2.Content == "O" && B3.Content == "O")
            {
                B1.IsEnabled = true; B2.IsEnabled = true; B3.IsEnabled = true;
                B1.Background = Brushes.Green; B2.Background = Brushes.Green; B3.Background = Brushes.Green;
                MessageBox.Show(B1.Content + "  win");
                win.Text = "O";
                BigButton.IsEnabled = false;
            }
            if (B4.Content == ("X") && B5.Content == "X" && B6.Content == "X")
            {
                B4.IsEnabled = true; B5.IsEnabled = true; B6.IsEnabled = true;
                B4.Background = Brushes.Green; B5.Background = Brushes.Green; B6.Background = Brushes.Green;
                MessageBox.Show(B4.Content + "  win");
                win.Text = "X";
                BigButton.IsEnabled = false;
            }
            if (B4.Content == ("O") && B5.Content == "O" && B6.Content == "O")
            {
                B4.IsEnabled = true; B5.IsEnabled = true; B6.IsEnabled = true;
                B4.Background = Brushes.Green; B5.Background = Brushes.Green; B6.Background = Brushes.Green;
                MessageBox.Show(B4.Content + "  win");
                win.Text = "O";
                BigButton.IsEnabled = false;
            }
            if (B7.Content == ("X") && B8.Content == "X" && B9.Content == "X")
            {
                B7.IsEnabled = true; B8.IsEnabled = true; B9.IsEnabled = true;
                B7.Background = Brushes.Green; B8.Background = Brushes.Green; B9.Background = Brushes.Green;
                MessageBox.Show(B7.Content + "  win");
                win.Text = "X";
                BigButton.IsEnabled = false;
            }
            if (B7.Content == ("O") && B8.Content == "O" && B9.Content == "O")
            {
                B7.IsEnabled = true; B8.IsEnabled = true; B9.IsEnabled = true;
                B7.Background = Brushes.Green; B8.Background = Brushes.Green; B9.Background = Brushes.Green;
                MessageBox.Show(B7.Content + "  win");
                win.Text = "O";
                BigButton.IsEnabled = false;
            }
            if (B1.Content == ("X") && B4.Content == "X" && B7.Content == "X")
            {
                B1.IsEnabled = true; B4.IsEnabled = true; B7.IsEnabled = true;
                B1.Background = Brushes.Green; B4.Background = Brushes.Green; B7.Background = Brushes.Green;
                MessageBox.Show(B1.Content + "  win");
                win.Text = "X";
                BigButton.IsEnabled = false;
            }
            if (B1.Content == ("O") && B4.Content == "O" && B7.Content == "O")
            {
                B1.IsEnabled = true; B4.IsEnabled = true; B7.IsEnabled = true;
                B1.Background = Brushes.Green; B4.Background = Brushes.Green; B7.Background = Brushes.Green;
                MessageBox.Show(B1.Content + "  win");
                win.Text = "O";
                BigButton.IsEnabled = false;
            }
            if (B2.Content == ("X") && B5.Content == "X" && B8.Content == "X")
            {
                B2.IsEnabled = true; B5.IsEnabled = true; B8.IsEnabled = true;
                B2.Background = Brushes.Green; B5.Background = Brushes.Green; B8.Background = Brushes.Green;
                MessageBox.Show(B2.Content + "  win");
                win.Text = "X";
                BigButton.IsEnabled = false;
            }
            if (B2.Content == ("O") && B5.Content == "O" && B8.Content == "O")
            {
                B2.IsEnabled = true; B5.IsEnabled = true; B8.IsEnabled = true;
                B2.Background = Brushes.Green; B5.Background = Brushes.Green; B8.Background = Brushes.Green;
                MessageBox.Show(B2.Content + "  win");
                win.Text = "O";
                BigButton.IsEnabled = false;
            }
            if (B3.Content == ("X") && B6.Content == "X" && B9.Content == "X")
            {
                B3.IsEnabled = true; B6.IsEnabled = true; B9.IsEnabled = true;
                B3.Background = Brushes.Green; B6.Background = Brushes.Green; B9.Background = Brushes.Green;
                MessageBox.Show(B3.Content + "  win");
                win.Text = "X";
                BigButton.IsEnabled = false;
            }
            if (B3.Content == ("O") && B6.Content == "O" && B9.Content == "O")
            {
                B3.IsEnabled = true; B6.IsEnabled = true; B9.IsEnabled = true;
                B3.Background = Brushes.Green; B6.Background = Brushes.Green; B9.Background = Brushes.Green;
                MessageBox.Show(B3.Content + "  win");
                win.Text = "O";
                BigButton.IsEnabled = false;
            }
            if (B1.Content == ("X") && B5.Content == "X" && B9.Content == "X")
            {
                B1.IsEnabled = true; B5.IsEnabled = true; B9.IsEnabled = true;
                B1.Background = Brushes.Green; B5.Background = Brushes.Green; B9.Background = Brushes.Green;
                MessageBox.Show(B1.Content + "  win");
                win.Text = "X";
                BigButton.IsEnabled = false;
            }
            if (B1.Content == ("O") && B5.Content == "O" && B9.Content == "O")
            {
                B1.IsEnabled = true; B5.IsEnabled = true; B9.IsEnabled = true;
                B1.Background = Brushes.Green; B5.Background = Brushes.Green; B9.Background = Brushes.Green;
                MessageBox.Show(B1.Content + "  win");
                win.Text = "O";
                BigButton.IsEnabled = false;
            }
            if (B3.Content == ("X") && B5.Content == "X" && B7.Content == "X")
            {
                B3.IsEnabled = true; B5.IsEnabled = true; B7.IsEnabled = true;
                B3.Background = Brushes.Green; B5.Background = Brushes.Green; B7.Background = Brushes.Green;
                MessageBox.Show(B3.Content + "  win");
                win.Text = "X";
                BigButton.IsEnabled = false;
            }
            if (B3.Content == ("O") && B5.Content == "O" && B7.Content == "O")
            {
                B3.IsEnabled = true; B5.IsEnabled = true; B7.IsEnabled = true;
                B3.Background = Brushes.Green; B5.Background = Brushes.Green; B7.Background = Brushes.Green;
                MessageBox.Show(B3.Content + "  win");
                win.Text = "O";
                BigButton.IsEnabled = false;
            }
            else
            {
                if (click == 9)
                {
                    MessageBox.Show("Game is Draw");
                    win.Text = "Draw";
                }
            }

        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            Random r = new Random();
            int i = r.Next(1, 3);
            if (i == 1)
            {
                tossplayer1.Content = "X";
                tossplayer2.Content = "O";
              //  text();
            }
            else
            {
                tossplayer2.Content = "X";
                tossplayer1.Content = "O";
                //text();
            }
        }
        //private void text()
        //{
        //    if (tossplayer1.Content == "X")
        //    {
        //        roundtext.Text = "First Move For Player-1";
        //    }
        //    else
        //    {
        //        roundtext.Text = "First Move For Player-2";
        //    }
        //}
        //private void textromove()
        //{
        //    if (roundtext.Text == "First Move For Player-1")
        //    {
        //        roundtext.Text = "This Move for Player-2";
        //    }
        //    else if(roundtext.Text == "First Move For Player-2")
        //    {
        //         roundtext.Text = "This Move for Player-1";
        //    }
        //    else if (roundtext.Text == "This Move for Player-2")
        //    {
        //        roundtext.Text = "This Move for Player-1";
        //    }
        //    else if (roundtext.Text == "This Move for Player-1")
        //    {
        //        roundtext.Text = "This Move for Player-2";
        //    }
        //}

        private void leaderboard()
        {
            string i = win.Text;
            if (i == tossplayer1.Content)
            {
                SqlConnection sqlconn = new SqlConnection();
                sqlconn.ConnectionString = "SERVER=LENOVO\\SQLEXPRESS; Database=TTT; Integrated Security=true";
                try
                {
                    sqlconn.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Connection Failed");

                }
                if (sqlconn.State == ConnectionState.Open)
                {
                    SqlCommand sqlcomm = new SqlCommand();
                    sqlcomm.Connection = sqlconn;

                    sqlcomm.CommandText = "exec stp_leaderboard_insert " + idlabel1.Content + " , " + namelabel1.Content  +", 1 ";
                  //  sqlcomm.CommandText ="exec stp_leaderboard_insert idlabel2.Content , namelabel2.Content ,1 ";
                    //MessageBox.Show(sqlcomm.CommandText);
                    sqlcomm.ExecuteNonQuery();


                }
            }
            else if (i == tossplayer2.Content)
            {
                SqlConnection sqlconn = new SqlConnection();
                sqlconn.ConnectionString = "SERVER=LENOVO\\SQLEXPRESS; Database=TTT; Integrated Security=true";
                try
                {
                    sqlconn.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Connection Failed");

                }
                if (sqlconn.State == ConnectionState.Open)
                {
                    SqlCommand sqlcomm = new SqlCommand();
                    sqlcomm.Connection = sqlconn;
                    sqlcomm.CommandText = "exec stp_leaderboard_insert " + idlabel2.Content + " , " + namelabel2.Content + ", 1 ";
                   // insert into leaderboard values('" + idlabel2.Content + "','" + namelabel2.Content + "',1)
                    //MessageBox.Show(sqlcomm.CommandText);
                    sqlcomm.ExecuteNonQuery();


                }
            }
        }

       // private void leaderboard()
        //{
        //    string i = win.Text;
        //    if (i == tossplayer1.Content)
        //    {
        //        int a =Convert.ToInt32(idlabel1.Content);
        //        string b = Convert.ToString(namelabel1.Content);
        //        Players p = new Players(a, b, 1);
        //        player_list.Add(p);
        //    }
        //    else if (i == tossplayer2.Content)
        //    {
        //        int a = Convert.ToInt32(idlabel2.Content);
        //        string b = Convert.ToString(namelabel2.Content);
        //        Players p = new Players(a, b, 1);
        //        player_list.Add(p);
        //    }
        //}

        //private void showlist()
        //{
        //    foreach (var a in player_list)
        //    {
        //        MessageBox.Show(a.Id+" "+a.Name+" "+a.Score);
        //    }
        //}


//        private void po()
//        {
//            Players p1 = new Players(1,"Kumar",1);
//            Players p2 = new Players(1, "Arun", 1);
//            Players p3 = new Players(1, "Anand", 1);
//            player_list.Add(p1);
//            player_list.Add(p2);
//            player_list.Add(p3);
//}

        }
    }

