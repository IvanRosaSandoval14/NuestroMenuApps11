namespace NuestroMenuApps11;

public partial class Pagina6 : ContentPage
{

    private readonly string[] teams =
    {
        "Alianza Lima",
        "America",
        "Boca Juniors",
        "Caracas FC",
        "Colo-Colo",
        "Peñarol",
        "Real Madrid",
        "Saprissa"
    };
    public Pagina6()
	{
		InitializeComponent();
	}

    private async void FavoriteTeamButton_Clicked(object sender, EventArgs e)
    {
        var favoriteTeam = await DisplayActionSheet(Literals.FavoriteTeamTitle, null, null, teams);
        if (!string.IsNullOrWhiteSpace(favoriteTeam))
        {
            FavoriteTeamLabel.Text = favoriteTeam;
        }
    }


    private async void OkButton_Clicked(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(NameEntry.Text) || string.IsNullOrWhiteSpace(FavoriteTeamLabel.Text))
        {
            return;
        }

        var newSurvey = new Surveys()
        {
            Name = NameEntry.Text,
            Birthdate = BirthdatePicker.Date,
            FavoriteTeam = FavoriteTeamLabel.Text
        };

        MessagingCenter.Send(this, Messages.NewSurveyComplete, newSurvey);

        await Navigation.PopAsync();
    }
}