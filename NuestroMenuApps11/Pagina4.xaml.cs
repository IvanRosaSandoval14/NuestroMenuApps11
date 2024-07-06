namespace NuestroMenuApps11;

public partial class Pagina4 : ContentPage
{
	public Pagina4()
	{
		InitializeComponent();
	}

    private void OnCalcularCobroClicked(object sender, EventArgs e)
    {
        try
        {
            // Obtener los valores de las entradas
            decimal galones = Convert.ToDecimal(GalonesEntry.Text);
            decimal precioPorLitro = Convert.ToDecimal(PrecioPorLitroEntry.Text);

            // Convertir galones a litros (1 galón = 3.78541 litros)
            decimal litros = galones * 3.78541m;

            // Calcular el cobro total
            decimal totalCobro = litros * precioPorLitro;

            // Mostrar el resultado
            ResultadoLabel.Text = $"Total a cobrar: ${totalCobro:F2}";
        }
        catch (Exception ex)
        {
            // Manejar errores de conversión
            ResultadoLabel.Text = "Por favor, ingrese valores válidos.";
        }
    }
}