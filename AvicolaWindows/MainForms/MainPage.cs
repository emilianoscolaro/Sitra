using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using AvicolaWindows.Base;
using AvicolaWindows.Data;
using AvicolaWindows.EditForms;
using AvicolaWindows.MainForms;

namespace AvicolaWindows
{
    public partial class MainPage : Form
    {
        public MainPage(string usuario,string usrId,string usrNivel)
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            _usuario = usuario;
            _usrId = usrId;
            _usrNivel = usrNivel;
            RestrictedControlls();
        }

        string tipo;
        string _usuario,_usrId,_usrNivel;
        Form activeForm = null;

        private void MainPage_Load(object sender, EventArgs e)
        {
            UserName.Text = _usuario;
        }


        // Funcions


        private void BarBlackColor()
        {
            panel3.BackColor = Color.FromArgb(31, 31, 31);
            XBtn.ForeColor = Color.White;
            MinBtn.ForeColor = Color.White;
            MaxBtn.ForeColor = Color.White;
        }
        private void BarWhiteColor()
        {
            panel3.BackColor = Color.White;
            XBtn.ForeColor = Color.Black;
            MinBtn.ForeColor = Color.Black;
            MaxBtn.ForeColor = Color.Black;
        }
        public void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.WindowState = FormWindowState.Maximized;
            childForm.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(childForm);
            MainPanel.Tag = childForm;
            childForm.Show();
            NuevoBtn.BringToFront();
            BackBtn.BringToFront();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
        private void ShowSubMenu(Panel subpanel)
        {
            if (subpanel.Visible == false)
            {
                subpanel.Visible = true;
            }
            else { subpanel.Visible = false; }
        }
        public void BtnTxtChangeColorIn( Button btn)
        {
            btn.ForeColor = Color.White;
        }
        public void BtnTxtChangeColorOut(Button btn)
        {
            btn.ForeColor = Color.Black;
        }


        // mouse drag


