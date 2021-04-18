using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.IO;
using System.Threading.Tasks;
using System.Threading;

namespace App4
{
    public partial class App : Application
    {
        static SQLiteHelper db;
        
        public App()
        {
           
            InitializeComponent();
            
            MainPage = new MainPage();
        }

        public static SQLiteHelper SQLiteDatabase
        {
            get
            {
                if (db == null)
                {
                    db = new SQLiteHelper(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "magBrzyski2.db3"));
                }
                return db;
            }
        }
      //  void kkk() { MainPage = new MainPage(); }
        protected override void OnStart()
        {
            // ThreadStart ts = new ThreadStart(kkk);

            // Thread pochodnyWatek = new Thread(ts);
            // Uruchamiamy wątek pochodny
            //pochodnyWatek.Start();
            //MainPage = new MainPage();

            
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}