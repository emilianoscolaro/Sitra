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

namespace AvicolaWindows
{
    public partial class CrearInventario : Form
    {
        public CrearInventario()
        {
            InitializeComponent();
        }

        int index;
        int stock = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                string cmddos = String.Format("SELECT top(1) * FROM Inventario order by ID desc ");
                DataSet ds = Utilidades.Ejecutar(cmddos);
                string num = ds.Tables[0].Rows[0]["ID"].ToString();
                Int32.TryParse(num, out index);
                index = index + 1;
                string cmd = string.Format("EXEC CrearInventario '{0}','{1}','{2}','{3}'", index, Entry1.Text.Trim(), Entry2.Text.Trim(),stock);
                Utilidades.Ejecutar(cmd);
                MessageBox.Show("Articulo creado");
                Entry1.Text = "";
                Entry2.Text = "";

            }

            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
