using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AvicolaWindows.Data;
using DocumentFormat.OpenXml.Drawing;
using SpreadsheetLight;

namespace AvicolaWindows
{
    public partial class Explorador : Form
    {
        public Explorador()
        {
            InitializeComponent();
        }


        //  dataGridView1.DataSource = LlenarDataGrid("Usuarios").Tables[0];

        public DataSet LlenarDataGrid(string tabla)
        {
            DataSet DS;
            string cmd = string.Format("SELECT TOP (200) * FROM " + tabla+ " order by ID desc");
            DS = Utilidades.Ejecutar(cmd);

            return DS;
        }

        public void UserRestriction(string usrLvl)
        {
            if (usrLvl == "1")
            {
                VerBtn.Visible = false;
                EliminarBtn.Visible = false;
            }
            if (usrLvl == "2")
            {
                EliminarBtn.Visible = false;
            }
        }

        public void OcultarIdCero(DataGridView dt)
        {
            dt.Rows.Remove(dt.Rows[dt.Rows.Count - 1]);
        }

        public void Buscar(TextBox buscarbox, string Tabla, string variable, DataGridView dt)
        {
            if (string.IsNullOrEmpty(buscarbox.Text.Trim()) == false)
            {

                try
                {
                    DataSet ds;
                    string cmd = "Select * FROM " + Tabla + " where " + variable + " LIKE ('%" + buscarbox.Text.Trim() + "%')";

                    ds = Utilidades.Ejecutar(cmd);
                    dt.DataSource = ds.Tables[0];
                }
                catch (Exception error)
                {

                    MessageBox.Show(error.Message);
                }
            }
        }

        public void BuscarOp(TextBox buscarbox, string Tabla, string variable, DataGridView dt)
        {
            if (string.IsNullOrEmpty(buscarbox.Text.Trim()) == false)
            {

                try
                {
                    DataSet ds;
                    string cmd = "Select ID,fecha,Usuario,Cliente,Observaciones,Total FROM " + Tabla + " where " + variable + " LIKE ('%" + buscarbox.Text.Trim() + "%')";

                    ds = Utilidades.Ejecutar(cmd);
                    dt.DataSource = ds.Tables[0];
                }
                catch (Exception error)
                {

                    MessageBox.Show(error.Message);
                }
            }
        }

        public void BuscarPorFecha(DateTimePicker fechaUno,DateTimePicker fechaDos,DataGridView dt , string tabla,string clienteProov)
        {
            try
            {
                DataSet ds;
                string cmd = "Select ID,fecha,Usuario,"+clienteProov+",Observaciones,Total FROM "+ tabla +" where Fecha between '" + fechaUno.Text + "' and '" + fechaDos.Text + "' ";

                ds = Utilidades.Ejecutar(cmd);
                dt.DataSource = ds.Tables[0];
            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message);
            }
        }

        public void Eliminar(string funcionSQL,string seleccion,DataGridView dt,string Tabla)
        {

            try
            {
                string message = "¿Deseas Eliminar?";
                string title = "Eliminar";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    string cmd = string.Format("EXEC " + funcionSQL + "  '{0}'", seleccion);
                    Utilidades.Ejecutar(cmd);
                    dt.DataSource = LlenarDataGrid(Tabla).Tables[0];
                }
                else
                {
                    
                }

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        public string Seleccionar(string seleccion,DataGridView dt,int celda)
        {
            seleccion = dt.CurrentRow.Cells[celda].Value.ToString();
            return seleccion;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }


        public DataSet LlenarDataOp(string tabla)
        {
            DataSet DS;
            string cmd = string.Format("SELECT ID,fecha,Usuario,Cliente,Observaciones,Total  FROM " + tabla);
            DS = Utilidades.Ejecutar(cmd);

            return DS;
        }
        public DataSet LlenarDataOpProv(string tabla)
        {
            DataSet DS;
            string cmd = string.Format("SELECT ID,fecha,Usuario,Proveedor,Observaciones,Total  FROM " + tabla);
            DS = Utilidades.Ejecutar(cmd);

            return DS;
        }

        private void EliminarBtn_MouseEnter(object sender, EventArgs e)
        {
            EliminarBtn.Size = EliminarBtn.Size+ new Size(14, 4);
        }

        private void EliminarBtn_MouseLeave(object sender, EventArgs e)
        {
            EliminarBtn.Size = EliminarBtn.Size - new Size(14, 4);
        }

        private void NuevaOpBtn_MouseEnter(object sender, EventArgs e)
        {
            NuevaOpBtn.Size = NuevaOpBtn.Size + new Size(14, 4);
        }

        private void NuevaOpBtn_MouseLeave(object sender, EventArgs e)
        {
            NuevaOpBtn.Size = NuevaOpBtn.Size - new Size(14, 4);
        }

        private void VerBtn_MouseEnter(object sender, EventArgs e)
        {
            VerBtn.Size = VerBtn.Size + new Size(14, 4);
        }

        private void VerBtn_MouseLeave(object sender, EventArgs e)
        {
            VerBtn.Size = VerBtn.Size - new Size(14, 4);
        }

        private void FacturaBtn_MouseEnter(object sender, EventArgs e)
        {
            FacturaBtn.Size = FacturaBtn.Size + new Size(14, 4);
        }

        private void FacturaBtn_MouseLeave(object sender, EventArgs e)
        {
            FacturaBtn.Size = FacturaBtn.Size - new Size(14, 4);
        }

        string ruta;




        public void ExportarExel(DataGridView dt,string tipo)
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

            foreach (DataGridViewRow row in dt.Rows )
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
                    //ruta = folderDialog.SelectedPath;
                    sl.SaveAs(@"" +ruta+ @"\"+tipo+".xlsx");
                }
            }

            

        }

        private void ExelBtn_MouseEnter(object sender, EventArgs e)
        {
            ExelBtn.Size = ExelBtn.Size + new Size(5, 5);
        }

        private void ExelBtn_MouseLeave(object sender, EventArgs e)
        {
            ExelBtn.Size = ExelBtn.Size - new Size(5, 5);
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Size = pictureBox1.Size + new Size(5,5);
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Size = pictureBox1.Size - new Size(5, 5);
        }
    }
}
