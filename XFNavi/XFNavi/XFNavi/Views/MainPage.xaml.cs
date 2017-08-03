using Xamarin.Forms;

namespace XFNavi.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnGoNext_Clicked(object sender, System.EventArgs e)
        {
            var fooPage = new NextPage();
            Navigation.PushAsync(fooPage);
        }
    }
}
