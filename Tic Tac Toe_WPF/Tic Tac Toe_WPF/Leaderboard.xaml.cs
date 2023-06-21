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
    /// Interaction logic for Leaderboard.xaml
    /// </summary>
    public partial class Leaderboard : Window
    {
        List<Players> _player = new List<Players>();

        public List<Players> Player
        {
            get { return _player; }
            set { _player = value; }
        }
        public Leaderboard()
        {
            InitializeComponent();
            InitPeople();
            PlayerList.DataContext = this;

        }

        public void InitPeople()
        {
            SqlConnection sc = new SqlConnection();
            sc.ConnectionString = "SERVER=LENOVO\\SQLEXPRESS; Database=TTT; Integrated Security=true";
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
                SqlCommand sqlcom = new SqlCommand();
                sqlcom.Connection = sc;
                sqlcom.CommandText = "select * from leaderboard order by pscore DESC";
                SqlDataReader dr;
                int count = 0;
                dr = sqlcom.ExecuteReader();
                while (dr.Read())
                {
                    string a = dr["pname"].ToString();
                    int b = Convert.ToInt32(dr["pscore"].ToString());
                    Players p = new Players(a, b);
                    Player.Add(p);
                    if (count == 0)
                    {
                        place2.Text = dr["pname"].ToString(); count++; continue;
                    }
                    if (count == 1)
                    {
                        place1.Text = dr["pname"].ToString(); count++; continue;
                    }
                    if (count == 2)
                    {
                        place3.Text = dr["pname"].ToString(); count++; continue;
                    }
                }
                    dr.Close();
                }
        }

    }
}
    

