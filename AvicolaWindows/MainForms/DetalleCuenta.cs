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

namespace AvicolaWindows.MainForms
{
    public partial class DetalleCuenta : Form
    {
        public DetalleCuenta(string cliente)
        {
            InitializeComponent();

            _cliente = cliente;
        }

        string _cliente;


        private void DetalleCuenta_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        DataSet Ds;
        private void LoadGrid()
        {
            dataGridView1.DataSource = LlenarGrid().Tables[0];
        }


        private DataSet LlenarGrid()
        {
            try
            {
                string cmd = string.Format("SELECT * from DetallesCuentas  where Cliente ='" + _cliente + "'");
                Ds = Utilidades.Ejecutar(cmd);
                
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            return Ds;
        }
    }
}
