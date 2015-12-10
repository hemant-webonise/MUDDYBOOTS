
using Windows.UI.Popups;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using System;
using MUDDYBOOTS.Model;
using Flurl.Http;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using Windows.UI.Xaml;


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
            Survey selectedUser = (Survey)e.ClickedItem;  
            Frame.Navigate(typeof(DetailPage), selectedUser);
        }
        

        /*To sent the value from other Page to this page while navigation*/
        protected override  void OnNavigatedTo(NavigationEventArgs e)
        {
            value = (string)e.Parameter;
        }
    }
}
