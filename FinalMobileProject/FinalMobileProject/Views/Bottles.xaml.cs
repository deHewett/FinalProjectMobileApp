using FinalMobileProject.ViewModels;
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
    public partial class Bottles : ContentPage
    {
        public Bottles()
        {
            InitializeComponent();
            BindingContext = new BottlesPageModel();
            this.Title = "Bottles";
            this.BackgroundImage = "background.jpg";
        }

        private async void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var myDetails = e.Item as Bottle;
            await Navigation.PushAsync(new ProductId(myDetails.Image, myDetails.Title, myDetails.Price, myDetails.Description));
        }
    }
}