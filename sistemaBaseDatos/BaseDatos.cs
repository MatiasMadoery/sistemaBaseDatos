using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemaBaseDatos
{
    internal class BaseDatos
    {
        static SqlConnection conn = new SqlConnection();
        static private bool Conectar()
        {
            try
            {
                conn.ConnectionString = "Data Source=DESKTOP-IIQB7FM\\SQLEXPRESS;Initial Catalog=Sistema;Integrated Security=True;Encrypt=False";
                conn.Open();
                return true;
            }
            catch
            {
                return false;
            }            
        } 
        static private void Desconectar()
        {
            conn.Close();   
        }
        static public bool EjecutarConsulta(string CadenaSql)
        {
            bool correcto = true;
            try
            {
                Conectar();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(CadenaSql, conn);
                da.Fill(dt);
                correcto = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error de conexion:" + ex.Message);
                correcto = false;
            }
            finally
            {
                Desconectar();
            }
            return correcto;
        }
        static public DataTable Buscar(string CadenaSql)
        {
            try
            {
                Conectar();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(CadenaSql, conn);
                da.Fill(dt);
                return dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error de conexion: " + ex);
                return null;
            }
            finally
            {
                Desconectar();
            }
        }
    }
}
