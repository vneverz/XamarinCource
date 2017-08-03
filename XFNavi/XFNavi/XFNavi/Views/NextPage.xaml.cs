using Xamarin.Forms;

namespace XFNavi.Views
{
    public partial class NextPage : ContentPage
    {
        public NextPage()
        {
            InitializeComponent();
        }

        private void btnCoBack_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}
