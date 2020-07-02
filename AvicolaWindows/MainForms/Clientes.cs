using AvicolaWindows.Data;
using AvicolaWindows.EditForms;
using AvicolaWindows.MainForms;
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
    public partial class Clientes : Explorador
    {
        public Clientes(string usuario,string usrlvl)
        {
            InitializeComponent();
            _usuario = usuario;
            _usrlvl = usrlvl;
        }

        string id, alias, nombre, apellido, local, direc, email, tel, cuit,cuenta,_usrlvl;
        string _usuario;
        string moneda = "AR$";

        private void Clientes_Load(object sender, EventArgs e)
        {
            LoadGrid();
            OcultarIdCero(DtClientes);
            SumaTotal();
            this.Opacity = 0;
            DtClientes.Columns[9].DefaultCellStyle.Format = moneda + "###,##0.00";
            UserRestriction(_usrlvl);
            

        }



        private void BuscarTxt_KeyUp(object sender, KeyEventArgs e)
        {
            Buscar(BuscarTxt, "Clientes", "Alias", DtClientes);
            if (BuscarTxt.Text == "") { LoadGrid();OcultarIdCero(DtClientes);SumaTotal(); }
            SumaTotal();
        }

        private void BuscarTxt_MouseDown(object sender, MouseEventArgs e)
        {
            BuscarTxt.SelectAll();
        }


        private void NuevaOpBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(id))
            {
                CrearOperacion op = new CrearOperacion(alias, tipo, _usuario);
                op.Show();
            }
            else { MessageBox.Show("Debe seleccionar un cliente"); }
        }

        private void ExelBtn_Click(object sender, EventArgs e)
        {
            ExportarExel(DtClientes,tipo);
        }


        private void EditaBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(id))
            {
                EditarClientes ed = new EditarClientes(tipo, id, alias, nombre, apellido, local, direc, email, tel, cuit);
                ed.Show();
            }
            else { MessageBox.Show("Debe seleccionar un cliente"); }
        }

        private void EditaBtn_MouseEnter(object sender, EventArgs e)
        {
            EditaBtn.Size = EditaBtn.Size + new Size(14, 4);
        }

        private void EditaBtn_MouseLeave(object sender, EventArgs e)
        {
            EditaBtn.Size = EditaBtn.Size - new Size(14, 4);
        }

        private void DtClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DetalleCuenta detalle = new DetalleCuenta(alias);
            detalle.Show();
        }



        string tipo = "Cliente";



        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            LoadGrid();
            OcultarIdCero(DtClientes);
            SumaTotal();
        }

        private void EliminarBtn_Click_1(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(id))
            {
                if (cuenta == "0")
                {
                    Eliminar("EliminarCliente", id, DtClientes, "Clientes");
                }
                else
                {
                    MessageBox.Show("No se puede eliminar un cliente con saldo");
                }
            }
            else { MessageBox.Show("Debe seleccionar un cliente"); }
            LoadGrid();
            OcultarIdCero(DtClientes);
            SumaTotal();
        }

        private void VerBtn_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(id))
            {
                DetalleCuenta detalle = new DetalleCuenta(alias);
                detalle.Show();
            }
            else { MessageBox.Show("Debe seleccionar un cliente"); }

        }

        private void DtClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Seleccionar(id, DtClientes, 0);
            alias = Seleccionar(alias, DtClientes, 1);
            nombre = Seleccionar(nombre, DtClientes, 2);
            apellido = Seleccionar(apellido, DtClientes, 3);
            local = Seleccionar(local, DtClientes, 4);
            direc = Seleccionar(direc, DtClientes, 5);
            email = Seleccionar(email, DtClientes, 6);
            tel = Seleccionar(tel, DtClientes, 7);
            cuit = Seleccionar(cuit, DtClientes, 8);
            cuenta = Seleccionar(cuenta, DtClientes, 9);
        }



        private void BuscarBtn_Click(object sender, EventArgs e)
        {
            
        }




        private void LoadGrid()
        {
            DtClientes.DataSource = LlenarDataGrid("Clientes").Tables[0];
            this.DtClientes.Columns["Nombre"].Visible = false;
            this.DtClientes.Columns["Apellido"].Visible = false;
            this.DtClientes.Columns["CUIT"].Visible = false;
            this.DtClientes.Columns["Telefono"].Visible = false;
            this.DtClientes.Columns["E-mail"].Visible = false;
            DtClientes.Columns[0].Width = 60;
            DtClientes.Sort(DtClientes.Columns[0], ListSortDirection.Descending);

        }


        private void SumaTotal()
        {
            double total = 0;
            foreach (DataGridViewRow row in DtClientes.Rows)
            {
                total += Convert.ToDouble(row.Cells["Cuenta"].Value);
            }
            TotalTkt.Text = "AR$ " + string.Format("{0:n}", total);
            
            
        }
    }
}
