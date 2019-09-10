using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FinalMobileProject.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ThankYou : ContentPage
    {
        public ThankYou()
        {
            InitializeComponent();
            this.Title = "Thank You";
            this.BackgroundImage = "background.jpg";
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainMenu());
        }
    }
}