        bool drag = false;
        Point startPoint = new Point(0, 0);
        private void panel3_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - startPoint.X, p.Y - startPoint.Y);
            }
        }

        private void panel3_MouseUp_1(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void panel3_MouseDown_1(object sender, MouseEventArgs e)
        {
            drag = true;
            startPoint = new Point(e.X, e.Y);
        }



        // botones ventana

        private void XBtn_MouseEnter(object sender, EventArgs e)
        {
            XBtn.BackColor = Color.Red;
            XBtn.ForeColor = Color.White;
        }

        private void XBtn_MouseLeave(object sender, EventArgs e)
        {
            XBtn.BackColor = Color.Transparent;
            XBtn.ForeColor = Color.FromArgb(64, 64, 64);
        }

        private void XBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinBtn_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Minimized;
            }
        }

        private void MaxBtn_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
                if (activeForm != null)
                {
                    activeForm.WindowState = FormWindowState.Normal;
                }
                NuevoBtn.BringToFront();
                BackBtn.BringToFront();
            }
            else if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
                if(activeForm != null)
                {
                    activeForm.WindowState = FormWindowState.Normal;
                }

                NuevoBtn.BringToFront();
                BackBtn.BringToFront();
            }


        }


        // buttons panel

        private void NuevoBtn_Click(object sender, EventArgs e)
        {

            if (activeForm.Text == "Usuarios")
            {
                OpenChildForm(new CrearUsuario());
                NuevoBtn.Visible = false;
                BarBlackColor();
            }
            if(activeForm.Text == "Clientes")
            {
                tipo = "Cliente";
                OpenChildForm(new CrearCliente(tipo));
                NuevoBtn.Visible = false;
                BarBlackColor();
            }
            
            if(activeForm.Text == "Proveedores")
            {
                tipo = "Proveedor";
                OpenChildForm(new CrearCliente(tipo));
                NuevoBtn.Visible = false;
                BarBlackColor();
            }

            if (activeForm.Text == "Inventario")
            {
                tipo = "Proveedor";
                OpenChildForm(new CrearInventario());
                NuevoBtn.Visible = false;
                BarBlackColor();
            }

            if (activeForm.Text == "PagosCobranzas")
            {

                OpenChildForm(new CrearPagoCobranza(tipo,_usuario,_usrId));
                NuevoBtn.Visible = false;
                BarBlackColor();
            }


            BackBtn.Visible = true;
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            BackBtn.Visible = false;
            if (activeForm.Text == "CrearUsuario")
            {
                OpenChildForm(new Usuarios(_usrId));
                NuevoBtn.Visible = true;
                BarWhiteColor();
            }
            if (activeForm.Text == "CrearCliente" && tipo == "Cliente")
            {
                OpenChildForm(new Clientes(_usuario,_usrNivel));
                NuevoBtn.Visible = true;
                BarWhiteColor();
            }
            if (activeForm.Text == "CrearCliente" && tipo == "Proveedor")
            {
                OpenChildForm(new Proveedores(_usuario, _usrNivel));
                NuevoBtn.Visible = true;
                BarWhiteColor();
            }
            if (activeForm.Text == "CrearInventario")
            {
                OpenChildForm(new Inventario(_usrNivel));
                NuevoBtn.Visible = true;
                BarWhiteColor();
            }
            if(activeForm.Text== "CrearPagoCobranza" && tipo == "Pagos")
            {
                OpenChildForm(new PagosCobranzas(tipo, _usrNivel));
                NuevoBtn.Visible = true;
                BarWhiteColor();
            }
            if (activeForm.Text == "CrearPagoCobranza" && tipo == "Cobranzas")
            {
                OpenChildForm(new PagosCobranzas(tipo, _usrNivel));
                NuevoBtn.Visible = true;
                BarWhiteColor();
            }

        }

        private void NuevoBtn_MouseEnter(object sender, EventArgs e)
        {
            NuevoBtn.Size = NuevoBtn.Size + new Size(20, 0);
        }

        private void NuevoBtn_MouseLeave(object sender, EventArgs e)
        {
            NuevoBtn.Size = NuevoBtn.Size - new Size(20, 0);
        }

        //Admin Btns

        private void AdminBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Usuarios(_usrId));
            NuevoBtn.Visible = true;
            BackBtn.Visible = false;
            BarWhiteColor();
        }

        private void AdminBtn_MouseEnter(object sender, EventArgs e)
        {
            BtnTxtChangeColorIn(AdminBtn);
        }

        private void AdminBtn_MouseLeave(object sender, EventArgs e)
        {
            BtnTxtChangeColorOut(AdminBtn);
        }



        // Clientes btn

        private void ClientesBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Clientes(_usuario, _usrNivel));
            NuevoBtn.Visible = true;
            BackBtn.Visible = false;
            BarWhiteColor();
        }

        private void ClientesBtn_MouseEnter(object sender, EventArgs e)
        {
            BtnTxtChangeColorIn(ClientesBtn);
        }

        private void ClientesBtn_MouseLeave(object sender, EventArgs e)
        {
            BtnTxtChangeColorOut(ClientesBtn);
        }

        // ProveedoresBtn


        private void ProveedoresBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Proveedores(_usuario, _usrNivel));
            NuevoBtn.Visible = true;
            BackBtn.Visible = false;
            BarWhiteColor();

        }

        private void ProveedoresBtn_MouseEnter(object sender, EventArgs e)
        {
            BtnTxtChangeColorIn(ProveedoresBtn);
        }

        private void ProveedoresBtn_MouseLeave(object sender, EventArgs e)
        {
            BtnTxtChangeColorOut(ProveedoresBtn);
        }

        // Inventario

        private void InventarioBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Inventario(_usrNivel));
            NuevoBtn.Visible = true;
            BackBtn.Visible = false;
            BarWhiteColor();
        }

        private void InventarioBtn_MouseEnter(object sender, EventArgs e)
        {
            BtnTxtChangeColorIn(InventarioBtn);
        }

        private void InventarioBtn_MouseLeave(object sender, EventArgs e)
        {
            BtnTxtChangeColorOut(InventarioBtn);
        }



        // OPBtn

        private void OpBtn_Click(object sender, EventArgs e)
        {
            if (OpPanel.Visible == false)
            {
                OpPanel.Visible = true;
            }else { OpPanel.Visible = false; }
        }

        private void OpBtn_MouseEnter(object sender, EventArgs e)
        {
            BtnTxtChangeColorIn(OpBtn);
        }

        private void OpBtn_MouseLeave(object sender, EventArgs e)
        {
            BtnTxtChangeColorOut(OpBtn);
        }


        private void OpClientBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Operaciones(_usrId, _usrNivel));
            NuevoBtn.Visible = false;
            BackBtn.Visible = false;
            BarWhiteColor();
        }

        private void OpProveeBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new OpProveedores(_usrId, _usrNivel));
            NuevoBtn.Visible = false;
            BackBtn.Visible = false;
            BarWhiteColor();
        }

        //   Caja

        private void CajaBtn_Click(object sender, EventArgs e)
        {
            if (CajaPanel.Visible == false)
            {
                CajaPanel.Visible = true;
            }
            else { CajaPanel.Visible = false; }
        }

        private void CajaBtn_MouseEnter(object sender, EventArgs e)
        {
            BtnTxtChangeColorIn(CajaBtn);
        }

        private void CajaBtn_MouseLeave(object sender, EventArgs e)
        {
            BtnTxtChangeColorOut(CajaBtn);
        }

        private void PagosBtn_Click(object sender, EventArgs e)
        {
            tipo = "Pagos";
            OpenChildForm(new PagosCobranzas(tipo, _usrNivel));
            NuevoBtn.Visible = true;
            BackBtn.Visible = false;
            BarWhiteColor();
        }


        private void CobranzasBtn_Click(object sender, EventArgs e)
        {
            tipo = "Cobranzas";
            OpenChildForm(new PagosCobranzas(tipo, _usrNivel));
            NuevoBtn.Visible = true;
            BackBtn.Visible = false;
            BarWhiteColor();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Config(_usrId));
            NuevoBtn.Visible = false;
            BackBtn.Visible = false;
            BarBlackColor();
        }

        private void ChequesBtn_Click(object sender, EventArgs e)
        {
            tipo = "Cheques";
            OpenChildForm(new Cheques( _usrNivel));
            NuevoBtn.Visible = true;
            BackBtn.Visible = false;
            BarWhiteColor();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string cmd = string.Format("SELECT * from Usuarios where ID =" + _usrId + "");
            DataSet ds = Utilidades.Ejecutar(cmd);

            string usrcontra = ds.Tables[0].Rows[0]["Contraseña"].ToString();
            string usrname = ds.Tables[0].Rows[0]["Nombre"].ToString();
            string usrapell = ds.Tables[0].Rows[0]["Apellido"].ToString();

            OpenChildForm(new EditarUsuarios(_usuario, usrcontra, usrname, usrapell, _usrId));
            NuevoBtn.Visible = false;
            BackBtn.Visible = false;
            BarBlackColor();

        }

        private void RestrictedControlls()
        {
            if(_usrNivel == "1" || _usrNivel == "2" || _usrNivel == "3")
            {
                AdminBtn.Visible = false;
            }
        }


    }






}
