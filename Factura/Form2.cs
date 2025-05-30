using System;
using System.Windows.Forms;

namespace Factura // Asegúrate de que este sea el namespace correcto de tu proyecto
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(txtUsuario.Text) || string.IsNullOrWhiteSpace(txtcontraseña.Text))
            {
                MessageBox.Show("Por favor, ingresa tu usuario y contraseña.", "Campos Vacíos",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string usuarioIngresado = txtUsuario.Text.Trim();
            string contrasenaIngresada = txtcontraseña.Text;

            if (usuarioIngresado == "brayan" && contrasenaIngresada == "8520")
            {
                MessageBox.Show("Bienvenido al sistema", "Acceso Correcto",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

               
                Form1 formPrincipal = new Form1();

               
                formPrincipal.Show();

                
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Error de Acceso",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtcontraseña.Clear();
                txtcontraseña.Focus(); 
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = "";
            txtcontraseña.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estas seguro que desea salir?",
                "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes) {

                Application.Exit();
        }
    }
    }       
}
           