using AvicolaWindows.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        ImagenBd bd = new ImagenBd();
        bool hayFoto;
        string ruta;


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

        private void ClienteTxt_MouseDown(object sender, MouseEventArgs e)
        {
            ClienteTxt.ForeColor = Color.Teal;
            ProveedorText.ForeColor = Color.Gray;
            ClienteProvBox.DataSource = Utilidades.EjecutaListPagosCob("LlenarComboCliente");
            ClienteProvBox.DisplayMember = "Alias";
        }

        private void ProveedorText_MouseDown(object sender, MouseEventArgs e)
        {
            ProveedorText.ForeColor = Color.Teal;
            ClienteTxt.ForeColor = Color.Gray;
            ClienteProvBox.DataSource = Utilidades.EjecutaListPagosCob("LlenarComboProvedores");
            ClienteProvBox.DisplayMember = "Alias";
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




        private void AgregarBtn_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(ClienteProvBox.Text) && !string.IsNullOrEmpty(ImporteTxt.Text))
            {
                try
                {
                    IngresodePagoCobro();
                    InsertarDatosPagoCob();
                    MessageBox.Show("Ingresado correnctamente");
                    ClienteProvBox.Text = "";
                    FormaDEPagoBox.Text = "";
                    ImporteTxt.Text = "";
                    ObservacionesTxt.Text = "";
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
            else { MessageBox.Show("Debe ingresar los datos del Cliente/Proveedor e Importe"); }



        }



        private void button1_Click(object sender, EventArgs e)
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

        private void InsertarDatosPagoCob()
        {
            if (hayFoto == true)
            {
                bd.InsertarImagen(_tipo, index, FechaTxt.Text, _usr, ClienteProvBox.Text, FormaDEPagoBox.Text, ImporteTxt.Text, ObservacionesTxt.Text, pictureBox3,TipoDeClienteSeleccionado());
            }
            else
            {
                if (_tipo == "Pagos")
                {
                    string cmd = string.Format("EXEC NuevoPago '{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}'", index, FechaTxt.Text, _usr, ClienteProvBox.Text,
                        FormaDEPagoBox.Text, ImporteTxt.Text, ObservacionesTxt.Text,TipoDeClienteSeleccionado());
                    Utilidades.Ejecutar(cmd);
                }

                if (_tipo == "Cobranzas")
                {
                    string cmd = string.Format("EXEC NuevaCobranza '{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}'", index, FechaTxt.Text, _usr, ClienteProvBox.Text,
                      FormaDEPagoBox.Text, ImporteTxt.Text, ObservacionesTxt.Text, TipoDeClienteSeleccionado());
                    Utilidades.Ejecutar(cmd);

                }
            }
        }

        private void SeleccionarRuta()
        {
            string cmd = string.Format("SELECT RutaImagenes from Usuarios where ID = " + _usrId + "");
            DataSet ds = Utilidades.Ejecutar(cmd);
            ruta = ds.Tables[0].Rows[0]["RutaImagenes"].ToString();
        }
    }
}
