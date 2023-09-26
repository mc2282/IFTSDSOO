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
            string doc_tipo = cboTipo.Text;
            int documento = Convert.ToInt32(txtDocumento.Text);

            Postulante postulante1 = new Postulante(nombre, apellido, doc_tipo, documento);

            MessageBox.Show("Nombre: " + postulante1.Nombre + " Apellido: " + postulante1.Apellido + " Tipo: " + postulante1.Tipo + " Documento: " + postulante1.Documento, "Ingreso del postulante",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = string.Empty;
            txtApellido.Clear();
            txtDocumento.Text = "";
        }


    }
}