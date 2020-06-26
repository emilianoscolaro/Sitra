using AvicolaWindows.Data;
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
    public partial class EditarClientes : Form
    {
        public EditarClientes(string tipo, string id, string alias,string nombre,string apell,string loca,string direc,string email,string tel,string cuit)
        {
            InitializeComponent();

            _id = id;
            _alias = alias;
            _nombre = nombre;
            _apell = apell;
            _loca = loca;
            _direc = direc;
            _email = email;
            _tel = tel;
            _cuit = cuit;
            _tipo = tipo;
            TitleLabel.Text = _tipo;
        }

        string _id;
        string _alias;
        string _nombre;
        string _apell;
        string _loca;
        string _direc;
        string _email;
        string _tel;
        string _cuit;
        string _tipo;


        private void AliasEdit_Click(object sender, EventArgs e)
        {
            AliasEntry.Enabled = true;
            AliasEntry.Focus();
            button2.Visible = true;

            
        }

        private void NameEdit_Click(object sender, EventArgs e)
        {
            NombreEntry.Enabled = true;
            NombreEntry.Focus();
            button2.Visible = true;
            NameEdit.Visible = false;
        }

        private void SecondEdit_Click(object sender, EventArgs e)
        {
            ApellidoEntry.Enabled = true;
            ApellidoEntry.Focus();
            button2.Visible = true;
            SecondEdit.Visible = false;
        }

        private void LocalidadEdit_Click(object sender, EventArgs e)
        {
            LocalEntry.Enabled = true;
            LocalEntry.Focus();
            button2.Visible = true;
            LocalidadEdit.Visible = false;
        }

        private void DirEdit_Click(object sender, EventArgs e)
        {
            DirEntry.Enabled = true;
            DirEntry.Focus();
            button2.Visible = true;
            DirEdit.Visible = false;
        }

        private void EmailEdit_Click(object sender, EventArgs e)
        {
            EmailEntry.Enabled = true;
            EmailEntry.Focus();
            button2.Visible = true;
            EmailEdit.Visible = false;
        }

        private void TelEdit_Click(object sender, EventArgs e)
        {
            TelEntry.Enabled = true;
            TelEntry.Focus();
            button2.Visible = true;
            TelEdit.Visible = false;
        }

        private void CuitEdit_Click(object sender, EventArgs e)
        {
            CuitEntry.Enabled = true;
            CuitEntry.Focus();
            button2.Visible = true;
            CuitEdit.Visible = false;
        }

        private void EditarClientes_Load(object sender, EventArgs e)
        {
            IdEntry.Text = _id;
            AliasEntry.Text = _alias;
            NombreEntry.Text = _nombre;
            ApellidoEntry.Text = _apell;
            LocalEntry.Text = _loca;
            DirEntry.Text = _direc;
            EmailEntry.Text = _email;
            TelEntry.Text = _tel;
            CuitEntry.Text = _cuit;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if(_tipo == "Cliente")
            {
                try
                {
                    string cmd = string.Format("EXEC ActualizarClientes '{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}'",
                        IdEntry.Text.Trim(), AliasEntry.Text.Trim(), NombreEntry.Text.Trim(), ApellidoEntry.Text.Trim(), LocalEntry.Text.Trim(), DirEntry.Text.Trim(),
                       EmailEntry.Text.Trim(), TelEntry.Text.Trim(), CuitEntry.Text.Trim());
                    Utilidades.Ejecutar(cmd);
                    MessageBox.Show("Datos del Cliente Actualizados");
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }

            if (_tipo == "Proveedor")
            {
                try
                {
                    string cmd = string.Format("EXEC ActualizarProveedores '{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}'",
                        IdEntry.Text.Trim(), AliasEntry.Text.Trim(), NombreEntry.Text.Trim(), ApellidoEntry.Text.Trim(), LocalEntry.Text.Trim(), DirEntry.Text.Trim(),
                       EmailEntry.Text.Trim(), TelEntry.Text.Trim(), CuitEntry.Text.Trim());
                    Utilidades.Ejecutar(cmd);
                    MessageBox.Show("Datos del proveedor actualizados");
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }


            NameEdit.Visible = true;
            SecondEdit.Visible = true;
            LocalidadEdit.Visible = true;
            DirEdit.Visible = true;
            EmailEdit.Visible = true;
            TelEdit.Visible = true;
            CuitEdit.Visible = true;

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
