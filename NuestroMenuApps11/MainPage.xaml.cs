namespace NuestroMenuApps11
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnPage1ButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Pagina1());
        }

        private async void OnPage2ButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Pagina2());
        }
        private async void OnPage3ButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Pagina3());
        }

        private async void OnPage4ButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Pagina4());
        }

        private async void OnPage5ButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Pagina5());
        }

        private async void OnPage6ButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Pagina6());
        }
    }

}
