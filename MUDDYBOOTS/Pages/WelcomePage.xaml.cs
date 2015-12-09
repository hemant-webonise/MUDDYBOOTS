
using Windows.UI.Popups;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using System;
using MUDDYBOOTS.Model;
using Flurl.Http;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;


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

        private  void GetResonpseFromAPI()
        {

            /*
            HTTPCLIENT Attemp
            */
            /*HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(StringUtils.testDataMapperSurvey);            
            client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json; charset=utf-8");

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, "AUTH_TOKEN");
            request.Content = new StringContent("{\"name\":\"John Doe\",\"age\":33}", Encoding.UTF8, "application/json");
            await client.SendAsync(request)
                              .ContinueWith(responseTask =>
                              {
                                  Change.Text = responseTask.Result.ToString();
                              });*/
            /*
            replaced value - JwyTmmsxVxBy1iGcuC76 for stagging
            */
            using (var clientWithHeader = new FlurlClient().WithHeader("AUTH_TOKEN", "JwyTmmsxVxBy1iGcuC76"))
            {
                //var responseJString = await StringUtils.testDataMapperSurvey.WithClient(clientWithHeader).GetStringAsync();/*GetJsonAsync<Users>();*/
                //Change.Text = responseJString;
            }
            DataContext = new Users(StringUtils.fakeResponseSurveyStringUpdate);
           
            /*
            Could be used to see JSON
            Change.Text = StringUtils.fakeResponseSurveyString;
            */

        }

        private void Education_ItemClick(object sender, ItemClickEventArgs e)
        {
            var selectedUser = (Survey)e.ClickedItem;
           
            Payload payload = new Payload();
            payload.Title = selectedUser.title;
            payload.Latitude = selectedUser.latitude;
            payload.Longitude = selectedUser.longitude;

            Frame.Navigate(typeof(DetailPage),payload);
        }

        /*To sent the value from other Page to this page while navigation*/
        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            value = (string)e.Parameter;
            /*Check the navigated Values*/
            /*We imported System here instead of using Dispose as we did before in LOGINPAGE*/
            //MessageDialog messageDialog = new MessageDialog(value);
            //await messageDialog.ShowAsync();

        }
    }
}
