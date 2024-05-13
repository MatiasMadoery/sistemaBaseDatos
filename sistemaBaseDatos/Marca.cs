using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaBaseDatos
{
    internal class Marca
    {
        //Campos
        private int id;
        private string descripcion;

        //Propiedades
        public int Id { get { return id; } set { id = value; } }
        public string Descripcion { get { return descripcion} set { descripcion = value; } }

        //Constructores
        public Marca() { }
        public Marca(string pDescripcion)
        {
            Descripcion = pDescripcion;
        }

        //Metodos
        public static DataTable BuscarTodo()
        {
            DataTable dt = new DataTable();
            string cadena = $"SELECT Marcas.Id, Marcas.Descripcion FROM Marcas";
            dt = BaseDatos.Buscar(cadena);
            return dt;
        }
    }
}
