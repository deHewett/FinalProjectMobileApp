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
         string pImage;
         string pPrice;
        

        public ProductId(string Image, string Title, string Price, string Description)
        {
            InitializeComponent();

            MyImageCall.Source = Image;
            MyTitle.Text = Title;
            MyPrice.Text = "$" + Price;
            MyDescription.Text = Description;
            pImage = Image;
            pPrice = Price;


        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            CartRecord pd = new CartRecord();
            int qty = Convert.ToInt32(Qty.Text);
            int total = Convert.ToInt16(pPrice);
            pd.Name = MyTitle.Text;
            pd.Price = MyPrice.Text;
            pd.Total = (qty * total).ToString();
            pd.Qty = qty + "";
            pd.Image = pImage;
            CartQuery c = new CartQuery();
            c.InsertDetails(pd);
            Navigation.PushAsync(new Cart());
        }
    }
}