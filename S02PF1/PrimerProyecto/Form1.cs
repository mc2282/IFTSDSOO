namespace PrimerProyecto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            int documento = Convert.ToInt32(txtDocumento.Text);

            MessageBox.Show("Nombre: " + nombre + " Apellido: " + apellido + " Documento: " + documento);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = string.Empty;
            txtApellido.Clear();
            txtDocumento.Text = "";
        }

    }
}