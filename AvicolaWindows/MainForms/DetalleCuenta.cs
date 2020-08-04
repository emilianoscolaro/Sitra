using AvicolaWindows.Base;
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
        public DetalleCuenta(string cliente,string usrId)
        {
            InitializeComponent();

            _cliente = cliente;
            _usrId = usrId;
        }

        string _cliente,ruta;
        string _usrId;
        float cuenta;
        DataSet Ds;
        string selectId, selectType,selectedCliente;
        string tipo;
        string foto;

        private void DetalleCuenta_Load(object sender, EventArgs e)
        {
            ClienteTxt.Text = _cliente;
            DtCuenta.DataSource = LlenarGrid().Tables[0];
            LoadGrid();
            Suma();
        }

        private void LoadGrid()
        {
            DtCuenta.Columns[0].Width = 80;
            DtCuenta.Columns[3].Width = 60;
            this.DtCuenta.Columns["Cuenta"].Visible = false;
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
            LoadGrid();
            Suma();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            BuscarPorFecha(dateTimePicker1, dateTimePicker2);
            LoadGrid();
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
                if(DtCuenta.Rows[i].Cells[2].Value.ToString() == "Op.Venta" && DtCuenta.Rows[i].Cells[6].Value.ToString() != "Pagado al contado | ")
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true) { this.DtCuenta.Columns["Cuenta"].Visible = true; }
            if (checkBox1.Checked == false) { this.DtCuenta.Columns["Cuenta"].Visible = false; }
        }

        private void DtCuenta_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Suma();
        }

        private void DtCuenta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedCliente = Explorador.Seleccionar(selectedCliente, DtCuenta, 1);
            selectId = Explorador.Seleccionar(selectId, DtCuenta, 3);
            selectType = Explorador.Seleccionar(selectType, DtCuenta, 2);
        }

        private void DtCuenta_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TypeFilter();
            if(tipo == "Cliente" || tipo== "Proveedor")
            {
                Factura fc = new Factura(selectedCliente, selectId, _usrId,tipo);
                fc.Show();
            }
            if(tipo =="Cobranzas" || tipo == "Pagos")
            {
                VerificarFoto();
                if (!string.IsNullOrEmpty(foto))
                {
                    Foto nuevafoto = new Foto(selectId, tipo);
                    nuevafoto.Show();
                }
                else
                {
                    MessageBox.Show("El " + selectType + " no contiene ninguna imagen");
                }

            }


        }

        private void ExelBtn_MouseLeave(object sender, EventArgs e)
        {
            ExelBtn.Size = ExelBtn.Size - new Size(5, 5);
        }

        private void TypeFilter()
        {
            if(selectType == "Op.Venta") { tipo = "Cliente"; }
            if(selectType == "Op.Compra") { tipo = "Proveedor"; }
            if (selectType == "Pago") { tipo = "Pagos"; }
            if (selectType == "Cobro") { tipo = "Cobranzas"; }

        }

        private void VerificarFoto()
        {
            string cmd = string.Format("SELECT foto from " + tipo + " where Id =" + selectId + "");
            Ds = Utilidades.Ejecutar(cmd);
            foto = Ds.Tables[0].Rows[0]["Foto"].ToString();
        }
    }
}
