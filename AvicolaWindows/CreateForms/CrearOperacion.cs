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
    public partial class CrearOperacion : Form
    {
        public CrearOperacion(string cliente,string tipo,string usuario)
        {
            InitializeComponent();
            _cliente = cliente;
            _tipo = tipo;
            _usuario = usuario;
        }

        int indexAgregar = 1;
        float a, b, c, d, e, f, g, h, i, j, k, l, m, n, o;
        string _cliente;
        string _tipo;
        int index;
        string _usuario;



        private void CrearOperacion_Load(object sender, EventArgs e)
        {

            Art1.DataSource = Utilidades.EjecutaList();
            Art1.DisplayMember = "Articulo";
            StartValues();

            FechaTxt.Text = DateTime.Now.ToShortDateString();
            TituloTxt.Text = "Operacion " + _tipo;
            NombreTxt.Text = _cliente;


            try
            {
                if (_tipo == "Cliente")
                {
                    string cmddos = String.Format("SELECT top(1) * FROM OpClientes order by ID desc ");
                    DataSet ds = Utilidades.Ejecutar(cmddos);
                    string num = ds.Tables[0].Rows[0]["ID"].ToString();
                    Int32.TryParse(num, out index);
                    index = index + 1;
                    OpId.Text = index.ToString();
                   
                }
                if (_tipo == "Proveedor")
                {
                    string cmddos = String.Format("SELECT top(1) * FROM OpProveedores order by ID desc ");
                    DataSet ds = Utilidades.Ejecutar(cmddos);
                    string num = ds.Tables[0].Rows[0]["ID"].ToString();
                    Int32.TryParse(num, out index);
                    index = index + 1;
                    OpId.Text = index.ToString();
                    
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }



            
        }


        private void CrearBtn_Click(object sender, EventArgs e)
        {


            if (_tipo == "Cliente")
            {
                try
                {
                    string cmd = string.Format("EXEC CrearOpCliente '{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14" +
                        "}','{15}','{16}','{17}','{18}','{19}','{20}','{21}','{22}','{23}','{24}','{25}','{26}','{27}','{28}','{29}','{30}','{31}','{32}','{33}','{34}','{35}'," +
                        "'{36}','{37}','{38}','{39}','{40}','{41}','{42}','{43}','{44}','{45}','{46}','{47}','{48}','{49}','{50}'",
                        index,_usuario,FechaTxt.Text,_cliente,Art1.Text,Art2.Text, Art3.Text, Art4.Text, Art5.Text, Art6.Text, Art7.Text, Art8.Text,Art9.Text,
                        Art10.Text, Art11.Text, Art12.Text, Art13.Text, Art14.Text, Art15.Text,Cant1.Text,Cant2.Text, Cant3.Text, Cant4.Text, Cant5.Text, Cant6.Text,
                        Cant7.Text, Cant8.Text, Cant9.Text, Cant10.Text, Cant11.Text, Cant12.Text, Cant13.Text, Cant14.Text, Cant15.Text,ObservacionesTxt.Text,TotalText.Text,
                        Val1.Text,Val2.Text, Val3.Text, Val4.Text, Val5.Text, Val6.Text, Val7.Text, Val8.Text, Val9.Text, Val10.Text, Val11.Text, Val12.Text, Val13.Text, Val14.Text, Val15.Text);
                    Utilidades.Ejecutar(cmd);
                    ActualizarInventario();
                    string cmdcuenta = string.Format("EXEC OpClienteCuenta '{0}','{1}'", _cliente, TotalText.Text);
                    Utilidades.Ejecutar(cmdcuenta);
                    this.Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }

            if(_tipo == "Proveedor")
            {
                try
                {
                    string cmd = string.Format("EXEC CrearOpProveedores '{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14" +
                        "}','{15}','{16}','{17}','{18}','{19}','{20}','{21}','{22}','{23}','{24}','{25}','{26}','{27}','{28}','{29}','{30}','{31}','{32}','{33}','{34}','{35}'," +
                        "'{36}','{37}','{38}','{39}','{40}','{41}','{42}','{43}','{44}','{45}','{46}','{47}','{48}','{49}','{50}'",
                        index, _usuario, FechaTxt.Text, _cliente, Art1.Text, Art2.Text, Art3.Text, Art4.Text, Art5.Text, Art6.Text, Art7.Text, Art8.Text, Art9.Text,
                        Art10.Text, Art11.Text, Art12.Text, Art13.Text, Art14.Text, Art15.Text, Cant1.Text, Cant2.Text, Cant3.Text, Cant4.Text, Cant5.Text, Cant6.Text,
                        Cant7.Text, Cant8.Text, Cant9.Text, Cant10.Text, Cant11.Text, Cant12.Text, Cant13.Text, Cant14.Text, Cant15.Text, ObservacionesTxt.Text, TotalText.Text,
                        Val1.Text, Val2.Text, Val3.Text, Val4.Text, Val5.Text, Val6.Text, Val7.Text, Val8.Text, Val9.Text, Val10.Text, Val11.Text, Val12.Text, Val13.Text, Val14.Text, Val15.Text);
                    Utilidades.Ejecutar(cmd);
                    ActualizarInvProv();
                    string cmdcuenta = string.Format("EXEC OpProvCuenta '{0}','{1}'", _cliente, TotalText.Text);
                    Utilidades.Ejecutar(cmdcuenta);
                    this.Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }


        }



        private void Val5_KeyUp(object sender, KeyEventArgs e)
        {
            Suma();
        }

        private void Val6_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void Val6_KeyUp(object sender, KeyEventArgs e)
        {
            Suma();
        }

        private void Val7_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void Val7_KeyUp(object sender, KeyEventArgs e)
        {
            Suma();
        }

        private void Val8_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void Val8_KeyUp(object sender, KeyEventArgs e)
        {
            Suma();
        }

        private void Val9_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void Val9_KeyUp(object sender, KeyEventArgs e)
        {
            Suma();
        }

        private void Val10_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void Val10_KeyUp(object sender, KeyEventArgs e)
        {
            Suma();
        }

        private void Val11_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void Val11_KeyUp(object sender, KeyEventArgs e)
        {
            Suma();
        }

        private void Val12_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void Val12_KeyUp(object sender, KeyEventArgs e)
        {
            Suma();
        }

        private void Val13_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void Val13_KeyUp(object sender, KeyEventArgs e)
        {
            Suma();
        }

        private void Val14_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void Val14_KeyUp(object sender, KeyEventArgs e)
        {
            Suma();
        }

        private void Val15_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void Val15_KeyUp(object sender, KeyEventArgs e)
        {
            Suma();
        }

        private void Cant1_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void Cant2_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void Cant3_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void Cant4_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void Cant5_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void Cant6_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void Cant7_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void Cant8_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void Cant9_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void Cant10_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void Cant11_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void Cant12_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void Cant13_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void Cant14_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }



        private void Cant15_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void Val5_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void Val4_KeyUp(object sender, KeyEventArgs e)
        {
            Suma();
        }

        private void Val4_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void Val3_KeyUp(object sender, KeyEventArgs e)
        {
            Suma();
        }

        private void Val3_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void Val2_KeyUp(object sender, KeyEventArgs e)
        {
            Suma();
        }

        private void Val2_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void Val1_KeyUp_1(object sender, KeyEventArgs e)
        {
            Suma();
        }

        private void Val1_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }




        float resultado;






        public void SoloNumeros(KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (e.KeyChar == '.')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }





        private void Agregar_Click(object sender, EventArgs e)
        {
            indexAgregar= indexAgregar +1;

            if(indexAgregar == 2)
            {
                Art2.DataSource = Utilidades.EjecutaList();
                Art2.DisplayMember = "Articulo";
                Art2.Visible = true;
                Art2.Focus();
                Cant2.Visible = true;
                Val2.Visible = true;
                
            }
            if (indexAgregar == 3)
            {
                Art3.DataSource = Utilidades.EjecutaList();
                Art3.DisplayMember = "Articulo";
                Art3.Visible = true;
                Art3.Focus();
                Cant3.Visible = true;
                Val3.Visible = true;
            }
            if (indexAgregar == 4)
            {
                Art4.DataSource = Utilidades.EjecutaList();
                Art4.DisplayMember = "Articulo";
                Art4.Visible = true;
                Art4.Focus();
                Cant4.Visible = true;
                Val4.Visible = true;
            }
            if (indexAgregar == 5)
            {
                Art5.DataSource = Utilidades.EjecutaList();
                Art5.DisplayMember = "Articulo";
                Art5.Visible = true;
                Art5.Focus();
                Cant5.Visible = true;
                Val5.Visible = true;
            }
            if (indexAgregar == 6)
            {
                Art6.DataSource = Utilidades.EjecutaList();
                Art6.DisplayMember = "Articulo";
                Art6.Visible = true;
                Art6.Focus();
                Cant6.Visible = true;
                Val6.Visible = true;
            }
            if (indexAgregar == 7)
            {
                Art7.DataSource = Utilidades.EjecutaList();
                Art7.DisplayMember = "Articulo";
                Art7.Visible = true;
                Art7.Focus();
                Cant7.Visible = true;
                Val7.Visible = true;
            }
            if (indexAgregar == 8)
            {
                Art8.DataSource = Utilidades.EjecutaList();
                Art8.DisplayMember = "Articulo";
                Art8.Visible = true;
                Art8.Focus();
                Cant8.Visible = true;
                Val8.Visible = true;
            }
            if (indexAgregar == 9)
            {
                Art9.DataSource = Utilidades.EjecutaList();
                Art9.DisplayMember = "Articulo";
                Art9.Visible = true;
                Art9.Focus();
                Cant9.Visible = true;
                Val9.Visible = true;
            }
            if (indexAgregar == 10)
            {
                Art10.DataSource = Utilidades.EjecutaList();
                Art10.DisplayMember = "Articulo";
                Art10.Visible = true;
                Art10.Focus();
                Cant10.Visible = true;
                Val10.Visible = true;
            }
            if (indexAgregar == 11)
            {
                Art11.DataSource = Utilidades.EjecutaList();
                Art11.DisplayMember = "Articulo";
                Art11.Visible = true;
                Art11.Focus();
                Cant11.Visible = true;
                Val11.Visible = true;
            }
            if (indexAgregar == 12)
            {
                Art12.DataSource = Utilidades.EjecutaList();
                Art12.DisplayMember = "Articulo";
                Art12.Visible = true;
                Art12.Focus();
                Cant12.Visible = true;
                Val12.Visible = true;
            }
            if (indexAgregar == 13)
            {
                Art13.DataSource = Utilidades.EjecutaList();
                Art13.DisplayMember = "Articulo";
                Art13.Visible = true;
                Art13.Focus();
                Cant13.Visible = true;
                Val13.Visible = true;
            }
            if (indexAgregar == 14)
            {
                Art14.DataSource = Utilidades.EjecutaList();
                Art14.DisplayMember = "Articulo";
                Art14.Visible = true;
                Art14.Focus();
                Cant14.Visible = true;
                Val14.Visible = true;
            }
            if (indexAgregar == 15)
            {
                Art15.DataSource = Utilidades.EjecutaList();
                Art15.DisplayMember = "Articulo";
                Art15.Visible = true;
                Art15.Focus();
                Cant15.Visible = true;
                Val15.Visible = true;
            }



        }


        private void Suma()
        {
            

            if(Val1.Text != "" && Val2.Text != "" && Val3.Text != "" && Val4.Text != "" && Val5.Text != "" && Val6.Text != "" && Val7.Text != "" &&
                Val8.Text != "" && Val9.Text != "" && Val10.Text != "" && Val11.Text != "" && Val12.Text != "" && Val13.Text != "" && Val14.Text != "" && Val15.Text != "")
            {
                a = float.Parse(Val1.Text);
                b = float.Parse(Val2.Text);
                c = float.Parse(Val3.Text);
                d = float.Parse(Val4.Text);
                e = float.Parse(Val5.Text);
                f = float.Parse(Val6.Text);
                g = float.Parse(Val7.Text);
                h = float.Parse(Val8.Text);
                i = float.Parse(Val9.Text);
                j = float.Parse(Val10.Text);
                k = float.Parse(Val11.Text);
                l = float.Parse(Val12.Text);
                m = float.Parse(Val13.Text);
                n = float.Parse(Val14.Text);
                o = float.Parse(Val15.Text);


                resultado = a + b + c + d + e + f + g + h + i + j + k + l + m + n + o;
                TotalText.Text = resultado.ToString();
            }
           


        }

        private void ActualizarInventario()
        {
            string cmd2 = string.Format("EXEC OPClienteInventario '{0}', '{1}'", Art1.Text, Cant1.Text);
            string cmd3 = string.Format("EXEC OPClienteInventario '{0}', '{1}'", Art2.Text, Cant2.Text);
            string cmd4 = string.Format("EXEC OPClienteInventario '{0}', '{1}'", Art3.Text, Cant3.Text);
            string cmd5 = string.Format("EXEC OPClienteInventario '{0}', '{1}'", Art4.Text, Cant4.Text);
            string cmd6 = string.Format("EXEC OPClienteInventario '{0}', '{1}'", Art5.Text, Cant5.Text);
            string cmd7 = string.Format("EXEC OPClienteInventario '{0}', '{1}'", Art6.Text, Cant6.Text);
            string cmd8 = string.Format("EXEC OPClienteInventario '{0}', '{1}'", Art7.Text, Cant7.Text);
            string cmd9 = string.Format("EXEC OPClienteInventario '{0}', '{1}'", Art8.Text, Cant8.Text);
            string cmd10 = string.Format("EXEC OPClienteInventario '{0}', '{1}'", Art9.Text, Cant9.Text);
            string cmd11 = string.Format("EXEC OPClienteInventario '{0}', '{1}'", Art10.Text, Cant10.Text);
            string cmd12 = string.Format("EXEC OPClienteInventario '{0}', '{1}'", Art11.Text, Cant11.Text);
            string cmd13 = string.Format("EXEC OPClienteInventario '{0}', '{1}'", Art12.Text, Cant12.Text);
            string cmd14 = string.Format("EXEC OPClienteInventario '{0}', '{1}'", Art13.Text, Cant13.Text);
            string cmd15 = string.Format("EXEC OPClienteInventario '{0}', '{1}'", Art14.Text, Cant14.Text);
            string cmd16 = string.Format("EXEC OPClienteInventario '{0}', '{1}'", Art15.Text, Cant15.Text);
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


        private void ActualizarInvProv()
        {
            string cmd2 = string.Format("EXEC  OpProvInventario '{0}', '{1}'", Art1.Text, Cant1.Text);
            string cmd3 = string.Format("EXEC  OpProvInventario '{0}', '{1}'", Art2.Text, Cant2.Text);
            string cmd4 = string.Format("EXEC  OpProvInventario '{0}', '{1}'", Art3.Text, Cant3.Text);
            string cmd5 = string.Format("EXEC  OpProvInventario '{0}', '{1}'", Art4.Text, Cant4.Text);
            string cmd6 = string.Format("EXEC  OpProvInventario '{0}', '{1}'", Art5.Text, Cant5.Text);
            string cmd7 = string.Format("EXEC  OpProvInventario '{0}', '{1}'", Art6.Text, Cant6.Text);
            string cmd8 = string.Format("EXEC  OpProvInventario '{0}', '{1}'", Art7.Text, Cant7.Text);
            string cmd9 = string.Format("EXEC  OpProvInventario '{0}', '{1}'", Art8.Text, Cant8.Text);
            string cmd10 = string.Format("EXEC OpProvInventario  '{0}', '{1}'", Art9.Text, Cant9.Text);
            string cmd11 = string.Format("EXEC OpProvInventario  '{0}', '{1}'", Art10.Text, Cant10.Text);
            string cmd12 = string.Format("EXEC OpProvInventario  '{0}', '{1}'", Art11.Text, Cant11.Text);
            string cmd13 = string.Format("EXEC OpProvInventario  '{0}', '{1}'", Art12.Text, Cant12.Text);
            string cmd14 = string.Format("EXEC OpProvInventario  '{0}', '{1}'", Art13.Text, Cant13.Text);
            string cmd15 = string.Format("EXEC OpProvInventario  '{0}', '{1}'", Art14.Text, Cant14.Text);
            string cmd16 = string.Format("EXEC OpProvInventario  '{0}', '{1}'", Art15.Text, Cant15.Text);
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

        private void StartValues()
        {
            Val1.Text = "0";
            Val2.Text = "0";
            Val3.Text = "0";
            Val4.Text = "0";
            Val5.Text = "0";
            Val6.Text = "0";
            Val7.Text = "0";
            Val8.Text = "0";
            Val9.Text = "0";
            Val10.Text = "0";
            Val11.Text = "0";
            Val12.Text = "0";
            Val13.Text = "0";
            Val14.Text = "0";
            Val15.Text = "0";
            Cant1.Text = "0";
            Cant2.Text = "0";
            Cant3.Text = "0";
            Cant4.Text = "0";
            Cant5.Text = "0";
            Cant6.Text = "0";
            Cant7.Text = "0";
            Cant8.Text = "0";
            Cant9.Text = "0";
            Cant10.Text = "0";
            Cant11.Text = "0";
            Cant12.Text = "0";
            Cant13.Text = "0";
            Cant14.Text = "0";
            Cant15.Text = "0";
        }

    }
}