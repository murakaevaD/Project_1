using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_1
{
    public partial class Profile : Form
    {
        public Profile(string str)
        {
            InitializeComponent();

            label4.Text = str;

            MySql.Data.MySqlClient.MySqlConnection conn;
            string myConnectionString;

            myConnectionString = "server=localhost;uid=root;" + "pwd=null;database=testdb";

            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection();
                conn.ConnectionString = myConnectionString;
                conn.Open();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        //private string name;
        //private string birthdate;
        //private string position;



        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            //Menu menu = new Menu();
            //menu.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MyGroups groups = new MyGroups();
            groups.Show();
        }

        Point lastPoint;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }


        /////////////////////////////////////////////////////////////////////////////////
        private void Profile_load(object sender, EventArgs e)
        {

            //MySqlCommand command = new MySqlCommand(); ;
            //string connectionString, commandString;
            //connectionString = "Data source=localhost;UserId=root;Password=1234;database=MyDatabaseName;";
            //MySqlConnection connection = new MySqlConnection(connectionString);
            //string sql = "SELECT name FROM men WHERE id = 2";

        }

        private void NameSurename_Click(object sender, EventArgs e)
        {

        }




        /////////////////////////////////////////////////////////////////////////////////////


        //private void popupForm_Load(object sender, EventArgs e)
        //{
        //    label1.Text = name;
        //    label2.Text = birthdate;
        //    label3.Text = position;
        //}
        //public Profile(string name, string birthdate, string position)
        //{
        //    this.name = name;
        //    this.birthdate = birthdate;
        //    this.position = position;
        //    InitializeComponent();
        //}



        //MySqlConnection connection = new MySqlConnection("server = localhost; port = 3306; username = root; password = root; database = project1 ");
        //connection.Open();

        ////string sqlquery = "name FROM users WHERE login = " + textBox1;

        //MySqlCommand cmd = new MySqlCommand("Select name from users where login=@login", connection);
        //cmd.Parameters.AddWithValue("@login", int.Parse(textBox1.Text));
        //MySqlDataReader sdr = cmd.ExecuteReader();

        //while (sdr.Read())
        //{
        //    textBox1.Text = sdr["name"].ToString();
        //}
        //connection.Close();



    //    MySqlConnection connection = new MySqlConnection("server = localhost; port = 3306; username = root; password = root; database = project1 ");
    //    connection.Open();
    //    if (textBox1.Text = "")
    //    {
    //        MySqlCommand cmd = new MySqlCommand("Select name from users where login=@login", connection);
    //    cmd.Parameters.AddWithValue("@login", int.Parse(textBox1.Text));
    //        MySqlDataReader da = cmd.ExecuteReader();
    //        while (da.Read())
    //        {
    //            textBox1 = da.GetValue(0).ToString();
    //}
    //connection.Close();
        //}
    }
}
