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
    public partial class InventarioHistorico : Form
    {
        public InventarioHistorico()
        {
            InitializeComponent();
        }


        DataSet Ds;
        DateTime today = DateTime.Today;



        private void InventarioHistorico_Load(object sender, EventArgs e)
        {
            DtStock.DataSource = LlenarGrid().Tables[0];
            LoadGrid();
        }

        private void LoadGrid()
        {
            this.DtStock.Columns["ID"].Visible = false;
            this.DtStock.Columns["Descripcion"].Visible = false;

            foreach (DataGridViewRow row in DtStock.Rows )
            {
                if(row.Cells[2].Value.ToString() == "")
                {
                    row.Visible = false;
                }
            }

        }


        private DataSet LlenarGrid()
        {
            try
            {
                string cmd = string.Format("SELECT * from Inventario_Historico  where Fecha ='"+today+"'");
                Ds = Utilidades.Ejecutar(cmd);

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            return Ds;
        }

        private void BuscarporFecha(DateTimePicker fechaUno)
        {
            try
            {
                DataSet ds;
                string cmd = "Select * FROM Inventario_Historico  where Fecha = '" + fechaUno.Text +"'";

                ds = Utilidades.Ejecutar(cmd);
                DtStock.DataSource = ds.Tables[0];
                LoadGrid();
                today = fechaUno.Value;
            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message);
            }
        }

        private void DatePicker1_ValueChanged(object sender, EventArgs e)
        {
            BuscarporFecha(DatePicker1);
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
           today= today.AddDays(-1);
            DatePicker1.Value = today;
            LlenarGrid();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           today = today.AddDays(1);
            DatePicker1.Value = today;
            LlenarGrid();
        }
    }
}
