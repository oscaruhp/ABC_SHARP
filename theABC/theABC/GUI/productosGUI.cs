using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using theABC.BO;
using theABC.DAO;

namespace theABC.GUI
{
    public partial class productosGUI : Form
    {
        productosBO oProductosBO;
        productosDAO oProductosDAO;
         public productosGUI(){
            oProductosDAO = new productosDAO();
            InitializeComponent();
            dtgProductos.DataSource = oProductosDAO.Buscar();

            dtgProductos.Columns[0].Visible = false;

        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // se la información se agrega mostramos un mensaje
            if (oProductosDAO.Agregar(RecuperarInformacion())==1){
                MessageBox.Show("Registro Agregado");
            }else {
                MessageBox.Show("Algo salio mal");
            }
            dtgProductos.DataSource = oProductosDAO.Buscar();

        }
        private productosBO RecuperarInformacion() {
            // Se recupera toda la información del formulario
            // Aquí se validan todos los datos.
            int id = 0; int.TryParse(txtid.Text, out id);
            oProductosBO= new productosBO();
            oProductosBO.id = id;
            oProductosBO.Clave = txtClave.Text;
            oProductosBO.Nombre = txtNombre.Text;
            oProductosBO.Descripcion = txtDescripcion.Text;
            oProductosBO.Precio = Convert.ToDouble(txtPrecio.Text);
            return oProductosBO;
        }
        
        private void SeleccionarRegistro(object sender, DataGridViewCellMouseEventArgs e)
        {
            int filaSeleccionada = e.RowIndex;
            
            oProductosBO = new productosBO();
            // se selecciona el ID para mostrar los datos en los textBox, etc
            oProductosBO.id = int.Parse(dtgProductos.Rows[filaSeleccionada].Cells[0].Value.ToString());

            oProductosBO.Clave = dtgProductos.Rows[filaSeleccionada].Cells[1].Value.ToString();
            oProductosBO.Nombre = dtgProductos.Rows[filaSeleccionada].Cells[2].Value.ToString();
            oProductosBO.Descripcion = dtgProductos.Rows[filaSeleccionada].Cells[3].Value.ToString();
            oProductosBO.Precio = Convert.ToDouble(dtgProductos.Rows[filaSeleccionada].Cells[4].Value.ToString());

            txtid.Text = Convert.ToString(oProductosBO.id);
            txtClave.Text= oProductosBO.Clave;
            txtNombre.Text= oProductosBO.Nombre;
            txtDescripcion.Text = oProductosBO.Descripcion;
            txtPrecio.Text= Convert.ToString(oProductosBO.Precio);

            // Activamos los botones para que el usuario puede agregar
            btnAgregar.Enabled = false;
            btnEliminar.Enabled = true;
            btnModificar.Enabled = true;
            btnCancelar.Enabled = true;


        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro? El cambio será permanente", "Se requiere confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
            {
                // se la información se agrega mostramos un mensaje
                if (oProductosDAO.Borrar(RecuperarInformacion()) == 1)
                {
                    MessageBox.Show("Registro Borrado");
                }
                else
                {
                    MessageBox.Show("Algo salio mal");
                }
                dtgProductos.DataSource = oProductosDAO.Buscar();
            }
            btnAgregar.Enabled = true;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            btnCancelar.Enabled = false;

        }

        private void productosGUI_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnAgregar.Enabled = true;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            btnCancelar.Enabled = false;

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (oProductosDAO.Modificar(RecuperarInformacion()) == 1)
            {
                MessageBox.Show("Registro Modificado");
            }
            else
            {
                MessageBox.Show("Algo salio mal");
            }
            dtgProductos.DataSource = oProductosDAO.Buscar();

            btnAgregar.Enabled = true;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            btnCancelar.Enabled = false;

        }
        
    }
}
