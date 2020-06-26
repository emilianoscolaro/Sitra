
using AvicolaWindows.Data;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AvicolaWindows.EditForms
{
    public partial class EditarUsuarios : Form
    {
        string _usr, _contra, _name, _apell,_id;

        public EditarUsuarios(string usr, string contra, string name, string apello,string id)
        {
            InitializeComponent();
            _usr = usr;
            _contra = contra;
            _name = name;
            _apell = apello;
            _id = id;
            this.FormBorderStyle = FormBorderStyle.None;
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            UsrEntry.Enabled = true;
            UsrEntry.Focus();
            button2.Visible = true;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            NombreEntry.Enabled = true;
            NombreEntry.Focus();
            button2.Visible = true;
            pictureBox2.Visible = false;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            ApellidoEntry.Enabled = true;
            ApellidoEntry.Focus();
            button2.Visible = true;
            pictureBox4.Visible = false;
        }



        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string cmd = string.Format("EXEC ActualizarUsuarios '{0}','{1}','{2}','{3}','{4}'", _id,
                    UsrEntry.Text.Trim(), PassLabel.Text.Trim(), NombreEntry.Text.Trim(), ApellidoEntry.Text.Trim());
                Utilidades.Ejecutar(cmd);
                MessageBox.Show("Usuario Actualizado");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(NuevaPassEntry.Text == RepPassEntry.Text && OldPassEntry.Text == PassLabel.Text)
            {
                PassLabel.Text = NuevaPassEntry.Text;
                try
                {
                    string cmd = string.Format("EXEC ActualizarUsuarios '{0}','{1}','{2}','{3}','{4}'",_id,
                        UsrEntry.Text.Trim(), PassLabel.Text.Trim(), NombreEntry.Text.Trim(), ApellidoEntry.Text.Trim());
                    Utilidades.Ejecutar(cmd);
                    MessageBox.Show("ok");
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
            else
            {
                if (NuevaPassEntry.Text != RepPassEntry.Text)
                    MessageBox.Show("Debe repetir correntamente la contraseña");
                if(OldPassEntry.Text != PassLabel.Text)
                    MessageBox.Show("Anterior contraseña incorrecta");
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (PassPanel.Visible == false)
            {
                PassPanel.Visible = true;
            }
            else { PassPanel.Visible = false; }
        }


        private void EditarUsuarios_Load(object sender, EventArgs e)
        {
            UsrEntry.Text = _usr;
            NombreEntry.Text = _name;
            ApellidoEntry.Text = _apell;
            PassLabel.Text = _contra;
        }

        



    }
}
