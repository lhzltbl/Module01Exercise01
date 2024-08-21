namespace Module01Exercise01
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void SavedChanges(object sender, EventArgs e)
        {
            await DisplayAlert("Your profile has been updated.", "Thank you for submitting", "Ok");
        }
    }

}
