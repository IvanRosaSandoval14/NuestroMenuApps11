namespace NuestroMenuApps11;

public partial class Pagina5 : ContentPage
{
	public Pagina5()
	{
		InitializeComponent();


        MessagingCenter.Subscribe<ContentPage, Surveys>(this, Messages.NewSurveyComplete, (sender, args) =>
        {
            SurveysPanel.Children.Add(new Label() { Text = args.ToString() });
        });
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Pagina6());

    }
}