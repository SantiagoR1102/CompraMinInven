using System;
using System.Linq;
using System.Windows.Forms;
using Modelos;

namespace CompraMinInventario
{
    public partial class FrmProducto : Form
    {
        private Conexion.DBProductos productos;

        public FrmProducto(ObjProductos modelo)
        {
            InitializeComponent();
            productos = new Conexion.DBProductos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Codigo = txtbxCodigo.Text.Trim();

            if (string.IsNullOrWhiteSpace(Codigo))
            {
                MessageBox.Show("Por favor, ingrese un Código.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var producto = productos.Buscar(Codigo);

                if (producto != null)
                {
                    txtbxDesc.Text = producto.Nombre;
                    txtbxPrecio.Text = producto.Costo.ToString();
                    txtbxGarantia.Text = producto.Garantia;
                    txtbxCantidad.Text = producto.Cantidad;
                }
                else
                {
                    MessageBox.Show($"No se encontró ningún producto con el código {Codigo}.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEnvia_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtbxCodigo.Text))
                {
                    MessageBox.Show("El campo Código no puede estar vacío");
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtbxCantidad.Text) || !int.TryParse(txtbxCantidad.Text, out int cantidad))
                {
                    MessageBox.Show("El campo Cantidad debe ser un número válido");
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtbxPrecio.Text) || !int.TryParse(txtbxPrecio.Text, out int costo))
                {
                    MessageBox.Show("El campo Precio debe ser un número válido");
                    return;
                }

                int id = string.IsNullOrEmpty(txtbxid.Text) ? 0 : Convert.ToInt32(txtbxid.Text);

                bool rs = productos.Guardar(id, txtbxDesc.Text, txtbxCodigo.Text, costo, txtbxGarantia.Text, txtbxCantidad.Text);

                if (rs)
                {
                    MessageBox.Show("Datos guardados con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            txtbxDesc.Text = "";
            txtbxCodigo.Text = "";
            txtbxCantidad.Text = "";
            txtbxGarantia.Text = "";
            txtbxPrecio.Text = "";
        }
    }
}
