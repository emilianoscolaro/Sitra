using AvicolaWindows.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AvicolaWindows
{
    public partial class CrearPagoCobranza : Form
    {
        public CrearPagoCobranza(string tipo,string usr,string usrId)
        {
            InitializeComponent();

            _tipo = tipo;
            _usr = usr;
            _usrId = usrId;
        }
        string _tipo,_usr,_usrId;
        int index;
        int chequeIndex;
        ImagenBd bd = new ImagenBd();
        bool hayFoto;
        string ruta;
        bool hayCheque = false;


        private void CrearPagoCobranza_Load(object sender, EventArgs e)
        {

            try
            {

                if (_tipo == "Pagos")
                {
                    TituloTxt.Text = "Nuevo Pago";
                    AgregarBtn.Text = "Ingresar pago";
                    string cmddos = String.Format("SELECT top(1) * FROM Pagos order by ID desc ");
                    DataSet ds = Utilidades.Ejecutar(cmddos);
                    string num = ds.Tables[0].Rows[0]["ID"].ToString();
                    Int32.TryParse(num, out index);
                    index = index + 1;
                    IdText.Text = index.ToString();
                    ProveedorText.ForeColor = Color.Teal;
                    ClienteTxt.ForeColor = Color.Gray;
                    ClienteProvBox.DataSource = Utilidades.EjecutaListPagosCob("LlenarComboProvedores");
                    ClienteProvBox.DisplayMember = "Alias";
                }

                if (_tipo == "Cobranzas")
                {
                    TituloTxt.Text = "Nueva Cobranza";
                    AgregarBtn.Text = "Ingresar cobranza";
                    string cmddos = String.Format("SELECT top(1) * FROM Cobranzas order by ID desc ");
                    DataSet ds = Utilidades.Ejecutar(cmddos);
                    string num = ds.Tables[0].Rows[0]["ID"].ToString();
                    Int32.TryParse(num, out index);
                    index = index + 1;
                    IdText.Text = index.ToString();
                    ClienteTxt.ForeColor = Color.Teal;
                    ProveedorText.ForeColor = Color.Gray;
                    ClienteProvBox.DataSource = Utilidades.EjecutaListPagosCob("LlenarComboCliente");
                    ClienteProvBox.DisplayMember = "Alias";
                }
                FechaTxt.Text = DateTime.Now.ToShortDateString();
                FormaDEPagoBox.DataSource = Utilidades.EjecutaListPagosCob("LlenarFormaDePago");
                FormaDEPagoBox.DisplayMember = "Forma";
                SeleccionarRuta();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
                
            }

        }


        public void SoloNumeros(KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (e.KeyChar == '.')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }



        private void ImporteTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }



        private string TipoDeClienteSeleccionado()
        {
            string clientesProv = "";
            if(ClienteTxt.ForeColor == Color.Teal)
            {
                clientesProv = "Cliente";
            }
            if (ProveedorText.ForeColor == Color.Teal)
            {
                clientesProv = "Proveedor";
            }
            return clientesProv;
        } 

        private void IngresodePagoCobro()
        {
            if(_tipo == "Pagos")
            {
                if (ClienteTxt.ForeColor == Color.Teal)
                {
                    string cmd = string.Format("EXEC IngresoPagoCliente '{0}','{1}'", ClienteProvBox.Text, ImporteTxt.Text);
                    Utilidades.Ejecutar(cmd);
                }
                else if (ProveedorText.ForeColor == Color.Teal)
                {
                    string cmd = string.Format("EXEC IngresoPagoProv '{0}','{1}'", ClienteProvBox.Text, ImporteTxt.Text);
                    Utilidades.Ejecutar(cmd);
                }
            }

            if (_tipo == "Cobranzas")
            {
                if (ClienteTxt.ForeColor == Color.Teal)
                {
                    string cmd = string.Format("EXEC IngresoCobroCliente '{0}','{1}'", ClienteProvBox.Text, ImporteTxt.Text);
                    Utilidades.Ejecutar(cmd);
                }
                else if (ProveedorText.ForeColor == Color.Teal)
                {
                    string cmd = string.Format("EXEC IngresoCobroProve '{0}','{1}'", ClienteProvBox.Text, ImporteTxt.Text);
                    Utilidades.Ejecutar(cmd);
                }
            }
        }

        private void FormaDEPagoBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (FormaDEPagoBox.Text == "Cheque")
            {
                ChequePanel.Visible = true;hayCheque = true;
                Recibido.DataSource = Utilidades.EjecutaListPagosCob("LlenarComboCliente");
                Recibido.DisplayMember = "Alias";
                Destinado.DataSource = Utilidades.EjecutaListPagosCob("LlenarComboProvedores");
                Destinado.DisplayMember = "Alias";
                if(_tipo == "Pagos") { NuevoChequeTxt.ForeColor = Color.Gray;CarCheuqeTxt.ForeColor = Color.Teal; ChequeBox.DataSource = Utilidades.EjecutaListPagosCob("LlenarCoboCheque");
                    ChequeBox.DisplayMember = "ID"; PagarConChequeRestrincion();Destinado.Text = ClienteProvBox.Text;
                }
                if(_tipo == "Cobranzas") { NuevoChequeTxt.ForeColor = Color.Teal; CarCheuqeTxt.ForeColor = Color.Gray; ChequeBox.Enabled = false;
                    Recibido.Text = ClienteProvBox.Text;
                }
            }
            else { ChequePanel.Visible = false; hayCheque = false; }
        }

        private void InsertarDatosPagoCob()
        {
            if (hayFoto == true)
            {
                bd.InsertarImagen(_tipo, index, FechaTxt.Text, _usr, ClienteProvBox.Text, FormaDePago(), ImporteTxt.Text, ObservacionesTxt.Text, pictureBox3,TipoDeClienteSeleccionado());
                bd.InsertarDetalle(_tipo, index, FechaTxt.Text, ClienteProvBox.Text, ImporteTxt.Text, ObservacionesTxt.Text);
            }
            else
            {
                if (_tipo == "Pagos")
                {
                    string cmd = string.Format("EXEC NuevoPago '{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}'", index, FechaTxt.Text, _usr, ClienteProvBox.Text,
                        FormaDePago(), ImporteTxt.Text, ObservacionesTxt.Text,TipoDeClienteSeleccionado());
                    Utilidades.Ejecutar(cmd);
                }

                if (_tipo == "Cobranzas")
                {
                    string cmd = string.Format("EXEC NuevaCobranza '{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}'", index, FechaTxt.Text, _usr, ClienteProvBox.Text,
                      FormaDePago(), ImporteTxt.Text, ObservacionesTxt.Text, TipoDeClienteSeleccionado());
                    Utilidades.Ejecutar(cmd);

                }
            }
        }

        private void AgregarBtn_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ClienteProvBox.Text) && !string.IsNullOrEmpty(ImporteTxt.Text))
            {
                try
                {
                    if (hayCheque == true && _tipo =="Cobranzas") { IngresarCheque(); }
                    if (hayCheque == true && _tipo == "Pagos") { ActualizarCheque(); }
                    IngresodePagoCobro();
                    InsertarDatosPagoCob();
                    MessageBox.Show("Ingresado correnctamente");
                    ClienteProvBox.Text = "";
                    FormaDEPagoBox.Text = "";
                    ImporteTxt.Text = "";
                    ObservacionesTxt.Text = "";
                    FotoLabel.Visible = false;  
                    hayFoto = false;
                    RutaTxt.Text = "";
                    RutaTxt.Visible = false;
                    index++;
                    IdText.Text = index.ToString();
                    ChequePanel.Visible = false;
                    hayCheque = false;
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
            else { MessageBox.Show("Debe ingresar los datos del Cliente/Proveedor e Importe"); }



        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = ruta;
            openFileDialog1.Filter = "Archivos jpg (*.jpg)|*.jpg| Archivos png(*.png)|.png";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                RutaTxt.Text = openFileDialog1.FileName;
                RutaTxt.Visible = true;
                FotoLabel.Visible = true;
                RutaLine.Visible = true;
                pictureBox3.Image = Image.FromFile(openFileDialog1.FileName);
                hayFoto = true;
            }
        }

        private void CheuqeNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void ProveedorText_MouseDown_1(object sender, MouseEventArgs e)
        {
            ProveedorText.ForeColor = Color.Teal;
            ClienteTxt.ForeColor = Color.Gray;
            ClienteProvBox.DataSource = Utilidades.EjecutaListPagosCob("LlenarComboProvedores");
            ClienteProvBox.DisplayMember = "Alias";
        }

        private void ClienteTxt_MouseDown_1(object sender, MouseEventArgs e)
        {
            ClienteTxt.ForeColor = Color.Teal;
            ProveedorText.ForeColor = Color.Gray;
            ClienteProvBox.DataSource = Utilidades.EjecutaListPagosCob("LlenarComboCliente");
            ClienteProvBox.DisplayMember = "Alias";
        }

        private void RClienteTxt_MouseDown(object sender, MouseEventArgs e)
        {
            RClienteTxt.ForeColor = Color.Teal;
            RProvTxt.ForeColor = Color.Gray;
            Recibido.DataSource = Utilidades.EjecutaListPagosCob("LlenarComboCliente");
            Recibido.DisplayMember = "Alias";
        }

        private void RProvTxt_MouseDown(object sender, MouseEventArgs e)
        {
            RProvTxt.ForeColor = Color.Teal;
            RClienteTxt.ForeColor = Color.Gray;
            Recibido.DataSource = Utilidades.EjecutaListPagosCob("LlenarComboProvedores");
            Recibido.DisplayMember = "Alias";
        }

        private void DClienteTxt_MouseDown(object sender, MouseEventArgs e)
        {
            DClienteTxt.ForeColor = Color.Teal;
            DProvTxt.ForeColor = Color.Gray;
            Destinado.DataSource = Utilidades.EjecutaListPagosCob("LlenarComboCliente");
            Destinado.DisplayMember = "Alias";
        }

        private void DProvTxt_MouseDown(object sender, MouseEventArgs e)
        {
            DProvTxt.ForeColor = Color.Teal;
            DClienteTxt.ForeColor = Color.Gray;
            Destinado.DataSource = Utilidades.EjecutaListPagosCob("LlenarComboProvedores");
            Destinado.DisplayMember = "Alias";
        }

        private void CarCheuqeTxt_MouseDown(object sender, MouseEventArgs e)
        {
            CarCheuqeTxt.ForeColor = Color.Teal;
            NuevoChequeTxt.ForeColor = Color.Gray;
            ChequeBox.DataSource = Utilidades.EjecutaListPagosCob("LlenarCoboCheque");
            ChequeBox.DisplayMember = "ID";
            ChequeBox.Enabled = true;
        }

        private void NuevoChequeTxt_MouseDown(object sender, MouseEventArgs e)
        {
            CarCheuqeTxt.ForeColor = Color.Gray;
            NuevoChequeTxt.ForeColor = Color.Teal;
            ChequeBox.Enabled = false;
            ChequeNum.Text = "";
            ChequeBanco.Text = "";
            ChequeImporte.Text = "";

        }

        private void SeleccionarRuta()
        {
            string cmd = string.Format("SELECT RutaImagenes from Usuarios where ID = " + _usrId + "");
            DataSet ds = Utilidades.Ejecutar(cmd);
            ruta = ds.Tables[0].Rows[0]["RutaImagenes"].ToString();
        }

        private void ChequeBox_SelectedValueChanged(object sender, EventArgs e)
        {
            int idcheque;

            int.TryParse(ChequeBox.Text, out idcheque);
            LlenarDatosCheque(idcheque);
        }

        private void ImporteTxt_TextChanged(object sender, EventArgs e)
        {
            if (hayCheque == true) { ChequeImporte.Text = ImporteTxt.Text; }
        }

        private void ChequeImporte_TextChanged(object sender, EventArgs e)
        {
            ImporteTxt.Text = ChequeImporte.Text;
        }

        private void ActualizarCheque()
        {
            string cmd = string.Format("EXEC ActualizarCheque '{0}','{1}'", ChequeBox.Text, Destinado.Text);
            Utilidades.Ejecutar(cmd);
        }

        private void IngresarCheque()
        {

            try
            {
                string cmddos = String.Format("SELECT top(1) * FROM Cheques order by ID desc ");
                DataSet ds = Utilidades.Ejecutar(cmddos);
                string num = ds.Tables[0].Rows[0]["ID"].ToString();
                Int32.TryParse(num, out chequeIndex);
                chequeIndex = chequeIndex + 1;
                string cmd = string.Format("EXEC CrearCheque '{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}'",
                    chequeIndex, FechaCheque.Value, FechaCobro.Value, ChequeNum.Text, ChequeBanco.Text,ChequeImporte.Text,
                    Recibido.Text, Destinado.Text);
                Utilidades.Ejecutar(cmd);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }


        }

        private void CarCheuqeTxt_ForeColorChanged(object sender, EventArgs e)
        {
            PagarConChequeRestrincion();
        }

        private void LlenarDatosCheque(int id)
        {
            try
            {
                string cmd = string.Format("SELECT * from Cheques where ID =" + id);
                DataSet ds = Utilidades.Ejecutar(cmd);
                string fecha = ds.Tables[0].Rows[0]["Fecha"].ToString();
                string fechCobro = ds.Tables[0].Rows[0]["FechaCobro"].ToString();
                string numero = ds.Tables[0].Rows[0]["Numero"].ToString();
                string banco = ds.Tables[0].Rows[0]["Banco"].ToString();
                string importe = ds.Tables[0].Rows[0]["Importe"].ToString();
                string recibido = ds.Tables[0].Rows[0]["Recibido"].ToString();
                ChequeNum.Text = numero;
                ChequeBanco.Text = banco;
                ChequeImporte.Text = importe;
                Recibido.Text = recibido;
                FechaCheque.Value = Convert.ToDateTime(fecha);
                FechaCobro.Value = Convert.ToDateTime(fechCobro);
            }
            catch (Exception)
            {
            }
        }

        private void ClienteProvBox_TextChanged(object sender, EventArgs e)
        {
            if (_tipo == "Pagos")
            {
                Destinado.Text = ClienteProvBox.Text;
            }
            if (_tipo == "Cobranzas")
            {
                Recibido.Text = ClienteProvBox.Text;
            }

        }

        private string FormaDePago()
        {
            if (FormaDEPagoBox.Text == "Cheque")
            {
                if (_tipo == "Pagos") { return "Cheque ID°" + ChequeBox.Text; }
                return "Cheque ID°" + chequeIndex.ToString();
            }
            else
            {
                return FormaDEPagoBox.Text;
            }
        }

        private void PagarConChequeRestrincion()
        {
            if (CarCheuqeTxt.ForeColor == Color.Teal)
            {
                FechaCheque.Enabled = false;
                FechaCobro.Enabled = false;
                ChequeNum.Enabled = false;
                ChequeBanco.Enabled = false;
                ChequeImporte.Enabled = false;
                Recibido.Enabled = false;
            }
            else
            {
                FechaCheque.Enabled = true;
                FechaCobro.Enabled = true;
                ChequeNum.Enabled = true;
                ChequeBanco.Enabled = true;
                ChequeImporte.Enabled = true;
                Recibido.Enabled = true;
            }
        }

    }
}
