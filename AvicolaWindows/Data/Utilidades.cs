using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace AvicolaWindows.Data
{
    public class Utilidades
    {
        private static SqlConnection conenct = new SqlConnection("Data Source=.;Initial Catalog=Avicola;Integrated Security=True");


        public static DataSet Ejecutar(string cmd)
        {
            conenct.Open();

            DataSet DS = new DataSet();
            SqlDataAdapter DA = new SqlDataAdapter(cmd, conenct);
            DA.Fill(DS);

            conenct.Close();
            return DS;
        }

       public static DataTable EjecutaList()
        {
            conenct.Open();

            SqlDataAdapter da = new SqlDataAdapter("LlenarComboBox", conenct);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            conenct.Close();
            return dt;
            
        }


        public static DataTable EjecutaListPagosCob(string procedure)
        {
            conenct.Open();

            SqlDataAdapter da = new SqlDataAdapter(procedure, conenct);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            conenct.Close();
            return dt;

        }


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

    }
}
