using AvicolaWindows.Data;
using DocumentFormat.OpenXml.Office2013.PowerPoint.Roaming;
using SpreadsheetLight;
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

        string _cliente,ruta;
        float cuenta;
        DataSet Ds;


        private void DetalleCuenta_Load(object sender, EventArgs e)
        {
            ClienteTxt.Text = _cliente;
            DtCuenta.DataSource = LlenarGrid().Tables[0];
            Suma();
        }

        


        private DataSet LlenarGrid()
        {
            try
            {
                string cmd = string.Format("SELECT TOP (30) * from DetallesCuentas  where Cliente ='" + _cliente + "'");
                Ds = Utilidades.Ejecutar(cmd);
                
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            return Ds;
        }

        private void BuscarPorFecha(DateTimePicker fechaUno, DateTimePicker fechaDos)
        {
            try
            {
                DataSet ds;
                string cmd = "Select * FROM DetallesCuentas  where Fecha between '" + fechaUno.Text + "' and '" + fechaDos.Text + "'AND Cliente ='" + _cliente + "'";

                ds = Utilidades.Ejecutar(cmd);
                DtCuenta.DataSource = ds.Tables[0];
            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            BuscarPorFecha(dateTimePicker1,dateTimePicker2);
            Suma();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            BuscarPorFecha(dateTimePicker1, dateTimePicker2);
            Suma();
        }




        public void ExportarExel(DataGridView dt, string tipo)
        {
            SLDocument sl = new SLDocument();
            SLStyle style = new SLStyle();
            style.Font.FontSize = 15;
            style.Font.Bold = true;

            int ic = 1;
            foreach (DataGridViewColumn colum in dt.Columns)
            {
                sl.SetCellValue(1, ic, colum.HeaderText.ToString());
                sl.SetCellStyle(1, ic, style);
                ic++;
            }

            int ir = 2;
            int cuenta = 1;

            foreach (DataGridViewRow row in dt.Rows)
            {
                cuenta = 1;
                for (int i = 0; i < dt.Columns.Count; i++)
                {

                    sl.SetCellValue(ir, cuenta, row.Cells[i].Value.ToString());
                    cuenta++;
                }

                ir++;
            }


            using (var folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    ruta = folderDialog.SelectedPath;
                    ruta = ruta + "\\Cuenta " + tipo + ".xlsx";
                    sl.SaveAs(ruta);
                }
            }

        }

        private void Suma()
        {
            cuenta = 0;
            for (int i = 0; i < DtCuenta.RowCount; i++)
            {
                if(DtCuenta.Rows[i].Cells[2].Value.ToString() == "Op.Venta")
                {
                    cuenta += float.Parse(DtCuenta.Rows[i].Cells[4].Value.ToString());    
                }

                if (DtCuenta.Rows[i].Cells[2].Value.ToString() == "Op.Compra")
                {
                    cuenta -= float.Parse(DtCuenta.Rows[i].Cells[4].Value.ToString());
                }
                if (DtCuenta.Rows[i].Cells[2].Value.ToString() == "Pago")
                {
                    cuenta += float.Parse(DtCuenta.Rows[i].Cells[4].Value.ToString());
                }

                if (DtCuenta.Rows[i].Cells[2].Value.ToString() == "Cobro")
                {
                    cuenta -= float.Parse(DtCuenta.Rows[i].Cells[4].Value.ToString());
                }
                DtCuenta.Rows[i].Cells[5].Value = cuenta;
                CuentaTotalTxt.Text ="AR$ " + string.Format("{0:n}", cuenta);
            }
        }

        private void ExelBtn_Click(object sender, EventArgs e)
        {
            ExportarExel(DtCuenta, _cliente);
        }

        private void ExelBtn_MouseEnter(object sender, EventArgs e)
        {
            ExelBtn.Size = ExelBtn.Size + new Size(5, 5);
        }

        private void ExelBtn_MouseLeave(object sender, EventArgs e)
        {
            ExelBtn.Size = ExelBtn.Size - new Size(5, 5);
        }


    }
}
