using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinBlackjack
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void NewGameButton_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new NavigationPage(new GamePage()));
        }
    }
}
