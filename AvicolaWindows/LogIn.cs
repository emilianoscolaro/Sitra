using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AvicolaWindows.Models;
using AvicolaWindows.DataStorge;

namespace AvicolaWindows
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
             validUser =usuarios.UsuariosExistentes(validUser);
        }

        Users validUser;
        UsuariosData usuarios = new UsuariosData();
        

        private void button2_Click(object sender, EventArgs e)
        {
            if(UsuarioEntry.Text == validUser.Name && PassEntry.Text == validUser.Pasword)
            {
                MessageBox.Show("Log in exitoso");
            }
            else { MessageBox.Show("Log in incorrecto"); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CrearUsuario crearUsuario = new CrearUsuario();
            crearUsuario.Show();
        }
    }
}
