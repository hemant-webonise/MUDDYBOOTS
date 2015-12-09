using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Core;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Maps;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using MUDDYBOOTS.Model;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace MUDDYBOOTS.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class DetailPage : Page
    {

        public DetailPage()
        {
            this.InitializeComponent();
          
            var currentView = SystemNavigationManager.GetForCurrentView();
            currentView.AppViewBackButtonVisibility = AppViewBackButtonVisibility.Visible;
            currentView.BackRequested += backButton_Tapped;
            myMap.Style = MapStyle.Road;
        }
        private void backButton_Tapped(object sender, BackRequestedEventArgs e)
        {
            if (Frame.CanGoBack) Frame.GoBack();
        }
        /*To sent the value from other Page to this page while navigation*/
        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            var user = (Payload)e.Parameter;
            /*Check the navigated Values*/
            /*We imported System here instead of using Dispose as we did before in LOGINPAGE*/
            Title.Text = user.Title;
            MessageDialog messageDialog = new MessageDialog(user.Title);
            await messageDialog.ShowAsync();

        }
    }
}
