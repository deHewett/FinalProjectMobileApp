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
    public partial class SignUp : ContentPage
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            Models.User user = new Models.User()
            {
                Username = Username.Text,
                Password = Password.Text,
                FullName = FullName.Text,
                Email = Email.Text,
                BillingAddress = Address.Text,
            };
            Hashing.HashPassword(user.Password);
            using (SQLite.SQLiteConnection conn = new SQLite.SQLiteConnection(App.DB_PATH))
            {
                conn.CreateTable<Models.User>();
                var numberOfRows = conn.Insert(user);
                if (numberOfRows > 0)
                {
                    await DisplayAlert("Sucess", "User added", "Great");
                    await Navigation.PopAsync();
                }
            }
        }
    }
}