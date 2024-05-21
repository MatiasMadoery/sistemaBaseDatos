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
    public partial class frmNuevoProducto : Form
    {
        public frmNuevoProducto()
        {
            InitializeComponent();
        }

        private void frmNuevoProducto_Load(object sender, EventArgs e)
        {
            cmbMarca.ValueMember = "Id";
            cmbMarca.DisplayMember = "Descripcion";
            cmbMarca.DataSource = Marca.BuscarTodo();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool correcto = true;
            int precioCompra;
            int precioVenta;

            if (txtDescripcion.Text.Trim() == "")
            {
                MessageBox.Show("No ha completado el campo descripcion!");
                correcto = false;
            }
            if (!int.TryParse(txtPrecioCompra.Text.Trim(), out precioCompra))
            {
                MessageBox.Show("No se ha completado el campo precio compra!");
                correcto = false;
            }
            if (!int.TryParse(txtPrecioVenta.Text.Trim(), out precioVenta))
            {
                MessageBox.Show("No se ha completado el campo precio venta!");
                correcto = false;
            }

            if (correcto)
            {
                Producto producto = new Producto(Convert.ToInt32(cmbMarca.SelectedValue), txtDescripcion.Text, precioCompra, precioVenta);

                if (producto.Nuevo())
                {
                    MessageBox.Show("El producto se agrego correctamente!");
                }
                else
                {
                    MessageBox.Show("El producto no se pudo agregar!");
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
