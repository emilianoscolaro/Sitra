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
    public partial class CrearCliente : Form
    {
        public CrearCliente(string tipo)
        {
            InitializeComponent();
            _tipo = tipo;
            Titulotkt.Text = "Nuevo " + _tipo;
        }

        string _tipo;
        int index;
        float cuenta = 0;

        private void Guardar()
        {

            if (_tipo == "Cliente")
            {
                try
                {

                    string cmddos = String.Format("SELECT top(1) * FROM Clientes order by ID desc ");
                    DataSet ds = Utilidades.Ejecutar(cmddos);
                    string num = ds.Tables[0].Rows[0]["ID"].ToString();
                    Int32.TryParse(num, out index);
                    index = index + 1;
                    string cmd = string.Format("EXEC CrearCliente '{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}'", index, Entry1.Text.Trim(), Entry2.Text.Trim(), Entry3.Text.Trim(), Entry4.Text.Trim(), Entry5.Text.Trim(), EmailEntry.Text.Trim(), TelEntry.Text.Trim(), CuitEntry.Text.Trim(),cuenta);
                    Utilidades.Ejecutar(cmd);
                    MessageBox.Show("Cliente creado");
                    Entry1.Text = "";
                    Entry2.Text = "";
                    Entry3.Text = "";
                    Entry4.Text = "";
                    Entry5.Text = "";
                    EmailEntry.Text = "";
                    TelEntry.Text = "";
                    CuitEntry.Text = "";
                }

                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }


            if (_tipo == "Proveedor")
            {
                try
                {

                    string cmddos = String.Format("SELECT top(1) * FROM Proveedores order by ID desc ");
                    DataSet ds = Utilidades.Ejecutar(cmddos);
                    string num = ds.Tables[0].Rows[0]["ID"].ToString();
                    Int32.TryParse(num, out index);
                    index = index + 1;
                    string cmd = string.Format("EXEC CrearProveedor '{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}'", index, Entry1.Text.Trim(), Entry2.Text.Trim(), Entry3.Text.Trim(), Entry4.Text.Trim(), Entry5.Text.Trim(), EmailEntry.Text.Trim(), TelEntry.Text.Trim(), CuitEntry.Text.Trim(),cuenta);
                    Utilidades.Ejecutar(cmd);
                    MessageBox.Show("ok");
                    Entry1.Text = "";
                    Entry2.Text = "";
                    Entry3.Text = "";
                    Entry4.Text = "";
                    Entry5.Text = "";
                    EmailEntry.Text = "";
                    TelEntry.Text = "";
                    CuitEntry.Text = "";
                }

                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }

        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            Guardar();
        }
    }
}
