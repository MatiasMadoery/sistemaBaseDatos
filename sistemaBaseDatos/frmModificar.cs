using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemaBaseDatos
{
    public partial class frmModificar : Form        
    {
        Producto producto = new Producto(); 
        public frmModificar(int idProducto)
        {
            InitializeComponent();

            cmbMarca.ValueMember = "id";
            cmbMarca.DisplayMember = "descripcion";
            cmbMarca.DataSource = Marca.BuscarTodo();

            if (idProducto > 0)
            {
                DataTable dt = new DataTable();
                dt = Producto.BuscarPorId(idProducto);

                if (dt.Rows.Count > 0)
                {
                    producto.Id = Convert.ToInt32(dt.Rows[0]["id"]);
                    producto.IdMarca = Convert.ToInt32(dt.Rows[0]["idMarca"]);
                    producto.Descripcion = dt.Rows[0]["descripcion"].ToString();
                    producto.PrecioCompra = Convert.ToInt32(dt.Rows[0]["precioCompra"]);
                    producto.PrecioVenta = Convert.ToInt32(dt.Rows[0]["precioVenta"]);

                    txtId.Text = producto.Id.ToString();
                    cmbMarca.SelectedValue = producto.IdMarca;
                    txtDescripcion.Text = producto.Descripcion;
                    txtPrecioCompra.Text = producto.PrecioCompra.ToString();
                    txtPrecioVenta.Text = producto.PrecioVenta.ToString();
                }
                else
                {
                    MessageBox.Show("No se encontro el item con el Id buscado!");
                }
            }
            else
            {
                MessageBox.Show("El Id del producto no es valido!");
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
           Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool correcto = true;
            int precioCompra;
            int precioVenta;

            if (txtDescripcion.Text.Trim()=="")
            {
                MessageBox.Show("Completar campo descripcion!");
                correcto = false;
            }
            if (!int.TryParse(txtPrecioCompra.Text.Trim(), out precioCompra))
            {
                MessageBox.Show("Campo precio compra  incompleto!");
                correcto = false;
            }
            if(!int.TryParse(txtPrecioVenta.Text.Trim(), out precioVenta))
            {
                MessageBox.Show("Campo precio venta incompleto!");
                correcto=false;
            }

            if (correcto)
            {
                producto.IdMarca = Convert.ToInt32(cmbMarca.SelectedValue);
                producto.Descripcion = txtDescripcion.Text;
                producto.PrecioCompra = precioCompra;
                producto.PrecioVenta = precioVenta;

                if (producto.Modificar())
                {
                    MessageBox.Show("El producto se modifico correctamente!");
                    Close();
                }
                else
                {
                    MessageBox.Show("El producto no se pudo modificar!");
                }
            }
                                        
        }
    }
}
