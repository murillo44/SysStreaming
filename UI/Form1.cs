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
                    AñoLanzamiento = Convert.ToInt32(txtAñoLanzamiento.Text),
                    Duracion = Convert.ToDecimal(txtDuracion.Text),
                    Calificacion = Convert.ToInt32(txtCalificacion.Text)
                };
                PeliculaBusiness.cargarPelicula(nuevaPelicula);
                ActualizarCampos();
                MessageBox.Show("Pelicula cargada correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FormatException FE)
            {
                MessageBox.Show("Ingrese los valores en su formato correcto", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Excepción", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(ex.Message, "Excepción", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarCampos()
        {
            dgvPeliculas.DataSource = null;
            dgvPeliculas.DataSource = PeliculaBusiness.GetPeliculas();

            dgvPeliculas.Columns["IdCategoria"].Visible = false;
            dgvPeliculas.Columns["IdPelicula"].HeaderText = "ID";
            dgvPeliculas.Columns["AñoLanzamiento"].HeaderText = "Año de lanzamiento";
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
            txtAñoLanzamiento.Text = string.Empty;
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
                MessageBox.Show("Pelicula eliminada correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Excepción", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                PeliculaBusiness.modificarCalificacion(Convert.ToInt32(txtIdModificar.Text), Convert.ToInt32(txtNuevaCalificacion.Text));
                ActualizarCampos();
                MessageBox.Show("Calificacion modificada exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Excepción", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
