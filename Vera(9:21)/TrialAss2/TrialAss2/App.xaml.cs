using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.IO;

namespace TrialAss2
{
    public partial class App : Application
    {
        public static Database myDatabase;
        public static Database MyDatabase
        {
            get
            {
                if(myDatabase == null)
                {
                    string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "");
                    myDatabase = new Database(path);
                }
                return myDatabase;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
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
