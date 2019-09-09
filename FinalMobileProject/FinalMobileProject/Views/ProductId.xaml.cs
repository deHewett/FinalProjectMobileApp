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
    public partial class ProductId : ContentPage
    {
        public ProductId( string Image, string Title, string Price, string Description)
        {
            InitializeComponent();

            MyImageCall.Source = new UriImageSource()
            {
                Uri = new Uri(Image)
            };
            MyTitle.Text = Title;
            MyPrice.Text = Price;
            MyDescription.Text = Description;



        }

        
    }
}