using Flaggen.Views;
using System.Diagnostics;
using System;
using Xamarin.Forms;

namespace Flaggen
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            try
            {
                MainPage = new NavigationPage(new QuizPage());
            }
            catch (Exception ex)
            {
                // Log the error message
                Debug.WriteLine($"Error: {ex.Message}");

                // Display a message to the user
                
            }
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
