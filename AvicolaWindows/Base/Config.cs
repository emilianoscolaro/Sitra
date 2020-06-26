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

namespace AvicolaWindows.Base
{
    public partial class Config : Form
    {
        public Config(string id)
        {
            InitializeComponent();
            _id = id;
        }

        string _id;


        private void Config_Load(object sender, EventArgs e)
        {
            string cmd = string.Format("SELECT * from Empresa where [Nombre Empresa] = 'Avicola la gaucha'");
            DataSet ds = Utilidades.Ejecutar(cmd);
            string nom = ds.Tables[0].Rows[0]["Nombre Empresa"].ToString();
            string raz = ds.Tables[0].Rows[0]["RazonSocial"].ToString();
            string dir = ds.Tables[0].Rows[0]["Direccion"].ToString();
            string loc = ds.Tables[0].Rows[0]["Localidad"].ToString();
            string email = ds.Tables[0].Rows[0]["Email"].ToString();
            string tel = ds.Tables[0].Rows[0]["Tel."].ToString();
            string cuit = ds.Tables[0].Rows[0]["Cuit"].ToString();
            string ley = ds.Tables[0].Rows[0]["Leyenda"].ToString();

            string cmdos = string.Format("SELECT RutaDescargas,RutaImagenes from Usuarios where ID = " + _id+"");
            DataSet dss = Utilidades.Ejecutar(cmdos);
            string rd = dss.Tables[0].Rows[0]["RutaDescargas"].ToString();
            string ri = dss.Tables[0].Rows[0]["RutaImagenes"].ToString();

            NombrEntry.Text = nom;
            RazonSocialEntry.Text = raz;
            DirEntry.Text = dir;
            LocalEntry.Text = loc;
            EmailEntry.Text = email;
            TelEntry.Text = tel;
            CuitEntry.Text = cuit;
            LeyendaEntry.Text = ley;
            RDescargaText.Text = rd;
            RImagenText.Text = ri;
        }

        private void RazonEdit_Click(object sender, EventArgs e)
        {
            RazonSocialEntry.Enabled = true;
            RazonSocialEntry.Focus();
            RazonEdit.Visible = false;
        }

        private void LocalidadEdit_Click(object sender, EventArgs e)
        {
            LocalEntry.Enabled = true;
            LocalEntry.Focus();
            LocalidadEdit.Visible = false;
        }

        private void DirEdit_Click(object sender, EventArgs e)
        {
            DirEntry.Enabled = true;
            DirEntry.Focus();
            DirEdit.Visible = false;
        }

        private void EmailEdit_Click(object sender, EventArgs e)
        {
            EmailEntry.Enabled = true;
            EmailEntry.Focus();
            EmailEdit.Visible = false;
        }

        private void TelEdit_Click(object sender, EventArgs e)
        {
            TelEntry.Enabled = true;
            TelEntry.Focus();
            TelEdit.Visible = false;
        }

        private void CuitEdit_Click(object sender, EventArgs e)
        {
            CuitEntry.Enabled = true;
            CuitEntry.Focus();
            CuitEdit.Visible = false;
        }

        private void LeyendaEdit_Click(object sender, EventArgs e)
        {
            LeyendaEntry.Enabled = true;
            LeyendaEntry.Focus();
            LeyendaEdit.Visible = false;
        }

        private void GuardarBtn_Click(object sender, EventArgs e)
        {
            string cmd = string.Format("EXEC EditarDatosEmpresa '{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}'", NombrEntry.Text, RazonSocialEntry.Text, LocalEntry.Text,
                DirEntry.Text, EmailEntry.Text, TelEntry.Text, CuitEntry.Text, LeyendaEntry.Text);
            Utilidades.Ejecutar(cmd);
            string cmdos = string.Format("EXEC CambiarRutas '{0}','{1}','{2}'", _id, RDescargaText.Text.Trim(), RImagenText.Text.Trim());
            Utilidades.Ejecutar(cmdos);
        }

        private void RDescargaBtn_Click(object sender, EventArgs e)
        {
            using (var folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    RDescargaText.Text = folderDialog.SelectedPath;
                }
            }
        }

        private void RImagenBtn_Click(object sender, EventArgs e)
        {
            using (var folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    RImagenText.Text = folderDialog.SelectedPath;
                }
            }
        }


    }
}
