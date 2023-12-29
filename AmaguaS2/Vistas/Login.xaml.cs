namespace AmaguaS2.Vistas;

public partial class Login : ContentPage
{
    string[] usuarios = { "Carlos", "Ana", "Jose", "Argenis", "1" };
    string[] contrase�as = { "carlos123", "ana123", "jose123", "argenis110", "1" };

    public Login()
    {
        InitializeComponent();
    }
    
    private void OnLoginButtonClicked(object sender, System.EventArgs e)
    {
        string usuarioIngresado = txtUsuario.Text;
        string contrase�aIngresada = txtContrase�a.Text;

        bool usuarioValido = false;
        int indiceUsuario = -1;

        for (int i = 0; i < usuarios.Length; i++)
        {
            if (usuarioIngresado == usuarios[i] && contrase�aIngresada == contrase�as[i])
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
            DisplayAlert("ALERTA", "USUARIO/CONTRASE�A INCORRECTA", "INTENTAR NUEVAMENTE");
        }
    }
}