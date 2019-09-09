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
    public partial class PayNow : ContentPage
    {
        public PayNow()
        {
            InitializeComponent();
            this.Title = "Pay Now";
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ThankYou());
        }
    }
}