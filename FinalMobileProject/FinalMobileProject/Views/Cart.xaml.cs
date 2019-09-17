using FinalMobileProject.Models;
using FinalMobileProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FinalMobileProject.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Cart : ContentPage
    {
        CartQuery c = new CartQuery();
        public Cart()
        {
          
            InitializeComponent();
           this.Title = "Cart";
            
           
            


            cart.ItemsSource = c.GetList();
            total.Text = c.GetTotal() + "";
            
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

            if (c.GetTotal() > 0)
            {
                Navigation.PushAsync(new PayNow());
            }
            else {
                DisplayAlert("There is nothing in the cart. Please continue shopping","","Return");
            }
            
        }

        
    }
}