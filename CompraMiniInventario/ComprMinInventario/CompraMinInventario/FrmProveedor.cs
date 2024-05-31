using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelos;
namespace CompraMinInventario
{
    public partial class FrmProveedor : Form
    {

        private Conexion.DBProveedores proveedores;
        public FrmProveedor(objProveedores modelo)
        {
            InitializeComponent();
            proveedores = new Conexion.DBProveedores();
        }

        private void btnEnvia_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtbxNombre.Text))
                {
                    MessageBox.Show("El campo Nombre no puede estar vacío");
                    return;
                }
                if (HasNumber(txtbxNombre.Text))
                {
                    MessageBox.Show("El campo Nombre no puede tener números");
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtbxNit.Text))
                {
                    MessageBox.Show("El campo Nit debe ser un número válido");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtbxTele.Text))
                {
                    MessageBox.Show("El campo telefono debe ser un número válido");
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtbxCiudad.Text))
                {
                    MessageBox.Show("El campo Ciudad no puede estar vacío");
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtbxCorreo.Text))
                {
                    MessageBox.Show("El campo Correo no puede estar vacío");
                    return;
                }

                int id = string.IsNullOrEmpty(txtid.Text) ? 0 : Convert.ToInt32(txtid.Text);
                int Nit = string.IsNullOrEmpty(txtbxNit.Text) ? 0 : Convert.ToInt32(txtbxNit.Text);
                int Tele = string.IsNullOrEmpty(txtbxTele.Text) ? 0 : Convert.ToInt32(txtbxTele.Text);

                bool rs = proveedores.Guardar(id, txtbxNombre.Text, Nit, txtbxCiudad.Text, Tele, txtbxCorreo.Text);

                if (rs)
                {
                    MessageBox.Show("Datos guardados con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                txtbxNombre.Text = "";
                txtbxNit.Text = "";
                txtbxTele.Text = "";
                txtbxCiudad.Text = "";
                txtbxCorreo.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool HasNumber(string input)
        {
            return input.Any(char.IsDigit);
        }
    }
}
