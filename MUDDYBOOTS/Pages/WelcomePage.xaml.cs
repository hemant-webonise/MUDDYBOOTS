
using Windows.UI.Popups;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using System;
using MUDDYBOOTS.Model;
using Flurl.Http;


// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace MUDDYBOOTS.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class WelcomePage : Page
    {
        string value;

        public WelcomePage()
        {
            this.InitializeComponent();
            GetResonpseFromAPI();
        }

        private async void GetResonpseFromAPI()
        {
            /*
            replaced value - JwyTmmsxVxBy1iGcuC76 for stagging
            */
            var responseJString = await StringUtils.testDataMapperSurvey.WithHeader("AUTH_TOKEN", value).GetStringAsync();
            DataContext = new Users(StringUtils.fakeResponseSurveyString);
            Change.Text = responseJString;
            /*
            Could be used to see JSON
            Change.Text = StringUtils.fakeResponseSurveyString;
            */

        }

        private void Education_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frame.Navigate(typeof(DetailPage));
        }

        /*To sent the value from other Page to this page while navigation*/
        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            value = (string)e.Parameter;
            /*Check the navigated Values*/
            /*We imported System here instead of using Dispose as we did before in LOGINPAGE*/
            MessageDialog messageDialog = new MessageDialog(value);
            await messageDialog.ShowAsync();

        }
    }
}
