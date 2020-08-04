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
    public partial class Cheques : Explorador
    {
        public Cheques(string usrlvl)
        {
            InitializeComponent();
            _ustLvl = usrlvl;
        }

        string moneda = "AR$";
        string _ustLvl;
        string id, fech, fechCobro, numero, banco, importe, recibido, destinado;

        private void Cheques_Load(object sender, EventArgs e)
        {
            LoadGrid();
           
            OcultarIdCero(DtClientes);
        }




        private void DtClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Seleccionar(id, DtClientes, 0);
            fech = Seleccionar(fech, DtClientes, 1);
            fechCobro = Seleccionar(fechCobro, DtClientes, 2);
            numero = Seleccionar(numero, DtClientes, 3);
            banco = Seleccionar(banco, DtClientes, 4);
            importe = Seleccionar(importe, DtClientes, 5);
            recibido = Seleccionar(recibido, DtClientes, 6);
            destinado = Seleccionar(destinado, DtClientes, 7);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            LoadGrid();
            OcultarIdCero(DtClientes);
            
        }

        private void ExelBtn_Click(object sender, EventArgs e)
        {
            ExportarExel(DtClientes, "Cheques");
        }



        private void EliminarBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(id))
            {
                    string message = "¿Desea eliminar el cheque ?";
                    string title = "Eliminar";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, buttons);
                    if (result == DialogResult.Yes)
                    {
                        string cmd = string.Format("EXEC EliminarCheque '{0}'", id);
                        Utilidades.Ejecutar(cmd);
                        LoadGrid();
                        OcultarIdCero(DtClientes);
                    }
            }
            else { MessageBox.Show("Debe seleccionar un cheque"); }
        }


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            BuscarporfechaCheques();
        }
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            BuscarporfechaCheques();
        }


        private void BuscarTxt_MouseDown(object sender, MouseEventArgs e)
        {
            BuscarTxt.SelectAll();
        }

        private void BuscarTxt_KeyUp(object sender, KeyEventArgs e)
        {
            Buscar(BuscarTxt, "Cheques", "ID", DtClientes);
            if (BuscarTxt.Text == "") { LoadGrid(); OcultarIdCero(DtClientes); }
           
        }

        private void BuscarPorNumTxt_MouseDown(object sender, MouseEventArgs e)
        {
            BuscarPorNumTxt.SelectAll();
        }

        private void BuscarPorNumTxt_KeyUp(object sender, KeyEventArgs e)
        {
            Buscar(BuscarPorNumTxt, "Cheques", "Numero", DtClientes);
            if (BuscarPorNumTxt.Text == "") { LoadGrid(); OcultarIdCero(DtClientes); }
        }


        // Funciones

        //  private void SumaTotal()
        //  {
        //      double total = 0;
        //      foreach (DataGridViewRow row in DtClientes.Rows)
        //      {
        //          total += Convert.ToDouble(row.Cells["Importe"].Value);
        //      }
        //      TotalTkt.Text = "AR$ " + string.Format("{0:n}", total);
        //
        //  }

        private void LoadGrid()
        {
            DtClientes.DataSource = LlenarDataGrid("Cheques").Tables[0];
            //this.DtClientes.Columns["Numero"].Visible = false;
            DtClientes.Columns[0].Width = 60;
            DtClientes.Sort(DtClientes.Columns[0], ListSortDirection.Descending);
        }

        private void BuscarporfechaCheques()
        {
            try
            {
                DataSet ds;
                string cmd = "Select * FROM Cheques where Fecha between '" + dateTimePicker1.Text + "' and '" + dateTimePicker2.Text + "' ";

                ds = Utilidades.Ejecutar(cmd);
                DtClientes.DataSource = ds.Tables[0];
            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message);
            }
        }

    }
}
