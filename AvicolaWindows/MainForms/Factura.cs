using AvicolaWindows.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AvicolaWindows
{
    public partial class Factura : Form
    {
        public Factura(string cliente,string id,string usrId, string tipo)
        {
            InitializeComponent();

            _cliente = cliente;
            _id = id;
            _usrId = usrId;
            _tipo = tipo;
        }

        string _cliente;
        string _id,_usrId;
        string ruta;
        string _tipo;
        string _tipoOp;

        private void SeleccionarTabla()
        {
            if (_tipo == "Proveedor") { _tipoOp = "OpProveedores"; }
            if (_tipo == "Cliente") { _tipoOp = "OpClientes"; }
        }

        private void Factura_Load(object sender, EventArgs e)
        {
            SeleccionarTabla();
            CargarDatosEmpresa();
            CargarDatosCliente();
            SeleccionarRuta();
            CargarDatosOp();
            sVisibles(Val2);
            sVisibles(Val3);
            sVisibles(Val4);
            sVisibles(Val5);
            sVisibles(Val6);
            sVisibles(Val7);
            sVisibles(Val8);
            sVisibles(Val9);
            sVisibles(Val10);
            sVisibles(Val11);
            sVisibles(Val12);
            sVisibles(Cant2);
            sVisibles(Cant3);
            sVisibles(Cant4);
            sVisibles(Cant5);
            sVisibles(Cant6);
            sVisibles(Cant7);
            sVisibles(Cant8);
            sVisibles(Cant9);
            sVisibles(Cant10);
            sVisibles(Cant11);
            sVisibles(Cant12);



        }

        public void CargarDatosEmpresa()
        {
            string cmddos = String.Format("SELECT * FROM Empresa  ");
            DataSet ds = Utilidades.Ejecutar(cmddos);
            string num = ds.Tables[0].Rows[0]["Localidad"].ToString();
            string dom = ds.Tables[0].Rows[0]["Direccion"].ToString();
            string Email = ds.Tables[0].Rows[0]["Email"].ToString();
            string tel = ds.Tables[0].Rows[0]["Tel."].ToString();
            string Cuit = ds.Tables[0].Rows[0]["Cuit"].ToString();
            string ley = ds.Tables[0].Rows[0]["Leyenda"].ToString();
            LocalidadTxt.Text = num;
            DireccionTxt.Text = dom;
            EmailTxt.Text = Email;
            TelTxt.Text = tel;
            CuitTxt.Text = Cuit;
            LeyendaTxt.Text = ley;
        }

        public void CargarDatosCliente()
        {

            if(_tipo == "Cliente")
            {
                try
                {
                    string cmd = String.Format("SELECT Alias , Direccion , Localidad ,Telefono ,CUIT FROM Clientes where Alias ='" + _cliente + "'");
                    DataSet ds = Utilidades.Ejecutar(cmd);
                    string num = ds.Tables[0].Rows[0]["Alias"].ToString();
                    string dir = ds.Tables[0].Rows[0]["Direccion"].ToString();
                    string loc = ds.Tables[0].Rows[0]["Localidad"].ToString();
                    string tel = ds.Tables[0].Rows[0]["Telefono"].ToString();
                    string cuit = ds.Tables[0].Rows[0]["CUIT"].ToString();
                    ClienteNomTxt.Text = num;
                    ClienteDirTxt.Text = dir;
                    ClienteLocTxt.Text = loc;
                    ClienteTelTxt.Text = tel;
                    ClienteCuitTxt.Text = cuit;
                }
                catch (Exception)
                {
                    string cmd = String.Format("SELECT Cliente FROM OpClientes where Cliente ='" + _cliente + "'");
                    DataSet ds = Utilidades.Ejecutar(cmd);
                    string num = ds.Tables[0].Rows[0]["Cliente"].ToString();
                    ClienteNomTxt.Text = num;
                    ClienteDirTxt.Text = "";
                    ClienteLocTxt.Text = "";
                    ClienteTelTxt.Text = "";
                    ClienteCuitTxt.Text = "";
                }
            }
            if (_tipo == "Proveedor")
            {
                try
                {
                    string cmd = String.Format("SELECT Alias , Direccion , Localidad ,Telefono ,CUIT FROM Proveedores where Alias ='" + _cliente + "'");
                    DataSet ds = Utilidades.Ejecutar(cmd);
                    string num = ds.Tables[0].Rows[0]["Alias"].ToString();
                    string dir = ds.Tables[0].Rows[0]["Direccion"].ToString();
                    string loc = ds.Tables[0].Rows[0]["Localidad"].ToString();
                    string tel = ds.Tables[0].Rows[0]["Telefono"].ToString();
                    string cuit = ds.Tables[0].Rows[0]["CUIT"].ToString();
                    ClienteNomTxt.Text = num;
                    ClienteDirTxt.Text = dir;
                    ClienteLocTxt.Text = loc;
                    ClienteTelTxt.Text = tel;
                    ClienteCuitTxt.Text = cuit;
                }
                catch (Exception)
                {
                    string cmd = String.Format("SELECT Proveedor FROM OpProveedores where Proveedor ='" + _cliente + "'");
                    DataSet ds = Utilidades.Ejecutar(cmd);
                    string num = ds.Tables[0].Rows[0]["Proveedor"].ToString();
                    ClienteNomTxt.Text = num;
                    ClienteDirTxt.Text = "";
                    ClienteLocTxt.Text = "";
                    ClienteTelTxt.Text = "";
                    ClienteCuitTxt.Text = "";
                }
            }


        }

        private void CargarDatosOp()
        {
            string cmd = String.Format("SELECT ID,Usuario,fecha,"+ _tipo+",Articulo1,Articulo2,Articulo3,Articulo4,Articulo5,Articulo6, Articulo7, Articulo8," +
                " Articulo9, Articulo10, Articulo11, Articulo12, Articulo13, Articulo14, Articulo15,Cant1, Cant2, Cant3, Cant4, Cant5, Cant6, Cant7, Cant8," +
                " Cant9, Cant10, Cant11, Cant12, Cant13, Cant14, Cant15, Observaciones, Total,Val1, Val2, Val3, Val4, Val5, Val6, Val7, Val8, Val9, Val10," +
                " Val11, Val12, Val13, Val14, Val15 FROM " +_tipoOp + " where ID ='"+ _id+"'");
            DataSet ds = Utilidades.Ejecutar(cmd);
            string id = ds.Tables[0].Rows[0]["ID"].ToString();
            string fech = ds.Tables[0].Rows[0]["fecha"].ToString();
            string art1 = ds.Tables[0].Rows[0]["Articulo1"].ToString();
            string art2 = ds.Tables[0].Rows[0]["Articulo2"].ToString();
            string art3 = ds.Tables[0].Rows[0]["Articulo3"].ToString();
            string art4 = ds.Tables[0].Rows[0]["Articulo4"].ToString();
            string art5 = ds.Tables[0].Rows[0]["Articulo5"].ToString();
            string art6 = ds.Tables[0].Rows[0]["Articulo6"].ToString();
            string art7 = ds.Tables[0].Rows[0]["Articulo7"].ToString();
            string art8 = ds.Tables[0].Rows[0]["Articulo8"].ToString();
            string art9 = ds.Tables[0].Rows[0]["Articulo9"].ToString();
            string art10 = ds.Tables[0].Rows[0]["Articulo10"].ToString();
            string art11 = ds.Tables[0].Rows[0]["Articulo11"].ToString();
            string art12 = ds.Tables[0].Rows[0]["Articulo12"].ToString();
            string cant1 = ds.Tables[0].Rows[0]["Cant1"].ToString();
            string cant3 = ds.Tables[0].Rows[0]["Cant3"].ToString();
            string cant2 = ds.Tables[0].Rows[0]["Cant2"].ToString();
            string cant4 = ds.Tables[0].Rows[0]["Cant4"].ToString();
            string cant5 = ds.Tables[0].Rows[0]["Cant5"].ToString();
            string cant6 = ds.Tables[0].Rows[0]["Cant6"].ToString();
            string cant7 = ds.Tables[0].Rows[0]["Cant7"].ToString();
            string cant8 = ds.Tables[0].Rows[0]["Cant8"].ToString();
            string cant9 = ds.Tables[0].Rows[0]["Cant9"].ToString();
            string cant10 = ds.Tables[0].Rows[0]["Cant10"].ToString();
            string cant11 = ds.Tables[0].Rows[0]["Cant11"].ToString();
            string cant12 = ds.Tables[0].Rows[0]["Cant12"].ToString();
            string val1 = ds.Tables[0].Rows[0]["Val1"].ToString();
            string val2 = ds.Tables[0].Rows[0]["Val2"].ToString();
            string val3 = ds.Tables[0].Rows[0]["Val3"].ToString();
            string val4 = ds.Tables[0].Rows[0]["Val4"].ToString();
            string val5 = ds.Tables[0].Rows[0]["Val5"].ToString();
            string val6 = ds.Tables[0].Rows[0]["Val6"].ToString();
            string val7 = ds.Tables[0].Rows[0]["Val7"].ToString();
            string val8 = ds.Tables[0].Rows[0]["Val8"].ToString();
            string val9 = ds.Tables[0].Rows[0]["Val9"].ToString();
            string val10 = ds.Tables[0].Rows[0]["Val10"].ToString();
            string val11 = ds.Tables[0].Rows[0]["Val11"].ToString();
            string val12 = ds.Tables[0].Rows[0]["Val12"].ToString();
            string total = ds.Tables[0].Rows[0]["Total"].ToString();
            OpNumTxt.Text = id;
            if (fech.Length == 17) { FechaTxt.Text = fech.Remove(8, 9); }
            if (fech.Length == 18) { FechaTxt.Text = fech.Remove(9, 9); }
            if (fech.Length == 19) { FechaTxt.Text = fech.Remove(10, 9); }
            Art1.Text = art1;
            Art2.Text = art2;
            Art3.Text = art3;
            Art4.Text = art4;
            Art5.Text = art5;
            Art6.Text = art6;
            Art7.Text = art7;
            Art8.Text = art8;
            Art9.Text = art9;
            Art10.Text = art10;
            Art11.Text = art11;
            Art12.Text = art12;
            Cant1.Text = cant1;
            Cant2.Text = cant2;
            Cant3.Text = cant3;
            Cant4.Text = cant4;
            Cant5.Text = cant5;
            Cant6.Text = cant6;
            Cant7.Text = cant7;
            Cant8.Text = cant8;
            Cant9.Text = cant9;
            Cant10.Text = cant10;
            Cant11.Text = cant11;
            Cant12.Text = cant12;
            Val1.Text = val1;
            Val2.Text = val2;
            Val3.Text = val3;
            Val4.Text = val4;
            Val5.Text = val5;
            Val6.Text = val6;
            Val7.Text = val7;
            Val8.Text = val8;
            Val9.Text = val9;
            Val10.Text = val10;
            Val11.Text = val11;
            Val12.Text = val12;
            float totalf = float.Parse(total);
            TotalTxt.Text = "AR$." +string.Format("{0:0,0}", totalf) ;

        }

        private void sVisibles(Label texto)
        {
            if(texto.Text == "0")
            {
                texto.Visible = false;
            }
            else { texto.Visible = true; }
        }

  
        private void SeleccionarRuta()
        {
            string cmd = string.Format("SELECT RutaDescargas from Usuarios where ID = " + _usrId + "");
            DataSet ds = Utilidades.Ejecutar(cmd);
            ruta = ds.Tables[0].Rows[0]["RutaDescargas"].ToString();
        }


        private void button1_Click(object sender, EventArgs e)
        {

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.InitialDirectory = ruta;
            dialog.FileName = "Recibo " + _tipo +" n° " + OpNumTxt.Text;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                
                pictureBox3.BringToFront();
                pictureBox4.BringToFront();
                pictureBox5.BringToFront();
                pictureBox6.BringToFront();
                Logo.BringToFront();
                pictureBox1.BringToFront();
                pictureBox24.BringToFront();
                int width = Convert.ToInt32(ImgPanel.Width);
                int height = Convert.ToInt32(ImgPanel.Height);
                Bitmap bmp = new Bitmap(width, height);
                ImgPanel.DrawToBitmap(bmp, new Rectangle(0, 0, width, height));
                bmp.Save(dialog.FileName+".Png", ImageFormat.Png);
            }


            pictureBox1.SendToBack();
            Logo.SendToBack();
            pictureBox3.SendToBack();
            pictureBox4.SendToBack();
            pictureBox5.SendToBack();
            pictureBox6.SendToBack();
        }




    }
}
