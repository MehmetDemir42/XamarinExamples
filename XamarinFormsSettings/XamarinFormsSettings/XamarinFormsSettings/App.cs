using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using XamarinFormsSettings.Helpers;

namespace XamarinFormsSettings
{
    public class App : Application
    {
        public App()
        {
            // The root page of your application

          //  Settings.DeviceName = "Mehmet'in Cihazı";


            var content = new ContentPage
            {
                Title = "XamarinFormsSettings",
                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.Center,
                    Children = {
                        new Label {
                            HorizontalTextAlignment = TextAlignment.Center,
                            
                            Text = Settings.DeviceName
                        }
                    }
                }
            };

            MainPage = new NavigationPage(content);
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
