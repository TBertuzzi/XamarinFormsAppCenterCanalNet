using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsAppCenter.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
        }

        private void btnCrash(object sender, EventArgs e)
        {
            Crashes.GenerateTestCrash();
        }


        private void btnCrashCategoria(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt32("vai dar erro");
            }
            catch (Exception exception)
            {
                var properties = new Dictionary<string, string> {
                { "Tela", "AboutPage" },
                { "Wifi", "On" }
              };
                Crashes.TrackError(exception, properties);
            }
        }

        private void btnEvent(object sender, EventArgs e)
        {
            Analytics.TrackEvent("Gerar um Evento Customizavel");
        }
    }
}