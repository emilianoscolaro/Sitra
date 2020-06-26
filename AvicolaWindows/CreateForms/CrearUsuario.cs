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


namespace AvicolaWindows
{
    public partial class CrearUsuario : Form
    {
        public CrearUsuario()
        {
            InitializeComponent();
        }

        int index;
        string nivel;

        private void Guardar()
        {
            try
            {
                string cmddos = String.Format("SELECT top(1) * FROM Usuarios order by ID desc ");
                DataSet ds = Utilidades.Ejecutar(cmddos);
                string num = ds.Tables[0].Rows[0]["ID"].ToString();
                Int32.TryParse(num, out index);
                index = index + 1;


                string cmd = string.Format("EXEC CrearUsuario '{0}','{1}','{2}','{3}','{4}','{5}'", Entry1.Text.Trim(), Entry2.Text.Trim(), Entry4.Text.Trim(), Entry5.Text.Trim(),index,nivel);
                Utilidades.Ejecutar(cmd);
                MessageBox.Show("Usuario creado");
                Entry1.Text = "";
                Entry4.Text = "";
                Entry5.Text = "";
                Entry2.Text = "";
                Entry3.Text = "";
            }

            catch (Exception error)
            {
                MessageBox.Show(error.Message);
               
            }
        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Entry1.Text) || string.IsNullOrEmpty(Entry2.Text) || (checkBox1.Checked==false && checkBox2.Checked == false && checkBox3.Checked == false))
            {
                MessageBox.Show("Los datos de Usuario,Contraseña y Nivel son necesarios para crear el Usuario");
            }
            else
            {
                if (Entry2.Text == Entry3.Text && Entry2.Text != "")
                {
                    Guardar();
                    ErrorLabel.Visible = false;
                }
                else
                {
                    ErrorLabel.Visible = true;
                }
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                NivelTxt.Visible = true;
                nivel = "1";
                NivelTxt.Text = "*El nivel uno le permite al usuario visualizar los campos " +
                    ", crear operaciones y pagos.No le permite eliminar ni editarlos";
            }

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                checkBox1.Checked = false;
                checkBox3.Checked = false;
                NivelTxt.Visible = true;
                nivel = "2";
                NivelTxt.Text = "El nivel dos restringe solamente la opcion de eliminar cualquier elemento";
            }

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                checkBox2.Checked = false;
                checkBox1.Checked = false;
                NivelTxt.Visible = true;
                nivel = "3";
                NivelTxt.Text = "*El nivel tres le da acceso total al usuario";
            }

        }
    }
}
