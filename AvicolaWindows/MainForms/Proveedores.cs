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
    public partial class Proveedores : Explorador
    {
        public Proveedores(string usuario,string usrlvl,string usrId)
        {
            InitializeComponent();
            _usuario = usuario;
            _usrlvl = usrlvl;
            _usrId = usrId;
        }

        string id, alias, nombre, apellido, local, direc, email, tel, cuit ,cuenta,_usrlvl,_usrId;
        string _usuario;
        string moneda = "AR$";


        private void Proveedores_Load(object sender, EventArgs e)
        {
            LoadGrid();
            SumaTotal();
            OcultarIdCero(DtClientes);
            DtClientes.Columns[9].DefaultCellStyle.Format = moneda + "###,##0.00";
            UserRestriction(_usrlvl);
        }



        private void NuevaOpBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(id))
            {
                CrearOperacion op = new CrearOperacion(alias, tipo, _usuario);
                op.Show();
            }
            else { MessageBox.Show("Debe seleccionar un Proveedor"); }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void DtClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (!string.IsNullOrEmpty(id))
            {
                DetalleCuenta detalle = new DetalleCuenta(alias,_usrId);
                detalle.Show();
            }
            else { MessageBox.Show("Debe seleccionar un cliente"); }
        }

        private void ExelBtn_Click(object sender, EventArgs e)
        {
            ExportarExel(DtClientes, "Proveedores");
        }



        private void EditaBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(id))
            {
                EditarClientes ed = new EditarClientes(tipo, id, alias, nombre, apellido, local, direc, email, tel, cuit);
                ed.Show();
            }
            else { MessageBox.Show("Debe seleccionar un Proveedor"); }
        }

        private void EditaBtn_MouseEnter(object sender, EventArgs e)
        {
            EditaBtn.Size = EditaBtn.Size + new Size(14, 4);
        }

        private void EditaBtn_MouseLeave(object sender, EventArgs e)
        {
            EditaBtn.Size = EditaBtn.Size - new Size(14, 4);
        }

        private void BuscarTxt_MouseDown(object sender, MouseEventArgs e)
        {
            BuscarTxt.SelectAll();
        }

        private void BuscarTxt_KeyUp(object sender, KeyEventArgs e)
        {
            Buscar(BuscarTxt, "Proveedores", "Alias", DtClientes);
            if (BuscarTxt.Text == "") { LoadGrid(); OcultarIdCero(DtClientes); SumaTotal(); }
            SumaTotal();
        }

        string tipo = "Proveedor";

 



        private void DtClientes_CellClick_1(object sender, DataGridViewCellEventArgs e)
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

        private void VerBtn_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(id))
            {
                DetalleCuenta detalle = new DetalleCuenta(alias, _usrId);
                detalle.Show();
            }
            else { MessageBox.Show("Debe seleccionar un cliente"); }
        }

        private void EliminarBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(id))
            {
                if (cuenta == "0")
                {
                    Eliminar("EliminarProveedor", id, DtClientes, "Proveedores");
                }
                else { MessageBox.Show("No se puede eliminar un proveedor con saldo"); }
                LoadGrid();
                OcultarIdCero(DtClientes);
                SumaTotal();
            }
            else { MessageBox.Show("Debe seleccionar un Proveedor"); }

        }

        private void pictureBox1_MouseUp_1(object sender, MouseEventArgs e)
        {
            
        }

        private void pictureBox1_MouseDown_1(object sender, MouseEventArgs e)
        {
            LoadGrid();
            OcultarIdCero(DtClientes);
            
        }



        private void LoadGrid()
        {
            DtClientes.DataSource = LlenarDataGrid("Proveedores").Tables[0];
            this.DtClientes.Columns["Nombre"].Visible = false;
            this.DtClientes.Columns["Apellido"].Visible = false;
            this.DtClientes.Columns["CUIT"].Visible = false;
            this.DtClientes.Columns["Telefono"].Visible = false;
            this.DtClientes.Columns["E-mail"].Visible = false;
            DtClientes.Sort(DtClientes.Columns[0], ListSortDirection.Descending);
            DtClientes.Columns[0].Width = 60;

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
