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
    public partial class frmProductos : Form
    {
        public frmProductos()
        {
            InitializeComponent();
        }

        private void LlenarGrilla(DataTable datos)
        {
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = datos;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = Producto.BuscarTodo();
            LlenarGrilla(dt);
        }

        private void btnBuscarMarca_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = Producto.BuscarPorMarca(txtBuscarPorMarca.Text);
            LlenarGrilla(dt);
        }

        private void btnBuscarDescripcion_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = Producto.BuscarPorDescripcion(txtBuscarPorDescripcion.Text);
            LlenarGrilla(dt);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmNuevoProducto nuevoProducto = new frmNuevoProducto();
            nuevoProducto.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (dgvProductos.SelectedRows.Count > 0)
            {
                int id;
                id = Convert.ToInt32(dgvProductos.CurrentRow.Cells[0].Value);

                frmModificar frmModificar = new frmModificar(id);
                frmModificar.Show();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un item!");
            }
        }

        private void btnBuscarId_Click(object sender, EventArgs e)
        {
            int codigoBuscado;

            if (!int.TryParse(txtBuscarPorId.Text.Trim(), out codigoBuscado))
            {
                MessageBox.Show("Debe ingresar un numero de ID!");
            }
            else
            {
                DataTable dt = new DataTable();
                dt = Producto.BuscarPorId(codigoBuscado);
                LlenarGrilla(dt);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (dgvProductos.SelectedRows.Count > 0)
            {
                int id;
                id = Convert.ToInt32(dgvProductos.CurrentRow.Cells[0].Value);

                DialogResult borra = MessageBox.Show("Esta seguro de eliminar?", "Advertencia", MessageBoxButtons.YesNo);

                if (borra == DialogResult.Yes)
                {
                    Producto.Eliminar(id);
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el producto!");
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un item a eliminar!");
            }
        }
    }
}
