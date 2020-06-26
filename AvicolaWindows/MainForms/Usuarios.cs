using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AvicolaWindows;
using AvicolaWindows.Data;
using AvicolaWindows.EditForms;

namespace AvicolaWindows
{
    public partial class Usuarios : Explorador
    {
        public Usuarios(string id)
        {
            InitializeComponent();
            _userId = id;
        }

        string usr,contra,nombre,apell,id;
        string _userId;
      

        private void MostContrBtn_Click(object sender, EventArgs e)
        {
            this.DTUsuarios.Columns["Contraseña"].Visible = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked==true)
                this.DTUsuarios.Columns["Contraseña"].Visible = true;
            if (checkBox1.Checked == false)
                this.DTUsuarios.Columns["Contraseña"].Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            EditarUsuarios ed = new EditarUsuarios(usr, contra, nombre, apell,id);
            ed.Show();
        }


        private void LoadGrid()
        {
            DTUsuarios.DataSource = LlenarDataGrid("Usuarios").Tables[0];
            this.DTUsuarios.Columns["Contraseña"].Visible = false;
            this.DTUsuarios.Columns["RutaImagenes"].Visible = false;
            this.DTUsuarios.Columns["RutaDescargas"].Visible = false;
            DTUsuarios.Columns[0].Width = 60;
            DTUsuarios.Sort(DTUsuarios.Columns[0], ListSortDirection.Descending);
        }


        private void Usuarios_Load(object sender, EventArgs e)
        {
            LoadGrid();
            OcultarIdCero(DTUsuarios);
        }

        private void DTUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditarUsuarios ed = new EditarUsuarios(usr, contra, nombre, apell,id);
            ed.Show();
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            LoadGrid();
            OcultarIdCero(DTUsuarios);
        }

        private void BuscarTxt_MouseDown(object sender, MouseEventArgs e)
        {
            BuscarTxt.SelectAll();
        }

        private void BuscarTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Buscar(BuscarTxt, "Usuarios", "Usuario", DTUsuarios);
            if (BuscarTxt.Text == "") { LoadGrid(); OcultarIdCero(DTUsuarios); }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            DTUsuarios.DataSource = LlenarDataGrid("Usuarios").Tables[0];
            this.DTUsuarios.Columns["Contraseña"].Visible = false;
            LoadGrid();
        }

        private void EliminarBtn_Click_1(object sender, EventArgs e)
        {
            if (usr == "Admin")
            {
                MessageBox.Show("Este usuario no se puede eliminar");
            }
            else { Eliminar("EliminarUsuario", usr, DTUsuarios, "Usuarios"); }
            LoadGrid();
            OcultarIdCero(DTUsuarios);
        }

        private void DTUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Seleccionar(id, DTUsuarios, 0);
            usr = Seleccionar(usr, DTUsuarios,2);
            contra = Seleccionar(contra, DTUsuarios, 3);
            nombre = Seleccionar(nombre, DTUsuarios, 4);
            apell = Seleccionar(apell, DTUsuarios, 5);
            
        }



    }

    
}
