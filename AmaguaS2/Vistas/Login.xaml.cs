namespace AmaguaS2.Vistas;

public partial class Login : ContentPage
{
    string[] usuarios = { "Carlos", "Ana", "Jose", "Argenis", "1" };
    string[] contraseñas = { "carlos123", "ana123", "jose123", "argenis110", "1" };

    public Login()
    {
        InitializeComponent();
    }
    
    private void OnLoginButtonClicked(object sender, System.EventArgs e)
    {
        string usuarioIngresado = txtUsuario.Text;
        string contraseñaIngresada = txtContraseña.Text;

        bool usuarioValido = false;
        int indiceUsuario = -1;

        for (int i = 0; i < usuarios.Length; i++)
        {
            if (usuarioIngresado == usuarios[i] && contraseñaIngresada == contraseñas[i])
            {
                usuarioValido = true;
                indiceUsuario = i;
                break;
            }
        }

        if (usuarioValido)
        {
            string nombreUsuario = usuarios[indiceUsuario];          

            NewPage1 newPage = new NewPage1(nombreUsuario);
            Application.Current.MainPage = newPage;
        }
        else
        {
            DisplayAlert("ALERTA", "USUARIO/CONTRASEÑA INCORRECTA", "INTENTAR NUEVAMENTE");
        }
    }
}