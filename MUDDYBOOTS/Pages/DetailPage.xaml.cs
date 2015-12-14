
using Windows.Foundation;
using Windows.UI.Core;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Maps;
using Windows.UI.Xaml.Navigation;
using MUDDYBOOTS.Model;
using Windows.Devices.Geolocation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace MUDDYBOOTS.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class DetailPage : Page
    {
        Survey user;

        public DetailPage()
        {
            this.InitializeComponent();
          
            var currentView = SystemNavigationManager.GetForCurrentView();
            currentView.AppViewBackButtonVisibility = AppViewBackButtonVisibility.Visible;
            currentView.BackRequested += backButton_Tapped;
            DetailMap.Style = MapStyle.Road;
        }
        private void backButton_Tapped(object sender, BackRequestedEventArgs e)
        {
            var currentView = SystemNavigationManager.GetForCurrentView();
            currentView.AppViewBackButtonVisibility = AppViewBackButtonVisibility.Collapsed;
            if (Frame.CanGoBack) Frame.Navigate(typeof(WelcomePage));
        }
        /*To sent the value from other Page to this page while navigation*/
        protected override  void OnNavigatedTo(NavigationEventArgs e)
        {
             user = (Survey)e.Parameter;
            /*Check the navigated Values*/
            /*We imported System here instead of using Dispose as we did before in LOGINPAGE*/
            Title.Text = user.title;
            SetMapIcons();
        }

        private void SetMapIcons()
        {
            // Specify a known location.
            BasicGeoposition snPosition = new BasicGeoposition() { Latitude = user.latitude, Longitude = user.longitude };
            Geopoint snPoint = new Geopoint(snPosition);

            // Create a MapIcon.
            MapIcon POI = new MapIcon();
            POI.Location = snPoint;
            POI.NormalizedAnchorPoint = new Point(0.5, 1.0);
            POI.Title = user.title;
              
            // Center the map over the POI.
            DetailMap.MapElements.Add(POI);
            DetailMap.Center = snPoint;
            DetailMap.ZoomLevel = 10;

        }
    }
}
