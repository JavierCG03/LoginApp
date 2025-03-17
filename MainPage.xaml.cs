using Microsoft.Maui.Controls;

namespace LoginApp
{
    public partial class MainPage : ContentPage
    {
        private bool isPasswordVisible = false;

        public MainPage()
        {
            InitializeComponent();
        }

        private void TogglePasswordVisibility(object sender, EventArgs e)
        {
            passwordEntry.IsPassword = !passwordEntry.IsPassword;
            isPasswordVisible = !isPasswordVisible;
            togglePasswordButton.Text = isPasswordVisible ? "Ocultar" : "Mostrar";
        }

        private void LoginClicked(object sender, EventArgs e)
        {
            if (usernameEntry.Text == "admin" && passwordEntry.Text == "admin123")
            {
                DisplayAlert("Éxito", "Inicio de sesión exitoso", "OK");
            }
            else
            {
                DisplayAlert("Error", "Usuario o Contraseña incorreptos", "OK");
            }
        }

        private void ClearFields(object sender, EventArgs e)
        {
            usernameEntry.Text = "";
            passwordEntry.Text = "";
        }
    }
}