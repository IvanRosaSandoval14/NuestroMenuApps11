namespace NuestroMenuApps11;

public partial class Pagina2 : ContentPage
{
	public Pagina2()
	{
		InitializeComponent();
	}

    private void CalcularSuperficie_Clicked(object sender, EventArgs e)
    {
        if (!double.TryParse(BaseEntry.Text, out double baseTriangulo))
        {
            DisplayAlert("Error", "Debe ingresar una base válida.", "OK");
            return;
        }

        if (!double.TryParse(AlturaEntry.Text, out double alturaTriangulo))
        {
            DisplayAlert("Error", "Debe ingresar una altura válida.", "OK");
            return;
        }

        // Calcular superficie del triángulo: (base * altura) / 2
        double superficie = (baseTriangulo * alturaTriangulo) / 2;

        // Mostrar resultado
        ResultadoLabel.Text = $"Superficie del triángulo: {superficie:F2} unidades cuadradas";
    }
}