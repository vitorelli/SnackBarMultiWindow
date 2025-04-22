namespace SnackBarMultiWindow
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Application.Current?.OpenWindow(new Window(new NewPage1(this)));
        }
    }

}
