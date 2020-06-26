using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AvicolaWindows.Models;
using AvicolaWindows.DataStorge;

namespace AvicolaWindows
{
    public partial class CrearUsuario : Form
    {
        public CrearUsuario()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            Users nuevoUsuario = new Users();
            nuevoUsuario.Name = UserEntry.Text;
            nuevoUsuario.Pasword = PassEntry.Text;
            
        }
    }
}
