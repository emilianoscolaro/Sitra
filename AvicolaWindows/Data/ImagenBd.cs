using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows;
using System.Windows.Forms;
using AvicolaWindows.Base;
using System.Drawing;
using DocumentFormat.OpenXml.Drawing;

namespace AvicolaWindows.Data
{
    class ImagenBd
    {
        private string cadena = "Data Source =.; Initial Catalog = Avicola; Integrated Security = True";
        public SqlConnection conn;
        public void conectar() { conn = new SqlConnection(cadena); }
        public ImagenBd() { conectar(); }

        SqlDataAdapter da;
        string detalleTipo;
        
        public DataTable consultar2(string tabla)
        {
            string sql = "SELECT * from" + tabla;
            da = new SqlDataAdapter(sql, conn);
            DataSet dst = new DataSet();
            da.Fill(dst, tabla);
            DataTable dt = new DataTable();
            dt = dst.Tables[tabla];
            return dt;
        }


        SqlCommand cmd = new SqlCommand() ;

        public bool InsertarImagen(string tipo, int id ,string fecha , string usuario,string cliente , string fdpago,string importe ,string observaciones,PictureBox imagen ,string tipoclienteprov)
        {
            cmd.Connection = conn;
            cmd.CommandText = "insert into " + tipo + " (ID,Fecha,Usuario,Cliente,Forma,Importe,Observaciones,Foto,TipoDeCliente) values (@id,@fecha,@usuario,@cliente,@formadepago,@importe,@observaciones,@foto,@tipodecliente)";
            cmd.Parameters.Add("@id", SqlDbType.Int);
            cmd.Parameters.Add("@fecha", SqlDbType.DateTime);
            cmd.Parameters.Add("@usuario", SqlDbType.NVarChar);
            cmd.Parameters.Add("@cliente", SqlDbType.NVarChar);
            cmd.Parameters.Add("@formadepago", SqlDbType.NVarChar);
            cmd.Parameters.Add("@importe", SqlDbType.Float);
            cmd.Parameters.Add("@observaciones", SqlDbType.NVarChar);
            cmd.Parameters.Add("@foto", SqlDbType.Image);
            cmd.Parameters.Add("@tipodecliente", SqlDbType.NVarChar);

            cmd.Parameters["@id"].Value = id;
            cmd.Parameters["@fecha"].Value = fecha;
            cmd.Parameters["@usuario"].Value = usuario;
            cmd.Parameters["@cliente"].Value = cliente;
            cmd.Parameters["@formadepago"].Value = fdpago;
            cmd.Parameters["@importe"].Value = importe;
            cmd.Parameters["@observaciones"].Value = observaciones;
            cmd.Parameters["@tipodecliente"].Value = tipoclienteprov;

            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            imagen.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            cmd.Parameters["@foto"].Value = ms.GetBuffer();

            conn.Open();
            int i = cmd.ExecuteNonQuery();
            conn.Close();

            if (i > 0)
            {
                return true;
            }
            else { return false; }
        }


        public bool InsertarDetalle(string tipo, int id, string fecha, string cliente, string importe, string observaciones)
        {
            if (tipo == "Pagos") { detalleTipo = "Pago"; }
            if (tipo == "Cobranzas") { detalleTipo = "Cobro"; }
            cmd.Connection = conn;
            cmd.CommandText = "insert into DetallesCuentas (Fecha,Cliente,Descripcion,ID,Valor,Observaciones) values (@fecha2,@cliente2,'" + detalleTipo + "',@id2,@importe2,@observaciones2)";

            cmd.Parameters.Add("@id2", SqlDbType.Int);
            cmd.Parameters.Add("@fecha2", SqlDbType.DateTime);
            cmd.Parameters.Add("@cliente2", SqlDbType.NVarChar);
            cmd.Parameters.Add("@importe2", SqlDbType.Float);
            cmd.Parameters.Add("@observaciones2", SqlDbType.NVarChar);

            cmd.Parameters["@id2"].Value = id;
            cmd.Parameters["@fecha2"].Value = fecha;
            cmd.Parameters["@cliente2"].Value = cliente;
            cmd.Parameters["@importe2"].Value = importe;
            cmd.Parameters["@observaciones2"].Value = observaciones;

            conn.Open();
            int i = cmd.ExecuteNonQuery();
            conn.Close();

            if (i > 0)
            {
                return true;
            }
            else { return false; }

        }

        public bool InsertarSoloImagen(string id ,PictureBox imagen,string tipo)
        {
            cmd.Connection = conn;
            cmd.CommandText = "update " + tipo + " set Foto = @foto  where ID = @id ";
            cmd.Parameters.Add("@id", SqlDbType.Int);
            cmd.Parameters.Add("@foto", SqlDbType.Image);
            cmd.Parameters["@id"].Value = id;
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            imagen.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            cmd.Parameters["@foto"].Value = ms.GetBuffer();

            conn.Open();
            int i = cmd.ExecuteNonQuery();
            conn.Close();

            if (i > 0)
            {
                return true;
            }
            else { return false; }
        }


        public void VerImagen (string tipo, string id,PictureBox foto)
        {
            SqlCommand commando = new SqlCommand("SELECT Foto from " + tipo + " where ID = " + id + "",conn);
            SqlDataAdapter dp = new SqlDataAdapter(commando);
            DataSet ds = new DataSet("Foto");
            dp.Fill(ds, "Foto");
            byte[] Datos = new byte[0];
            DataRow dr = ds.Tables["Foto"].Rows[0];

            Datos=(byte[])dr["Foto"];
            System.IO.MemoryStream ms = new System.IO.MemoryStream(Datos);
            foto.BackgroundImage = System.Drawing.Bitmap.FromStream(ms);
        }
        



    }
}
