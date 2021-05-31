using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using RecFacial.DatabaseDriver.Management;
using System.IO;

namespace RecFacial
{
    public partial class App : Application
    {
        static MasterConnection db;
        public App()
        {
            InitializeComponent();            
            MainPage = new NavigationPage(new AccountControl.Login());
        }

        public static MasterConnection MCHelper
        {
            get 
            {
                if (db==null)
                {
                    db = new MasterConnection(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),"RecFacial.db3"));
                }
                return db; 
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
