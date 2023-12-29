namespace TareaSemana1_Amagua.Vistas;

public partial class AporteIESS : ContentPage
{
    public AporteIESS()
    {
        InitializeComponent();
    }

    private async void CalcularButton_Clicked(object sender, EventArgs e)
    {
        var nombre = NombreEntry.Text;
        var apellido = ApellidoEntry.Text;
        var edad = int.Parse(EdadEntry.Text);
        var salario = double.Parse(SalarioEntry.Text);

        var iess = salario * 0.0945;

        await DisplayAlert("Resultados",
            $"Bienvenido {nombre} {apellido}\n" +
            $"Tienes {edad} años\n" +
            $"Tu aporte mensual es {iess:C}", "Aceptar");
    }
}