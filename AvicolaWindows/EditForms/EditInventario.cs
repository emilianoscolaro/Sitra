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
    public partial class EditInventario : Form
    {
        public EditInventario(string id,string descripcion,string articulo)
        {
            InitializeComponent();
            _id = id;
            _descripcion = descripcion;
            _articulo = articulo;
        }

        string _id;
        string _descripcion;
        string _articulo;

        private void NameEdit_Click(object sender, EventArgs e)
        {
            DescripcionEntry.Enabled = true;
            DescripcionEntry.Focus();
            DescripcionEntry.SelectAll();
            NameEdit.Visible = false;
            button2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string cmd = string.Format("EXEC EditarInventario '{0}','{1}'", _id, DescripcionEntry.Text);
                Utilidades.Ejecutar(cmd);
                MessageBox.Show("Datos del Articulo Actualizados,recuerde refrescar la tabla de inventario para ver el cambio");
                this.Close();            
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

        }

        private void EditInventario_Load(object sender, EventArgs e)
        {
            DescripcionEntry.Text = _descripcion;
            TitleLabel.Text = _articulo;
        }
    }
}
