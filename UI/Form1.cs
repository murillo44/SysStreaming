using BLL;
using Entity;

namespace UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        PeliculaBusiness PeliculaBusiness = new PeliculaBusiness();
        CategoriaBusiness CategoriaBusiness = new CategoriaBusiness();

        private void btnCargar_Click(object sender, EventArgs e)
        {
            try
            {
                Pelicula nuevaPelicula = new Pelicula()
                {
                    IdCategoria = Convert.ToInt32(comboCategoria.SelectedValue),
                    Titulo = txtTitulo.Text,
                    Descripcion = txtDescripcion.Text,
                    A�oLanzamiento = Convert.ToInt32(txtA�oLanzamiento.Text),
                    Duracion = Convert.ToDecimal(txtDuracion.Text),
                    Calificacion = Convert.ToInt32(txtCalificacion.Text)
                };
                PeliculaBusiness.cargarPelicula(nuevaPelicula);
                ActualizarCampos();
                MessageBox.Show("Pelicula cargada correctamente.", "Informaci�n", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FormatException FE)
            {
                MessageBox.Show("Ingrese los valores en su formato correcto", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Excepci�n", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                ActualizarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Excepci�n", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarCampos()
        {
            dgvPeliculas.DataSource = null;
            dgvPeliculas.DataSource = PeliculaBusiness.GetPeliculas();

            dgvPeliculas.Columns["IdCategoria"].Visible = false;
            dgvPeliculas.Columns["IdPelicula"].HeaderText = "ID";
            dgvPeliculas.Columns["A�oLanzamiento"].HeaderText = "A�o de lanzamiento";
            dgvPeliculas.Columns["FechaAlta"].HeaderText = "Fecha de alta";
            dgvPeliculas.Columns["Duracion"].HeaderText = "Duracion en horas";

            //Llenar combo
            comboCategoria.DataSource = null;
            comboCategoria.DataSource = CategoriaBusiness.GetCategorias();

            //Configurar combo categoria
            comboCategoria.ValueMember = "IdCategoria";
            comboCategoria.DisplayMember = "Descripcion";
            
            comboCategoria.Text = string.Empty;
            txtTitulo.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            txtA�oLanzamiento.Text = string.Empty;
            txtDuracion.Text = string.Empty;
            txtCalificacion.Text = string.Empty;
            txtIdEliminar.Text = string.Empty;
            txtIdModificar.Text = string.Empty;
            txtNuevaCalificacion.Text = string.Empty;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int idEliminar = Convert.ToInt32(txtIdEliminar.Text);
                PeliculaBusiness.eliminarPelicula(idEliminar);
                ActualizarCampos();
                MessageBox.Show("Pelicula eliminada correctamente", "Informaci�n", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Excepci�n", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                PeliculaBusiness.modificarCalificacion(Convert.ToInt32(txtIdModificar.Text), Convert.ToInt32(txtNuevaCalificacion.Text));
                ActualizarCampos();
                MessageBox.Show("Calificacion modificada exitosamente", "Informaci�n", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Excepci�n", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
