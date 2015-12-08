
using Windows.UI.Xaml;
using Flurl.Http;
using Windows.UI.Xaml.Controls;
using MUDDYBOOTS.Model;
using Windows.UI.Popups;
using System;


// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace MUDDYBOOTS
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class LoginPage : Page, IDisposable
    {
        string Auth_token;

        public LoginPage()
        {
            this.InitializeComponent();
        }

        public void Dispose()
        {
            /*Required for using the Dialogs Below*/
            throw new NotImplementedException();
        }

        private async void Login(object sender, RoutedEventArgs e)
        {
            /*FLURL - used for making an post */
            string username = Username.Text;
            string password = Password.Password;
            var responseJString = await StringUtils.stageDataMapperLogin.PostUrlEncodedAsync(new { username = username, password = password }).ReceiveString();

            SuccessStatus pref = new SuccessStatus(responseJString);
            Auth_token = pref.Auth_token;
            if (Auth_token != null)
            {
                MessageDialog messageDialog = new MessageDialog("Login Successful");
                await messageDialog.ShowAsync();
            }
            else
            {
                MessageDialog messageDialog = new MessageDialog("Login UnSuccessful");
                await messageDialog.ShowAsync();
            }

            Log.Content = pref.Auth_token;

        }
    }
}
