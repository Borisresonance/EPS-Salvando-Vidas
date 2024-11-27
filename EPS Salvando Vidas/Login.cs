namespace EPS_Salvando_Vidas
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            txtPassword.Enabled = false;
            btnIngresar.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void iniciarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Enable the password TextBox and the login Button
            txtPassword.Enabled = true;
            btnIngresar.Enabled = true;
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {// display my info
            string message = "Curso: Estructura de datos\n" +
                "Juan Diego Llorente Orozco \n" +
                "Grupo 301305_22";
            //method .show will show message
            MessageBox.Show(message, "Acerca de", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //text input 
            string enteredPassword = txtPassword.Text;

            //check if the password is correct
            if (enteredPassword == "unad")
            {
                MessageBox.Show("Acceso concedido...", "Acceso Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormUserData userDataForm = new FormUserData();
                userDataForm.Show();
                this.Hide(); // Hide the current form
            }
            else
            {
                MessageBox.Show("Contraseña incorrecta. Inténtalo de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Clear the password field
                txtPassword.Clear();
                txtPassword.Focus();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "¿Está seguro que desea salir de la aplicación?",
                "Confirmar salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            if (result == DialogResult.Yes)
            {
                // Exit the application
                Application.Exit();
            }
        }

       
    }
}