using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Build.Tasks;
using AvicolaWindows.Data;



namespace AvicolaWindows
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }
        string id,nivel;
        string adminUsr = "admin";
        string adminPas = "Lezica44748c@avicol@";

        private void Xbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MinBtn_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Minimized;
            }
        }

        bool drag = false;
        Point startPoint = new Point(0, 0);

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - startPoint.X, p.Y - startPoint.Y);
            }
        }

        private void panel3_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void UserEntry_Click(object sender, EventArgs e)
        {
            UserEntry.SelectAll();
        }

        private void PassEntry_Click(object sender, EventArgs e)
        {
            PassEntry.SelectAll();
        }

        private void UserEntry_KeyPress(object sender, KeyPressEventArgs e)
        {
            UserEntry.ForeColor = Color.White;
          
        }

        private void PassEntry_KeyPress(object sender, KeyPressEventArgs e)
        {
            PassEntry.ForeColor = Color.White;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (UserEntry.Text == adminUsr && PassEntry.Text == adminPas)
            {
                MainPage mainpage = new MainPage("ADMIN","0","4");
                mainpage.Show();
                this.Hide();
            }
            else
            {
                try
                {
                    string CMD = string.Format("Select * FROM Usuarios WHERE Usuario ='{0}' AND Contraseña ='{1}'", UserEntry.Text.Trim(), PassEntry.Text.Trim());
                    DataSet ds = Utilidades.Ejecutar(CMD);

                    string cuenta = ds.Tables[0].Rows[0]["Usuario"].ToString().Trim();
                    string contraseña = ds.Tables[0].Rows[0]["Contraseña"].ToString().Trim();
                    id = ds.Tables[0].Rows[0]["ID"].ToString().Trim();
                    nivel = ds.Tables[0].Rows[0]["Nivel"].ToString().Trim();

                    if (cuenta == UserEntry.Text.Trim() && contraseña == PassEntry.Text.Trim())
                    {
                        MainPage mainpage = new MainPage(UserEntry.Text,id,nivel);
                        mainpage.Show();
                        this.Hide();
                    }


                }
                catch (Exception)
                {
                    MessageBox.Show("Usuario o contraseña incorrectos");
                }
            }



        }






    }
}
