using FinalMobileProject.Models;
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
    public partial class Cart : ContentPage
    {
        public Cart()
        {
          
            InitializeComponent();
           this.Title = "Cart";
           // this.BackgroundImage = "background.png";
            CartQuery c = new CartQuery();


            cart.ItemsSource = c.GetList();
            total.Text = c.GetTotal() + "";
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
         //   DisplayAlert("Login", "Login required to complete the order process.", "Login Now");
            Navigation.PushAsync(new PayNow());
        }
    }
}