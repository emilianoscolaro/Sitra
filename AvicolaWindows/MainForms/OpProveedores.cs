﻿using AvicolaWindows.Data;
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
    public partial class OpProveedores : Explorador
    {
        public OpProveedores(string usrId,string usrlvl)
        {
            InitializeComponent();
            _usrId = usrId;
            _usrlvl = usrlvl;
        }



        private void FacturaBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(id))
            {
                Factura fc = new Factura(cliente, id, _usrId, "Proveedor");
                fc.Show();
            }
            else { MessageBox.Show("Debe seleccionar una operacion"); }
        }

        string cliente;
        string id;
        string total;
        string observaciones;
        string _usrId,_usrlvl;
        string moneda = "AR$";
        DateTime fechaToday = DateTime.Today;

        private void OpProveedores_Load(object sender, EventArgs e)
        {
            LoadGrid();
            OcultarIdCero(DtClientes);
            DtClientes.Columns[5].DefaultCellStyle.Format = moneda + "###,##0.00";
            UserRestriction(_usrlvl);
        }

        private void LoadGrid()
        {
            DtClientes.DataSource = LlenarDataOpProv("OpProveedores").Tables[0];
            DtClientes.Sort(DtClientes.Columns[0], ListSortDirection.Descending);
            DtClientes.Columns[0].Width = 60;
        }


        private void BuscarTxt_MouseDown(object sender, MouseEventArgs e)
        {
            BuscarTxt.SelectAll();
        }

        private void BuscarTxt_KeyUp(object sender, KeyEventArgs e)
        {
            BuscarOp(BuscarTxt, "OpProveedores", "ID", DtClientes);
            if (BuscarTxt.Text == "") { LoadGrid(); OcultarIdCero(DtClientes); }
            SumaTotal();
        }

        private void BuscarUsr_MouseDown(object sender, MouseEventArgs e)
        {
            BuscarUsr.SelectAll();
        }

        private void BuscarUsr_KeyUp(object sender, KeyEventArgs e)
        {
            BuscarOp(BuscarUsr, "OpProveedores", "Usuario", DtClientes);
            if (BuscarUsr.Text == "") { LoadGrid(); OcultarIdCero(DtClientes); }
            SumaTotal();
        }

        private void BuscarCliente_MouseDown(object sender, MouseEventArgs e)
        {
            BuscarCliente.SelectAll();
        }

        private void BuscarCliente_KeyUp(object sender, KeyEventArgs e)
        {
            BuscarOp(BuscarCliente, "OpProveedores", "Proveedor", DtClientes);
            if (BuscarCliente.Text == "") { LoadGrid(); OcultarIdCero(DtClientes); }
            SumaTotal();
        }

        private void BuscarObser_MouseDown(object sender, MouseEventArgs e)
        {
            BuscarObser.SelectAll();
        }

        private void BuscarObser_KeyUp(object sender, KeyEventArgs e)
        {
            BuscarOp(BuscarObser, "OpProveedores", "Observaciones", DtClientes);
            if (BuscarObser.Text == "") { LoadGrid(); OcultarIdCero(DtClientes); }
            SumaTotal();
        }

        private void DtClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cliente = Seleccionar(cliente, DtClientes, 3);
            id = Seleccionar(id, DtClientes, 0);
            total = Seleccionar(total, DtClientes, 5);
            observaciones = Seleccionar(observaciones, DtClientes, 4);
        }


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            BuscarPorFecha(dateTimePicker1, dateTimePicker2, DtClientes, "OpProveedores","Proveedor");
            SumaTotal();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            BuscarPorFecha(dateTimePicker1, dateTimePicker2, DtClientes, "OpProveedores", "Proveedor");
            SumaTotal();
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            LoadGrid();
            OcultarIdCero(DtClientes);
            SumaTotal();
        }

        private void EliminarBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(id))
            {
                if (observaciones != "Cancelado")
                {
                    string message = "¿Desea eliminar?";
                    string title = "Eliminar";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, buttons);
                    if (result == DialogResult.Yes)
                    {
                        string cmd = string.Format("EXEC EliminarOpProv '{0}','{1}'", id,total);
                        Utilidades.Ejecutar(cmd);
                        string cmdcuenta = string.Format("EXEC OpProvCuentaCancel '{0}','{1}'", cliente, total);
                        Utilidades.Ejecutar(cmdcuenta);
                        ActualizarInv();
                        LoadGrid();
                        OcultarIdCero(DtClientes);
                    }
                }
                else { MessageBox.Show("La operacion ya esta cancelada"); }
            }
            else { MessageBox.Show("Debe seleccionar una operacion"); }


            
        }

        private void ActualizarInv()
        {
            string cmd = String.Format("SELECT  Articulo1,Articulo2,Articulo3,Articulo4,Articulo5,Articulo6, Articulo7, Articulo8, Articulo9, Articulo10," +
                " Articulo11, Articulo12, Articulo13, Articulo14, Articulo15,Cant1, Cant2, Cant3, Cant4, Cant5, Cant6, Cant7, Cant8, Cant9, Cant10, Cant11," +
                " Cant12, Cant13, Cant14, Cant15          FROM OpProveedores where ID ='" + id + "'");
            DataSet ds = Utilidades.Ejecutar(cmd);
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
            string art13 = ds.Tables[0].Rows[0]["Articulo13"].ToString();
            string art14 = ds.Tables[0].Rows[0]["Articulo14"].ToString();
            string art15 = ds.Tables[0].Rows[0]["Articulo15"].ToString();
            string cant1 = ds.Tables[0].Rows[0]["Cant1"].ToString();
            string cant2 = ds.Tables[0].Rows[0]["Cant2"].ToString();
            string cant3 = ds.Tables[0].Rows[0]["Cant3"].ToString();
            string cant4 = ds.Tables[0].Rows[0]["Cant4"].ToString();
            string cant5 = ds.Tables[0].Rows[0]["Cant5"].ToString();
            string cant6 = ds.Tables[0].Rows[0]["Cant6"].ToString();
            string cant7 = ds.Tables[0].Rows[0]["Cant7"].ToString();
            string cant8 = ds.Tables[0].Rows[0]["Cant8"].ToString();
            string cant9 = ds.Tables[0].Rows[0]["Cant9"].ToString();
            string cant10 = ds.Tables[0].Rows[0]["Cant10"].ToString();
            string cant11 = ds.Tables[0].Rows[0]["Cant11"].ToString();
            string cant12 = ds.Tables[0].Rows[0]["Cant12"].ToString();
            string cant13 = ds.Tables[0].Rows[0]["Cant13"].ToString();
            string cant14 = ds.Tables[0].Rows[0]["Cant14"].ToString();
            string cant15 = ds.Tables[0].Rows[0]["Cant15"].ToString();

            string cmd2 = string.Format("EXEC OpProvInvCancel '{0}', '{1}','{2}'", art1, cant1, fechaToday);
            string cmd3 = string.Format("EXEC OpProvInvCancel '{0}', '{1}','{2}'", art2, cant2, fechaToday);
            string cmd4 = string.Format("EXEC OpProvInvCancel '{0}', '{1}','{2}'", art3, cant3, fechaToday);
            string cmd5 = string.Format("EXEC OpProvInvCancel '{0}', '{1}','{2}'", art4, cant4, fechaToday);
            string cmd6 = string.Format("EXEC OpProvInvCancel '{0}', '{1}','{2}'", art5, cant5, fechaToday);
            string cmd7 = string.Format("EXEC OpProvInvCancel '{0}', '{1}','{2}'", art6, cant6, fechaToday);
            string cmd8 = string.Format("EXEC OpProvInvCancel '{0}', '{1}','{2}'", art7, cant7, fechaToday);
            string cmd9 = string.Format("EXEC OpProvInvCancel '{0}', '{1}','{2}'", art8, cant8, fechaToday);
            string cmd10 = string.Format("EXEC OpProvInvCancel '{0}', '{1}','{2}'", art9, cant9, fechaToday);
            string cmd11 = string.Format("EXEC OpProvInvCancel '{0}', '{1}','{2}'", art10, cant10, fechaToday);
            string cmd12 = string.Format("EXEC OpProvInvCancel '{0}', '{1}','{2}'", art11, cant11, fechaToday);
            string cmd13 = string.Format("EXEC OpProvInvCancel '{0}', '{1}','{2}'", art12, cant12, fechaToday);
            string cmd14 = string.Format("EXEC OpProvInvCancel '{0}', '{1}','{2}'", art13, cant13, fechaToday);
            string cmd15 = string.Format("EXEC OpProvInvCancel '{0}', '{1}','{2}'", art14, cant14, fechaToday);
            string cmd16 = string.Format("EXEC OpProvInvCancel '{0}', '{1}','{2}'", art15, cant15, fechaToday);
            Utilidades.Ejecutar(cmd2);
            Utilidades.Ejecutar(cmd3);
            Utilidades.Ejecutar(cmd4);
            Utilidades.Ejecutar(cmd5);
            Utilidades.Ejecutar(cmd6);
            Utilidades.Ejecutar(cmd7);
            Utilidades.Ejecutar(cmd8);
            Utilidades.Ejecutar(cmd9);
            Utilidades.Ejecutar(cmd10);
            Utilidades.Ejecutar(cmd11);
            Utilidades.Ejecutar(cmd12);
            Utilidades.Ejecutar(cmd13);
            Utilidades.Ejecutar(cmd14);
            Utilidades.Ejecutar(cmd15);
            Utilidades.Ejecutar(cmd16);



        }

        private void SumaTotal()
        {
            double total = 0;
            foreach (DataGridViewRow row in DtClientes.Rows)
            {
                total += Convert.ToDouble(row.Cells["Total"].Value);
            }
            TotalTkt.Text = "AR$ " + string.Format("{0:n}", total);

        }

        private void ExelBtn_Click(object sender, EventArgs e)
        {
            ExportarExel(DtClientes, "Operaciones de Compra");
        }



        private void DtClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!string.IsNullOrEmpty(id))
            {
                Factura fc = new Factura(cliente, id, _usrId, "Proveedor");
                fc.Show();
            }
            else { MessageBox.Show("Debe seleccionar una operacion"); }
        }
    }



}
