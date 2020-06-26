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
using System.Data.SqlClient;
using System.IO;
using System.Data.Common;

namespace AvicolaWindows.Base
{
    public partial class Foto : Form
    {
        public Foto(string id ,string tipo)
        {
            InitializeComponent();
            _id = id;
            _tipo = tipo;
        }

        string _id,_tipo;
        ImagenBd bd = new ImagenBd();


        private void Foto_Load(object sender, EventArgs e)
        {

            bd.VerImagen(_tipo, _id,pictureBox1);
            pictureBox1.Size = pictureBox1.BackgroundImage.Size;
            this.MinimumSize = pictureBox1.BackgroundImage.Size;
            this.MaximumSize = pictureBox1.BackgroundImage.Size;

        }




    }
}
