using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace TommyRathore
{
     /// <summary>
     /// An empty page that can be used on its own or navigated to within a Frame.
     /// </summary>
     public sealed partial class BlankPage1 : Page
     {
          public BlankPage1()
          {
               this.InitializeComponent();
          }


          protected override void OnNavigatedTo(NavigationEventArgs e)
          {
             var name =  ApplicationData.Current.LocalSettings.Values["Name"] ;
              var food =  ApplicationData.Current.LocalSettings.Values["Food"];
               tbl_food.Text = food.ToString() ;
               tbl_name.Text = name.ToString();

          }
     }
}
