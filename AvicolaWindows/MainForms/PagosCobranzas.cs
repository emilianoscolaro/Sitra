using AvicolaWindows.Base;
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
    public partial class PagosCobranzas : Explorador
    {
        public PagosCobranzas(string tipo,string usrlvl)
        {
            InitializeComponent();
            _tipo = tipo;
            _usrlvl = usrlvl;
        }


        string cliente;
        string id,_usrlvl;
        string total;
        string observaciones;
        string _tipo;
        string foto;
        string clienteProv;
        string moneda = "AR$";
        ImagenBd bd = new ImagenBd();

        private void LoadGrid()
        {
            if (_tipo == "Pagos")
            {
                DtClientes.DataSource = LlenarDataGrid("Pagos").Tables[0];

            }
            if (_tipo == "Cobranzas")
            {
                DtClientes.DataSource = LlenarDataGrid("Cobranzas").Tables[0];
            }
            this.DtClientes.Columns["Foto"].Visible = false;
            this.DtClientes.Columns["TipoDeCliente"].Visible = false;
            DtClientes.Columns[0].Width = 60;
            DtClientes.Sort(DtClientes.Columns[0], ListSortDirection.Descending);
            DtClientes.RowsDefaultCellStyle.BackColor = Color.Red;
            DtClientes.AlternatingRowsDefaultCellStyle.BackColor = Color.DarkGray;
            TotalTkt.Text = "0";
        }

        private void PagosCobranzas_Load(object sender, EventArgs e)
        {
            LoadGrid();
            label1.Text = _tipo;
            OcultarIdCero(DtClientes);
            DtClientes.Columns[5].DefaultCellStyle.Format = moneda + "###,##0.00";
            UserRestriction(_usrlvl);
        }

        private void DtClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cliente = Seleccionar(cliente, DtClientes, 3);
            id = Seleccionar(id, DtClientes, 0);
            total = Seleccionar(total, DtClientes, 5);
            observaciones = Seleccionar(observaciones, DtClientes, 6);
            foto = Seleccionar(foto, DtClientes, 7);
            clienteProv = Seleccionar(clienteProv, DtClientes, 8);

        }

        private void BuscarTxt_KeyUp(object sender, KeyEventArgs e)
        {
            Buscar(BuscarTxt, _tipo, "ID", DtClientes);
            if (BuscarTxt.Text == "") { LoadGrid(); OcultarIdCero(DtClientes); }
            SumaTotal();
        }

        private void BuscarTxt_MouseDown(object sender, MouseEventArgs e)
        {
            BuscarTxt.SelectAll();
        }

        private void BuscarCliente_MouseDown(object sender, MouseEventArgs e)
        {
            BuscarCliente.SelectAll();
        }

        private void BuscarCliente_KeyUp(object sender, KeyEventArgs e)
        {
            Buscar(BuscarCliente, _tipo, "Cliente", DtClientes);
            if (BuscarCliente.Text == "") { LoadGrid(); OcultarIdCero(DtClientes); }
            SumaTotal();
        }

        private void BuscarUsr_MouseDown(object sender, MouseEventArgs e)
        {
            BuscarUsr.SelectAll();
        }

        private void BuscarUsr_KeyUp(object sender, KeyEventArgs e)
        {
            Buscar(BuscarUsr, _tipo, "Usuario", DtClientes);
            if (BuscarUsr.Text == "") { LoadGrid(); OcultarIdCero(DtClientes); }
            SumaTotal();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            BuscarporfechaPagos();
            SumaTotal();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            BuscarporfechaPagos();
            SumaTotal();
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            LoadGrid();
            OcultarIdCero(DtClientes);
        }


        private void BuscarporfechaPagos()
        {
            try
            {
                DataSet ds;
                string cmd = "Select * FROM " + _tipo + " where Fecha between '" + dateTimePicker1.Text + "' and '" + dateTimePicker2.Text + "' ";

                ds = Utilidades.Ejecutar(cmd);
                DtClientes.DataSource = ds.Tables[0];
            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message);
            }
        }

        private void DtClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (string.IsNullOrEmpty(foto))
            {
                string message = "Este Pago no contiene ninguna imagen¿Deseas agregar una?";
                string title = "Imagen";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    openFileDialog1.Filter = "Archivos jpg (*.jpg)|*.jpg| Archivos png(*.png)|.png";
                    openFileDialog1.FilterIndex = 1;
                    openFileDialog1.RestoreDirectory = true;

                    if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        FotoImg.Image = Image.FromFile(openFileDialog1.FileName);
                        bd.InsertarSoloImagen(id, FotoImg, _tipo);
                        LoadGrid();
                    }
                }
            }
            else
            {
                Foto nuevafoto = new Foto(id, _tipo);
                nuevafoto.Show();
            }

        }

        private void VerBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(foto))
            {
                string message = "Este Pago no contiene ninguna imagen¿Deseas agregar una?";
                string title = "Imagen";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    openFileDialog1.Filter = "Archivos jpg (*.jpg)|*.jpg| Archivos png(*.png)|.png";
                    openFileDialog1.FilterIndex = 1;
                    openFileDialog1.RestoreDirectory = true;

                    if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        FotoImg.Image = Image.FromFile(openFileDialog1.FileName);
                        bd.InsertarSoloImagen(id, FotoImg, _tipo);
                        LoadGrid();
                    }
                }
            }
            else
            {
                Foto nuevafoto = new Foto(id, _tipo);
                nuevafoto.Show();
            }
        }

        private void EliminarBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(id))
            {
                if (observaciones != "Cancelado")
                {
                    string message = "¿Desea eliminar?";
                    string title = "Eliminar";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, buttons);
                    if (result == DialogResult.Yes)
                    {
                        if (_tipo == "Pagos")
                        {
                            string cmd = string.Format("EXEC EliminarPago '{0}','{1}'", id,total);
                            Utilidades.Ejecutar(cmd);
                            if (clienteProv == "Cliente")
                            {
                                string cmdd = string.Format("EXEC OpClienteCuentaCancel '{0}','{1}'", cliente, total);
                                Utilidades.Ejecutar(cmdd);
                            }
                            if (clienteProv == "Proveedor")
                            {
                                string cmdd = string.Format("EXEC OpProvCuenta '{0}','{1}'", cliente, total);
                                Utilidades.Ejecutar(cmdd);
                            }
                        }
                        if (_tipo == "Cobranzas")
                        {
                            string cmd = string.Format("EXEC EliminarCobranzas '{0}','{1}'", id,total);
                            Utilidades.Ejecutar(cmd);
                            if (clienteProv == "Cliente")
                            {
                                string cmdd = string.Format("EXEC OpClienteCuenta '{0}','{1}'", cliente, total);
                                Utilidades.Ejecutar(cmdd);
                            }
                            if (clienteProv == "Proveedor")
                            {
                                string cmdd = string.Format("EXEC OpProvCuentaCancel '{0}','{1}'", cliente, total);
                                Utilidades.Ejecutar(cmdd);
                            }
                        }
                    }

                }
                else { MessageBox.Show("La operacion ya esta cancelada"); }
                
            }
            else { MessageBox.Show("Debe seleccionar una operacion"); }
            LoadGrid();
            OcultarIdCero(DtClientes);
            SumaTotal();
        }

        private void ExelBtn_Click(object sender, EventArgs e)
        {
            ExportarExel(DtClientes, _tipo);
        }

        private void SumaTotal()
        {
            double total = 0;
            foreach (DataGridViewRow row in DtClientes.Rows)
            {
                total += Convert.ToDouble(row.Cells["Importe"].Value);
            }
            TotalTkt.Text = "AR$." + Convert.ToString(total);

        }



    }

}
