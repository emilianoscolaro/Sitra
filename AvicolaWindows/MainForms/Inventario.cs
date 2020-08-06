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
    public partial class Inventario : Explorador
    {
        public Inventario(string usrlvl)
        {
            InitializeComponent();
            _usrlvl = usrlvl;
        }


        string stock,id,_usrlvl,descripcion,articulo;

        private void BuscarBtn_Click(object sender, EventArgs e)
        {
            Buscar(BuscarTxt, "Inventario", "Artuculo", DtClientes);
            
        }

        private void Inventario_Load(object sender, EventArgs e)
        {
            LoadGrid();
            OcultarIdCero(DtClientes);
            UserRestriction(_usrlvl);
        }

        private void EliminarBtn_Click(object sender, EventArgs e)
        {
            if(stock == "0")
            {
                Eliminar("EliminarInventario", id, DtClientes, "Inventario");
            }
            else { MessageBox.Show("No se puede eliminar un articulo con Stock"); }
            LoadGrid();
            OcultarIdCero(DtClientes);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            LoadGrid();
            OcultarIdCero(DtClientes);
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
        }

        private void DtClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Seleccionar(id, DtClientes, 0);
            articulo = Seleccionar(articulo, DtClientes, 1);
            stock = Seleccionar(stock, DtClientes, 3);
            descripcion = Seleccionar(descripcion, DtClientes, 2);

        }

        private void BuscarTxt_MouseDown(object sender, MouseEventArgs e)
        {
            BuscarTxt.SelectAll();
        }

        private void ExelBtn_Click(object sender, EventArgs e)
        {
            ExportarExel(DtClientes, "Inventario");
        }

        private void NuevaOpBtn_Click(object sender, EventArgs e)
        {
            InventarioHistorico nuevoForm = new InventarioHistorico();
            nuevoForm.Show();
        }

        private void VerBtn_Click(object sender, EventArgs e)
        {
            EditInventario ed = new EditInventario(id,descripcion,articulo);
            ed.Show();
        }

        private void DtClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditInventario ed = new EditInventario(id,descripcion,articulo);
            ed.Show();
        }


        // Cambiar Color Stock
        // private void DtClientes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        // {
        //     if (this.DtClientes.Columns[e.ColumnIndex].Name == "Stock")
        //     {
        //         if(Convert.ToInt32(e.Value) <= 30)
        //         {
        //             e.CellStyle.ForeColor = Color.Red;
        //         }
        //     }
        // }



        private void BuscarTxt_KeyUp(object sender, KeyEventArgs e)
        {
            Buscar(BuscarTxt, "Inventario", "Articulo", DtClientes);
            if (BuscarTxt.Text == "") { LoadGrid(); OcultarIdCero(DtClientes); }
        }

        private void LoadGrid()
        {
            DtClientes.DataSource = LlenarDataGrid("Inventario").Tables[0];
            DtClientes.Columns[0].Width = 60;
            DtClientes.Sort(DtClientes.Columns[0], ListSortDirection.Descending);
        }
    }
}
