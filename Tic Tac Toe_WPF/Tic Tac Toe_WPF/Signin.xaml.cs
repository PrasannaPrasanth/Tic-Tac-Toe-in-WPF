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
    /// Interaction logic for Signin.xaml
    /// </summary>
    public partial class Signin : Window
    {
        public Signin()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string a = Nametext.Text;
            int b =Convert.ToInt32(Passwordtext.Text);
    SqlConnection sqlconn = new SqlConnection();
            sqlconn.ConnectionString ="SERVER=.\\SQLEXPRESS; Database=TTT; Integrated Security=true";
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
                sqlcomm.CommandText = "insert into Players values('" + Nametext.Text + "','" + Passwordtext.Text + "')";
                sqlcomm.ExecuteNonQuery();
           }
        }

        
    }
}
