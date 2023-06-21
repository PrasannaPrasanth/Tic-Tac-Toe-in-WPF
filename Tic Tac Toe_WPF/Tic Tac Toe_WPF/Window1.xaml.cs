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
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Data;

namespace Tic_Tac_Toe_WPF
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public static int id = 0;
        public static string pname = "";
        public static int id2 = 0;
        public static string pname2 = "";
        public static int count = 1;

        public Window1()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
           
            SqlConnection sc = new SqlConnection();
            sc.ConnectionString = "SERVER=.\\SQLEXPRESS; Database=TTT; Integrated Security=true";
            try
            {
                sc.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Connection Failed");
            }
            if (sc.State == ConnectionState.Open)
            {

                string name = Nametext.Text;
                int password = Convert.ToInt32(Passwordtext.Text);
                SqlCommand sqlcom = new SqlCommand();
                sqlcom.Connection = sc;
                sqlcom.CommandText = "select * from Players";
                SqlDataReader dr;
                dr = sqlcom.ExecuteReader();
                //string a = "";
                int b = 0;
                //int c = 0;
                if (count == 1)
                {
                    while (dr.Read())
                    {
                       string temp_pname = dr["pname"].ToString();
                       int temp_b = Convert.ToInt32(dr["ppassword"]);
                       int temp_id = Convert.ToInt32(dr["pid"]);
                        if (temp_pname == name)
                        {
                            if (temp_b == password)
                            {
                                pname = temp_pname;
                                b = temp_b;
                                id = temp_id;
                                Window2 w = new Window2();
                                w.Show();
                                // name =a;
                                count++;
                            }
                        }
                    }
                    dr.Close();
                }
                else if (count == 2)
                {
                    while (dr.Read())
                    {
                        pname2 = dr["pname"].ToString();
                        b = Convert.ToInt32(dr["ppassword"]);
                        id2 = Convert.ToInt32(dr["pid"]);
                        if (pname2 == name)
                        {
                            if (b == password)
                            {
                                Window2 w = new Window2();
                                w.Show();
                                w.addplayerbuttion.Visibility = Visibility.Hidden;

                            }
                        }
                    }
                    dr.Close();
                }
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Signin s = new Signin(); s.Show();
        }

       
    }
}

