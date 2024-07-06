namespace NuestroMenuApps11;

public partial class Pagina3 : ContentPage
{
	public Pagina3()
	{
		InitializeComponent();
	}
    private void ConvertButton_Clicked(object sender, EventArgs e)
    {
        // Obtener los valores ingresados por el usuario
        string nombre = NombreEntry.Text;
        if (string.IsNullOrWhiteSpace(nombre))
        {
            DisplayAlert("Error", "Debe ingresar el nombre del dinosaurio.", "OK");
            return;
        }

        if (!double.TryParse(PesoKgEntry.Text, out double pesoKg))
        {
            DisplayAlert("Error", "Debe ingresar un peso v�lido en kilogramos.", "OK");
            return;
        }

        if (!double.TryParse(AlturaMetrosEntry.Text, out double alturaMetros))
        {
            DisplayAlert("Error", "Debe ingresar una altura v�lida en metros.", "OK");
            return;
        }

        // Convertir peso de kg a libras (1 kg = 2.20462 libras)
        double pesoLibras = pesoKg * 2.20462;

        // Convertir altura de metros a cent�metros (1 metro = 100 cent�metros)
        double alturaCm = alturaMetros * 100;

        // Mostrar resultados
        ResultadoLabel.Text = $"Nombre: {nombre}\n" +
                              $"Peso en libras: {pesoLibras:F2} lbs\n" +
                              $"Altura en cent�metros: {alturaCm:F2} cm";
    }
}