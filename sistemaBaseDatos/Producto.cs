using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaBaseDatos
{
    internal class Producto
    {
        //Campos
        private int id;
        private int idMarca;
        private string descripcion;
        private int precioCompra;
        private int precioVenta;

        //Propiedades
        public int Id { get { return id; } set { id = value; } }
        public int IdMarca { get { return idMarca; } set { idMarca = value; } }
        public string Descripcion { get { return descripcion; } set { descripcion = value; } }
        public int PrecioCompra { get { return precioCompra; } set { precioCompra = value; } }
        public int PrecioVenta { get { return precioVenta; } set { precioVenta = value; } }

        //Constructores
        public Producto() { }
        public Producto(int pIdMarca, string pDescirpcion, int pPrecioCompra, int pPrecioVenta)
        {
            IdMarca = pIdMarca;
            Descripcion = pDescirpcion;
            PrecioCompra = pPrecioCompra;
            PrecioVenta= pPrecioVenta;
        }

        //Metodos
        public bool Nuevo()
        {
            bool correcto;
            string cadena = $"INSERT INTO Productos (IdMarca, Descripcion, PrecioCompra, PrecioVenta)" +
                $"VALUE (" +
                $"{IdMarca}," +
                $"'{Descripcion}'," +
                $"{PrecioCompra}," +
                $"{PrecioVenta}" +
                $")";
            correcto = BaseDatos.EjecutarConsulta(cadena);
            return correcto;
        }
        public static bool Eliminar(int IdSeleccionado)
        {
            bool correcto;
            string cadena = $"DELETE FROM Productos WHERE Id = {IdSeleccionado}";
            correcto = BaseDatos.EjecutarConsulta(cadena);
            return correcto;
        }
        public static DataTable BuscarTodo()
        {
            DataTable dt = new DataTable();
            string cadena = $"SELECT Productos.Id," +
                $"Productos.IdMarca," +
                $"Productos.Descripcion," +
                $"Marcas.Descripcion," +
                $"Productos.PrecioCompra," +
                $"Productos.PrecioVenta" +
                $"FROM Productos INNER JOIN Marcas ON Productos.IdMarca = Marcas.Id";
            dt = BaseDatos.Buscar(cadena);
            return dt;
        }
        public static DataTable BuscarPorId(string IdBuscado) 
        {
            DataTable dt = new DataTable();
            string cadena = $"SELECT Productos.Id," +
                $"Productos.IdMarca," +
                $"Productos.Descripcion," +
                $"Marcas.Descripcion," +
                $"Productos.PrecioCompra," +
                $"Productos.PrecioVenta" +
                $"FROM Productos INNER JOIN Marcas ON Productos.IdMarca = Marcas.Id" +
                $"WHERE Productos Id = {IdBuscado}";
            dt = BaseDatos.Buscar(cadena);
            return dt;
        }
        public static DataTable BuscarPorMarca(string MarcaBuscado)
        {
            DataTable dt = new DataTable();
            string cadena = $"SELECT Productos.Id," +
                $"Productos.IdMarca," +
                $"Productos.Descripcion," +
                $"Marcas.Descripcion," +
                $"Productos.PrecioCompra," +
                $"Productos.PrecioVenta" +
                $"FROM Productos INNER JOIN Marcas ON Productos.IdMarca = Marcas.Id" +
                $"WHERE Marcas.Descripcion {MarcaBuscado}";
            dt = BaseDatos.Buscar(cadena);
            return dt;
        }
        public static DataTable BuscarPorDescripcion(string DescripcionBuscado)
        {
            DataTable dt = new DataTable();
            string cadena = $"SELECT Productos.Id," +
                $"Productos.IdMarca," +
                $"Productos.Descripcion," +
                $"Marcas.Descripcion," +
                $"Productos.PrecioCompra," +
                $"Productos.PrecioVenta" +
                $"FROM Productos INNER JOIN Marcas ON Productos.IdMarca = Marcas.Id" +
                $"WHERE Productos.Descripcion 'LIKE %{DescripcionBuscado}%'";
            dt = BaseDatos.Buscar(cadena);
            return dt;
        }
    }
}
