namespace NuestroMenuApps11;

public partial class Pagina1 : ContentPage
{
	public Pagina1()
	{
		InitializeComponent();
	}
    private void OnCalcularCambioClicked(object sender, EventArgs e)
    {
        try
        {
            // Obtener los valores de las entradas
            decimal costo = Convert.ToDecimal(CostoEntry.Text);
            decimal dineroEntregado = Convert.ToDecimal(DineroEntregadoEntry.Text);

            // Calcular el cambio
            decimal cambio = dineroEntregado - costo;

            // Mostrar el resultado
            if (cambio < 0)
            {
                ResultadoLabel.Text = "El dinero entregado no es suficiente.";
            }
            else
            {
                ResultadoLabel.Text = $"Cambio a entregar: ${cambio:F2}";
            }
        }
        catch (Exception ex)
        {
            // Manejar errores de conversión
            ResultadoLabel.Text = "Por favor, ingrese valores válidos.";
        }
    }
}