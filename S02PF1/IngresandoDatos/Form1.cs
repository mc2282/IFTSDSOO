namespace IngresandoDatos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculo_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtDato1.Text))
            {
                MessageBox.Show("Por favor, ingrese dos números");
                return;
            }

            int num1 = Convert.ToInt32(txtDato1.Text);
            int num2 = Convert.ToInt32(txtDato2.Text);

            if (num1 > num2) 
                {
                    MessageBox.Show("El número " + num1 + " es mayor que " + num2);
                }
                else if (num1 < num2)
                {
                    MessageBox.Show("El número " + num2 + " es mayor que " + num1);
                }
                else
                {
                    MessageBox.Show("El número " + num2 + " es igual que " + num1);
                }
        }
    }
}

        
    
