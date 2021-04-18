

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace App4
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    //[DesignTimeVisible(false)]
    
    public partial class MainPage : ContentPage
    {
        
        
        public MainPage()
        {
            InitializeComponent();
            
        }

        async private void btnAdd_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Page1());
            
        }
    /*    async void MyMainThreadCode()
        {
            // Code to run on the main thread
            await Navigation.PushModalAsync(new Page2());
        }
        async void Threadhelper()
        {

            await Navigation.PushModalAsync(new Page2());
           
            
        }
        */
      async private void btnLicz_Clicked(object sender, EventArgs e)
        {
           /* ThreadStart ts = new ThreadStart(Threadhelper);
           // Console.WriteLine("Główny wątek: Tworzenie wątku pochodnego");
            Thread thread = new Thread(ts);
            // Uruchamiamy wątek pochodny
           thread.Start();
            // zatrzymanie głównego wątku
            Thread.Sleep(2000);*/
            
            await Navigation.PushModalAsync(new Page3());
            
            await Task.Delay(100);
        }

       async private void Button_Clicked(object sender, EventArgs e)
        {
           await DisplayAlert("Autor", "Jan Brzyski Uniwersytet Przyrodniczy w Poznaniu","OK");
            await Task.Delay(100);

        }

        /*  async private void btnLicz_Clicked(object sender, EventArgs e)
          {
              await Navigation.PushModalAsync(new Page1());
          }

          async private void btnAdd_Clicked(object sender, EventArgs e)
          {
              await Navigation.PushModalAsync(new Page2());
          }*/
    }
}
