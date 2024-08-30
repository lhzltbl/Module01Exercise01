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

        private void ClickedLightMode(object sender, EventArgs e)
        {
            this.Resources["LocalBackgroundColor"] = Colors.White;
            Resources["LocalTextColor"] = Colors.Black;
        }

        private void ClickedDarkMode(object sender, EventArgs e)
        {
            this.Resources["LocalBackgroundColor"] = Colors.DimGray;
            Resources["LocalTextColor"] = Colors.White;
        }
    }

}
