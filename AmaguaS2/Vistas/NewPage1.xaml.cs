namespace AmaguaS2.Vistas;

public partial class NewPage1 : ContentPage
{
    public string NombreUsuarioConectado { get; set; }
    public NewPage1(string nombreUsuario)
    {
        InitializeComponent();


        NombreUsuarioConectado = nombreUsuario;
        TituloLabel.Text = $" !Bienvenido {NombreUsuarioConectado}¡";

    }


    private void btn_Fecha_Clicked(object sender, EventArgs e)
    {
        DisplayAlert("Fecha", dpFechas.Date.ToString("MM/dd/yyyy"), "Aceptar");
    }

    private void CalcularNotaParcialButton_Clicked(object sender, EventArgs e)
    {
        if (double.TryParse(Seguimiento1Entry.Text, out double seguimiento1) &&
            double.TryParse(Examen1Entry.Text, out double examen1))
        {
            if (seguimiento1 >= 1 && seguimiento1 <= 10 && examen1 >= 1 && examen1 <= 10)
            {
                double notaParcial = seguimiento1 * 0.3 + examen1 * 0.2;
                NotaParcialLabel.Text = $"Nota Parcial 1: {notaParcial}";
            }
            else
            {
                DisplayAlert("Error", "Por favor, ingrese números del 1 al 10.", "OK");
            }
        }
        else
        {
            DisplayAlert("Error", "Por favor, ingrese valores numéricos.", "OK");
        }
    }

    private void CalcularNotaParcial2Button_Clicked(object sender, EventArgs e)
    {
        if (double.TryParse(Seguimiento2Entry.Text, out double seguimiento2) &&
            double.TryParse(Examen2Entry.Text, out double examen2))
        {
            if (seguimiento2 >= 1 && seguimiento2 <= 10 && examen2 >= 1 && examen2 <= 10)
            {
                double notaParcial2 = seguimiento2 * 0.3 + examen2 * 0.2;
                NotaParcial2Label.Text = $"Nota Parcial 2: {notaParcial2}";
            }
            else
            {
                DisplayAlert("Error", "Por favor, ingrese números del 1 al 10.", "OK");
            }
        }
        else
        {
            DisplayAlert("Error", "Por favor, ingrese valores numéricos.", "OK");
        }
    }
    private void CalcularNotaFinalButton_Clicked(object sender, EventArgs e)
    {
        if (double.TryParse(Seguimiento1Entry.Text, out double seguimiento1) &&
            double.TryParse(Examen1Entry.Text, out double examen1) &&
            double.TryParse(Seguimiento2Entry.Text, out double seguimiento2) &&
            double.TryParse(Examen2Entry.Text, out double examen2))
        {
            if (seguimiento1 >= 1 && seguimiento1 <= 10 &&
                examen1 >= 1 && examen1 <= 10 &&
                seguimiento2 >= 1 && seguimiento2 <= 10 &&
                examen2 >= 1 && examen2 <= 10)
            {
                double notaParcial1 = seguimiento1 * 0.3 + examen1 * 0.2;
                double notaParcial2 = seguimiento2 * 0.3 + examen2 * 0.2;

                double notaFinal = notaParcial1 + notaParcial2;
                NotaFinalLabel.Text = $"NOTA FINAL: {notaFinal}";

                string estado = "";
                string mensaje = "";
                string nombreUsuario = NombreUsuarioConectado;

                if (notaFinal >= 7)
                {
                    estado = "Aprobado";
                    mensaje = $"Felicidades {nombreUsuario}, has aprobado el curso!";
                }
                else if (notaFinal >= 5 && notaFinal <= 6.9)
                {
                    estado = "Complementario";
                    mensaje = $"¡Sigue esforzándote {nombreUsuario}!";
                }
                else
                {
                    estado = "Reprobado";
                    mensaje = $"Lamentablemente, {nombreUsuario}, has reprobado el curso.";
                }

                NotaFinalLabel.Text = "Nota Final: " + notaFinal.ToString();

                DisplayAlert("Estado", $"{estado} ({notaFinal})", mensaje);
            }
            else
            {
                DisplayAlert("Error", "Por favor, ingrese números del 1 al 10.", "OK");
            }
        }
        else
        {
            DisplayAlert("Error", "Por favor, ingrese valores numéricos.", "OK");
        }
    }
}



