using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.Storage;
using Windows.Devices.Geolocation;
using Windows.UI.Popups;
using Windows.UI.Xaml.Controls.Maps;
// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace TommyRathore
{
     /// <summary>
     /// An empty page that can be used on its own or navigated to within a Frame.
     /// </summary>
     public sealed partial class MainPage : Page
     {
          public MainPage()
          {
               this.InitializeComponent();
               Stupidity();
          }

          void SampleMethod()
          {
               //Pehla Tareeqa
               // var localSettings = ApplicationData.Current.LocalSettings;
               //localSettings.Values["Test"] = "Test";
               //Dusra Tareeqa
               ApplicationData.Current.LocalSettings.Values["Name"] = "Saad Mahmood";
               ApplicationData.Current.LocalSettings.Values["Food"] = "Steak | Rib Eye";

               // var Rathore = ApplicationData.Current.LocalSettings.Values["Location"];
          }

          private void navigate_topage_Click(object sender, RoutedEventArgs e)
          {
               this.Frame.Navigate(typeof(BlankPage1));
          }

          private async void Button_Click(object sender, RoutedEventArgs e)
          {
               var geoLocator = new Geolocator();
               geoLocator.DesiredAccuracy = PositionAccuracy.High;
               var Geopositionpos = await geoLocator.GetGeopositionAsync();
               var latitude = Geopositionpos.Coordinate.Point.Position.Latitude;
               geoLocator.PositionChanged += GeoLocator_PositionChanged;
               var longitude = Geopositionpos.Coordinate.Point.Position.Longitude;
               var myPoint = new Geopoint(new BasicGeoposition { Latitude = latitude, Longitude = longitude });
               MapIcon myPOI = new MapIcon { Location = myPoint, NormalizedAnchorPoint = new Point(0.5, 1.0), Title = "Nandos", ZIndex = 0 };
               //Polyline to draw on Map
               // add to map and center it
               myMap.MapElements.Add(myPOI);
               myMap.Center = myPoint;
               myMap.ZoomLevel = 10;
               
               
               //PushPin
               
               //var myPoint = new Geopoint(new BasicGeoposition { Latitude = latitude, Longitude = longitude });
               //MapIcon myPOI = new MapIcon { Location = myPoint, NormalizedAnchorPoint = new Point(0.5, 1.0), Title = "Nandos", ZIndex = 0 };
               //myMap.MapElements.Add(myPOI);


          }

          private void GeoLocator_PositionChanged(Geolocator sender, PositionChangedEventArgs args)
          {
               throw new NotImplementedException();
          }
     }
}
