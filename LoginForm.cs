﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project_1
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            this.password.AutoSize = false;
            this.password.Size = new Size(this.password.Size.Width,49);
        }


        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void exit_MouseEnter(object sender, EventArgs e)
        {
            exit.ForeColor = Color.White;
        }

        private void exit_MouseLeave(object sender, EventArgs e)
        {
            exit.ForeColor = Color.Black;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {

            if (login.Text == "")
            {
                MessageBox.Show("Введите логин");
                return;
            }
            if (password.Text == "")
            {
                MessageBox.Show("Введите пароль");
                return;
            }



            String loginUser = login.Text;
            String passUser = password.Text;

            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @userL AND `password`= @userP", db.getConnection());
            command.Parameters.Add("@userL", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@userP", MySqlDbType.VarChar).Value = passUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                this.Hide();
                string lg = login.Text;
                Menu menu = new Menu(lg);
                menu.Show();

            }
            else
                MessageBox.Show("Учетная запись не найдена ");


        }
        private void login_Enter(object sender, EventArgs e)
        {
            if (login.Text == "Введите логин")
            {
                login.Text = "";
                login.ForeColor = Color.Black;
            }
        }

        private void login_Leave(object sender, EventArgs e)
        {
            if (login.Text == "")
            {
                login.Text = "Введите логин";
                login.ForeColor = Color.Gray;
            }
        }
        private void reg_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration registration = new Registration();

            registration.Show();

        }

        private void reg_MouseEnter(object sender, EventArgs e)
        {
            reg.ForeColor = Color.DarkSlateBlue;
        }
    }
}
